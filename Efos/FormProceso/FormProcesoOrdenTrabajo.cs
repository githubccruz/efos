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
    public partial class FormProcesoOrdenTrabajo : FormBaseProceso
    {
        DataTable data = null;

        public FormProcesoOrdenTrabajo()
        {
            InitializeComponent();
            checkEstado.Checked = false;            
        }

        private void txtCodigoPaciente_Validated(object sender, EventArgs e)
        {
            if (txtCodigoPaciente.Text == 0.ToString() || String.IsNullOrEmpty(txtCodigoPaciente.Text))
            {
                limpiarDatosServicio();
                
                campoCodigo.Enabled = false;
                lupaServicio.Enabled = false;


                return;
            }
            try
            {
                string cmd = String.Format("SELECT * FROM vista_persona_consulta WHERE codigo in (SELECT coditerc FROM paciente_encabezado) AND codigo={0} AND estado=true", txtCodigoPaciente.Text);
                DataTable data = PostgreSQL.Execute(cmd);
                letreroNombrePaciente.Text = data.Rows[0]["nombre"].ToString();
                data.Dispose();
                campoCodigo.Enabled = true;
                lupaServicio.Enabled = true;
                dataGridServicios.Enabled = true;
            }
            catch (Exception)
            {
                letreroNombrePaciente.Text = "";
                if (MessageBox.Show("No existe informacion o el Paciente esta Inactivo, con el codigo digitado ==>" + txtCodigoPaciente.Text + "\n, ¿Desea usar el Buscador?", "Consejo || Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lupaPaciente_Click(null, null);
                }
                campoCodigo.Enabled = false;
                lupaServicio.Enabled = false;
            }
        }

        private void dataGridServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(dataGridServicios, e.ColumnIndex, e.RowIndex);
        }

        private void limpiarDatosServicio()
        {
            campoCodigo.Text = "";
            campoDescripcioServicio.Text = "";
            campoPrecio.Text = 0.ToString();
            campoCantidad.Text = 0.ToString();

            comboTipoPrecio.Enabled = false;
            comboTipoPrecio.SelectedIndex = -1;
            campoCodigo.Focus();
        }

        private void cargarInformacionCombo(bool estado = true)
        {
            if (estado)
            {
                //PostgreSQL.FillComboBox(comboTipoPrecio, "coditips", "desctips", "tipo_precio_servicio_encabezado", filter: "estado=true");
                PostgreSQL.FillComboBox(comboTipoNCF, "coditico", "desctico", "tipo_comprobante_fiscal_encabezado", filter: "estado=true");
            }
            else
            {
                //PostgreSQL.FillComboBox(comboTipoPrecio, "coditips", "desctips", "tipo_precio_servicio_encabezado");
                PostgreSQL.FillComboBox(comboTipoNCF, "coditico", "desctico", "tipo_comprobante_fiscal_encabezado");
            }
        }

        private void efosButtonBuscador2_Click(object sender, EventArgs e)
        {
            if (campoCodigo.Text == 0.ToString() ||
                    String.IsNullOrEmpty(campoCodigo.Text) ||
                        campoCantidad.Text == 0.ToString() ||
                            String.IsNullOrEmpty(campoCantidad.Text))
            {                
                return;
            }


            foreach (DataGridViewRow row in dataGridServicios.Rows)
            {
                if (campoCodigo.Text.ToString().Trim() == row.Cells[0].Value.ToString().Trim() &&
                    comboTipoPrecio.Text.Equals(row.Cells[3].Value.ToString()))
                {
                    row.Cells[0].Value = campoCodigo.Text.ToString().Trim();                    
                    row.Cells[3].Value = comboTipoPrecio.Text;
                    row.Cells[4].Value = (Convert.ToDouble(campoCantidad.Text.ToString().Trim()) + Convert.ToDouble(row.Cells[4].Value.ToString()));                    
                    row.Cells[6].Value = (Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[5].Value)).ToString();
                    limpiarDatosServicio();
                    txtCodigoPaciente.Enabled = false;
                    lupaPaciente.Enabled = false;
                    return;
                }
            }

            int newRow = dataGridServicios.Rows.Add(1);
            dataGridServicios.Rows[newRow].Cells[0].Value = campoCodigo.Text.ToString().Trim();
            dataGridServicios.Rows[newRow].Cells[1].Value = campoDescripcioServicio.Text.ToString().Trim();            
            dataGridServicios.Rows[newRow].Cells[2].Value = comboTipoPrecio.SelectedValue.ToString();            
            dataGridServicios.Rows[newRow].Cells[3].Value = comboTipoPrecio.Text;
            dataGridServicios.Rows[newRow].Cells[4].Value = Convert.ToDouble(campoCantidad.Text.ToString().Trim());
            dataGridServicios.Rows[newRow].Cells[5].Value = campoPrecio.Text.ToString().Trim();
            dataGridServicios.Rows[newRow].Cells[6].Value = (Convert.ToDouble(dataGridServicios.Rows[newRow].Cells[4].Value) * Convert.ToDouble(dataGridServicios.Rows[newRow].Cells[5].Value)).ToString();

            txtCodigoPaciente.Enabled = false;
            lupaPaciente.Enabled = false;
            limpiarDatosServicio();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            limpiarDatosServicio();
            dataGridServicios.Rows.Clear();
            cargarInformacionCombo();
        }

        private void campoCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                efosButtonBuscador2_Click(null, null);                
                return;
            }
        }

        private void lupaPaciente_Click(object sender, EventArgs e)
        {
            
        }

        private void asignarPrecio()
        {
            if (comboTipoPrecio.Enabled && data != null)
            {
                var results = (from m in data.AsEnumerable()
                               where m.Field<int>("coditips") == Convert.ToInt32(comboTipoPrecio.SelectedValue)
                               select m).FirstOrDefault();

                campoPrecio.Text = results["precserv"].ToString();
            }
        }

        private void campoCodigo_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(campoCodigo.Text) ||
                String.IsNullOrWhiteSpace(campoCodigo.Text) ||
                campoCodigo.Text == 0.ToString())
            {
                return;
            }
            string cmd = String.Format("SELECT * FROM vista_servicio_precios WHERE codiserv={0} and estado_servicio=true and estado_precio=true", campoCodigo.Text);
            try
            {
                data = PostgreSQL.Execute(cmd);

                campoDescripcioServicio.Text = data.Rows[0][campoDescripcioServicio.CampoBD].ToString();
                comboTipoPrecio.DataSource = data;
                comboTipoPrecio.DisplayMember = "desctips";
                comboTipoPrecio.ValueMember = "coditips";
            }
            catch (Exception)
            {
                MessageBox.Show("No hay informacion con el Codigo <<"+ campoCodigo.Text+">>");
                comboTipoPrecio.Enabled = false;
                campoCantidad.Enabled = false;
                botonAgregar.Enabled = false;
                comboTipoPrecio.SelectedIndex = -1;
                limpiarDatosServicio();
                return;
            }
            comboTipoPrecio.Enabled = true;
            campoCantidad.Enabled = true;
            botonAgregar.Enabled = true;

            comboTipoPrecio_SelectedIndexChanged(null, null);
        }

        private void comboTipoPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            asignarPrecio();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
