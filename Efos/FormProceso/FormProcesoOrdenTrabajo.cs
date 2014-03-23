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
        public FormProcesoOrdenTrabajo()
        {
            InitializeComponent();
            checkEstado.Checked = false;            
        }

        private void txtCodigoPaciente_Validated(object sender, EventArgs e)
        {
            if (txtCodigoPaciente.Text == 0.ToString() || String.IsNullOrEmpty(txtCodigoPaciente.Text))
                return;
            try
            {
                string cmd = String.Format("SELECT * FROM vista_persona_consulta WHERE codigo in (SELECT coditerc FROM paciente_encabezado) AND codigo={0} AND estado=true", txtCodigoPaciente.Text);
                DataTable data = PostgreSQL.Execute(cmd);
                letreroNombrePaciente.Text = data.Rows[0]["nombre"].ToString();
                data.Dispose();
            }
            catch (Exception)
            {
                letreroNombrePaciente.Text = "";
                if (MessageBox.Show("No existe informacion o el Paciente esta Inactivo, con el codigo digitado ==>" + txtCodigoPaciente.Text + "\n, ¿Desea usar el Buscador?", "Consejo || Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lupaPaciente_Click(null, null);
                }
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
                return;
            
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
                efosButtonBuscador2_Click(null, null);
        }

        private void lupaPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
