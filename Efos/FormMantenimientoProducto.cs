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
    public partial class FormMantenimientoProducto : FormBaseMantenimiento
    {
        public FormMantenimientoProducto()
        {
            InitializeComponent();
            campoFechaCreacion.Text = DateTime.Now.ToString().Substring(0, 10);
            habilitarCampos(this.Controls, false);
            txtCodigo.Enabled = true;
            campoCostoPromedio.Enabled = false;
        }

        private void cargarInformacion()
        {
            campoFechaCreacion.Text = DateTime.Now.ToString().Substring(0, 10);
            campoFechaCreacion.Enabled = false;
            campoCostoPromedio.Enabled = false;
            txtCodigo.Text = 0.ToString();
            cargarInformacionCombos(true);
        }
        private void cargarInformacionCombos(bool estado){
            comboTipoProducto.DataSource = null;
            columnaTipoPrecio.DataSource = null;

            if(estado){
                PostgreSQL.FillComboBox(comboTipoProducto, "coditipr", "desctipr", "tipo_producto_encabezado", filter: "estado=true");
                PostgreSQL.FillComboBox(columnaTipoPrecio, "coditipr", "desctipr", "tipo_precio_producto_encabezado",filter:"estado=true");
            }
            else{
                PostgreSQL.FillComboBox(comboTipoProducto, "coditipr", "desctipr", "tipo_producto_encabezado");
                PostgreSQL.FillComboBox(columnaTipoPrecio, "coditipr", "desctipr", "tipo_precio_producto_encabezado");
            }
        }
        private void botonNuevo_Click(object sender, EventArgs e)
        {
            cargarInformacion();
            gridPrecioProducto.Enabled = true;
        }

        private void gridPrecioProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(gridPrecioProducto, e.ColumnIndex, e.RowIndex);
        }

        private void campoCostoInicial_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == 0.ToString())
            {
                campoCostoPromedio.Text = campoCostoInicial.Text;
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string[] datos = {      txtCodigo.Text,  //0
                                 campoDescripcion.Text.Trim(),//1
                                 comboTipoProducto.SelectedValue.ToString(),//2
                                 campoExistencia.Text.ToString(),//3
                                 checkEstado.Checked.ToString(),//4
                                 campoCostoInicial.Text.Trim(),//5
                                 campoCostoPromedio.Text//6                                 
                                 };

            string cmd = String.Format("SELECT inserta_producto_encabezado({0},'{1}',{2},{3},{4},{5},{6});",datos);
            MessageBox.Show("Query: "+cmd);
            try
            {
                PostgreSQL.Execute(cmd);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error!!","Guardando Informacion ===>"+error.Message);                
            }
            cmd = String.Format("SELECT limpiaCodigoProductoPrecio({0})",txtCodigo.Text);
            PostgreSQL.Execute(cmd);

            foreach (DataGridViewRow row in gridPrecioProducto.Rows)
            {
                if (row.Cells[0].Value != null)
                {


                    cmd = String.Format("SELECT inserta_producto_vs_precio_detalle({0},{1}::numeric(20,4),{2})", txtCodigo.Text, row.Cells[1].Value.ToString(), row.Cells[0].Value.ToString());
                    MessageBox.Show("Test: " + cmd);
                    PostgreSQL.Execute(cmd);
                }
            }
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (txtCodigo.Text == 0.ToString() || String.IsNullOrEmpty(txtCodigo.Text.Trim()))
                return;
            cargarInformacionCombos(false);
            
            AccionCodigoValidado();
            DataTable data = PostgreSQL.Execute("SELECT * FROM producto_encabezado WHERE codiprod="+txtCodigo.Text.Trim());
            if (data.Rows != null)
            {
                txtCodigo.Text = data.Rows[0]["codiprod"].ToString();
                campoDescripcion.Text = data.Rows[0]["descprod"].ToString();
                comboTipoProducto.SelectedValue = Convert.ToInt32(data.Rows[0]["coditipr"].ToString());
                campoExistencia.Text = data.Rows[0]["exisprod"].ToString();
                checkEstado.Checked = Convert.ToBoolean(data.Rows[0]["estado"].ToString());
                campoCostoInicial.Text = data.Rows[0]["coinprod"].ToString();
                campoCostoPromedio.Text = data.Rows[0]["coprprod"].ToString();
                campoFechaCreacion.Text = data.Rows[0]["fechprod"].ToString().Substring(0,10);                    
            }

            data = PostgreSQL.Execute("select * from producto_vs_precio_detalle WHERE codiprod="+txtCodigo.Text.Trim());
            int indexRow = 0;
            gridPrecioProducto.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                gridPrecioProducto.Rows.Add(1);
                gridPrecioProducto.Rows[indexRow].Cells[0].Value = Convert.ToInt32(row["coditipr"].ToString());
                gridPrecioProducto.Rows[indexRow].Cells[1].Value = row["precprod"].ToString();
                indexRow++;
            }
            gridPrecioProducto.Enabled = false;
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            campoFechaCreacion.Enabled = false;
            campoExistencia.Enabled = false;            
            campoCostoPromedio.Enabled = false;

            gridPrecioProducto.Enabled = true;
        }
    }
}
