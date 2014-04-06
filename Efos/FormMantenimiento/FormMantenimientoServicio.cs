using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Efos
{
    public partial class FormMantenimientoServicio : FormBaseMantenimiento
    {
        public FormMantenimientoServicio()
        {
            InitializeComponent();
            campoFechaCreacion.Text = DateTime.Now.ToString().Substring(0, 10);
            habilitarCampos(this.Controls, false);
            txtCodigo.Enabled = true;
            campoCostoServicio.Enabled = false;
        }
        private void cargarInformacion()
        {
            campoFechaCreacion.Text = DateTime.Now.ToString().Substring(0, 10);
            campoFechaCreacion.Enabled = false;

            txtCodigo.Text = 0.ToString();
            cargaInformacionCombo(estado:true);
        }
        private void cargaInformacionCombo(bool estado)
        {
            if(estado)
            {
                PostgreSql.FillComboBox(comboTipoServicio, "coditise", "desctise", "tipo_servicio_encabezado", filter: "estado=true");
                PostgreSql.FillComboBox(columnaTipoPrecioServicio,"coditips","desctips","tipo_precio_servicio_encabezado",filter:"estado=true");
                PostgreSql.FillComboBox(columnaInsumo, "codiinsu", "descinsu", "insumo_encabezado", filter: "estado=true");
            }
            else
            {
                PostgreSql.FillComboBox(comboTipoServicio, "coditise", "desctise", "tipo_servicio_encabezado");
                PostgreSql.FillComboBox(columnaTipoPrecioServicio,"coditips","desctips","tipo_precio_servicio_encabezado");
                PostgreSql.FillComboBox(columnaInsumo, "codiinsu", "descinsu", "insumo_encabezado");
            }
        }
        private void campoDescripcion_Validated(object sender, EventArgs e)
        {
            campoDescripcion.Text = campoDescripcion.Text.ToString().ToUpper();
        }

        private void efosDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(dataGridPrecioServicio, e.ColumnIndex, e.RowIndex);
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            cargarInformacion();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string[] datos = { txtCodigo.Text,
                                 campoDescripcion.Text,
                                 comboTipoServicio.SelectedValue.ToString(),
                                 checkEstado.Checked.ToString(),
                                 campoCostoServicio.Text };

            try
            {
                string cmd = String.Format("SELECT inserta_servicio_encabezado({0},'{1}',{2},{3},{4});",datos);
                
                DataTable data = PostgreSql.Execute(cmd);
                var codigo = data.Rows[0][0].ToString();
                cmd = String.Format("SELECT limpiaCodigoServicioPrecio({0});",codigo);              
                PostgreSql.Execute(cmd);

                foreach (DataGridViewRow row in dataGridPrecioServicio.Rows)
                {                    
                    if (row.Cells[1].Value!=null)
                    {
                        cmd = String.Format("SELECT inserta_servicio_vs_precio_detalle({0},{1},{2});",codigo,row.Cells[0].Value,row.Cells[1].Value.ToString());
                        PostgreSql.Execute(cmd);
                    }
                }
                cmd = String.Format("SELECT limpiaCodigoServicioInsumo({0});", codigo);
                PostgreSql.Execute(cmd);
                foreach (DataGridViewRow row in dataGridInsumo.Rows)
                {
                    if (row.Cells[1].Value != null)
                    {
                        cmd = String.Format("SELECT inserta_servicio_vs_insumo_detalle({0},{1},{2});", codigo, row.Cells[0].Value, row.Cells[1].Value.ToString());
                        PostgreSql.Execute(cmd);
                    }
                }
                data.Dispose();
                cmd = null;
                datos = null;
                txtCodigo.Text = codigo;
                codigo = null;
            }
            catch (Exception error)
            {
                MessageBox.Show("Esto es Embarazoso, Hubo un error al intentar guardar la informacion... Referencia===>"+error.Message);
            }
            
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if(txtCodigo.Text==0.ToString() || String.IsNullOrEmpty(txtCodigo.Text))
                return;

            try
            {
                string cmd = "SELECT * FROM servicio_encabezado WHERE codiserv=" + txtCodigo.Text;
                DataTable data = PostgreSql.Execute(cmd);
                cargaInformacionCombo(false);
                campoDescripcion.Text = data.Rows[0]["descserv"].ToString();
                campoCostoServicio.Text = data.Rows[0]["costserv"].ToString();
                comboTipoServicio.SelectedValue = Convert.ToInt32(data.Rows[0]["coditise"].ToString());
                checkEstado.Checked = Convert.ToBoolean(data.Rows[0]["estado"].ToString());
                campoFechaCreacion.Text = data.Rows[0]["fechserv"].ToString().Substring(0, 10);

                cmd = "SELECT * FROM servicio_vs_precio_detalle WHERE codiserv=" + txtCodigo.Text.Trim();
                data = PostgreSql.Execute(cmd);
                dataGridPrecioServicio.Rows.Clear();

                int indexRows = 0;
                foreach (DataRow row in data.Rows)
                {
                    dataGridPrecioServicio.Rows.Add(1);
                    dataGridPrecioServicio.Rows[indexRows].Cells[0].Value = Convert.ToInt32(row["coditips"].ToString());
                    dataGridPrecioServicio.Rows[indexRows].Cells[1].Value = row["precserv"].ToString();
                    indexRows++;
                }

                cmd = "SELECT * FROM servicio_vs_insumo_detalle WHERE codiserv="+ txtCodigo.Text.Trim();
                data = PostgreSql.Execute(cmd);
                dataGridInsumo.Rows.Clear();

                indexRows = 0;
                foreach (DataRow row in data.Rows)
                {
                    dataGridInsumo.Rows.Add(1);
                    dataGridInsumo.Rows[indexRows].Cells[0].Value = Convert.ToInt32(row["codiinsu"].ToString());
                    dataGridInsumo.Rows[indexRows].Cells[1].Value = row["cantinsu"].ToString();
                    indexRows++;
                }

                data.Dispose();
                cmd = null;
                AccionCodigoValidado();
            }
            catch (Exception)
            {
                MessageBox.Show("Este codigo no existe <<<"+txtCodigo.Text+">>>");
                limpiarControles(this.Controls);
                habilitarCampos(this.Controls, false);
                AccionBotonCancelar();
                txtCodigo.Enabled = true;
                campoFechaCreacion.Enabled = false;
                txtCodigo.Text = 0.ToString();
            }
        }

        private void efosDataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(dataGridInsumo, e.ColumnIndex, e.RowIndex);
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            //limpiarControles(this.Controls);            
        }
    }
}
