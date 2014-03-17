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
    public partial class FormProcesoFactura : FormBaseProceso
    {
        public FormProcesoFactura()
        {
            InitializeComponent();
            limpiarDatosProducto();
            lupaProducto.Enabled = false;
            dataGridFactura.Rows.Clear();
        }

        private void efosDataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0.00;

            foreach (DataGridViewRow row in dataGridFactura.Rows)
            {
                if (row.Cells[2].Value != null)
                {
                    row.Cells[4].Value = (Convert.ToDouble(row.Cells[2].Value) * Convert.ToDouble(row.Cells[3].Value)).ToString();
                    total += Convert.ToDouble(row.Cells[4].Value);
                }
            }
            campoTotal.Text = total.ToString();
        }     
        
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if (campoCodigo.Text == 0.ToString() ||
                    String.IsNullOrEmpty(campoCodigo.Text) ||
                        campoCantidad.Text == 0.ToString() ||
                            String.IsNullOrEmpty(campoCantidad.Text))
                return;

            foreach (DataGridViewRow row in dataGridFactura.Rows)
            {
                if (campoCodigo.Text.ToString().Trim()==row.Cells[0].Value.ToString().Trim())
                {
                    row.Cells[0].Value = campoCodigo.Text.ToString().Trim();
                    row.Cells[1].Value = campoDescripcion.Text.ToString().Trim();
                    row.Cells[2].Value = (Convert.ToDouble(campoCantidad.Text.ToString().Trim()) + Convert.ToDouble(row.Cells[2].Value)).ToString();
                    row.Cells[3].Value = campoPrecio.Text.ToString().Trim();
                    limpiarDatosProducto();
                    return;
                }
            }
            int newRow = dataGridFactura.Rows.Add(1);            
            dataGridFactura.Rows[newRow].Cells[0].Value = campoCodigo.Text.ToString().Trim();
            dataGridFactura.Rows[newRow].Cells[1].Value = campoDescripcion.Text.ToString().Trim();
            dataGridFactura.Rows[newRow].Cells[2].Value = campoCantidad.Text.ToString().Trim();
            dataGridFactura.Rows[newRow].Cells[3].Value = campoPrecio.Text.ToString().Trim();
            limpiarDatosProducto();
        }
        private void limpiarDatosProducto()
        {
            campoCodigo.Text = "";
            campoDescripcion.Text = "";
            campoPrecio.Text = 0.ToString();
            campoSubTotal.Text = 0.ToString();
            campoCantidad.Text = 0.ToString(); ;
        }

        private void dataGridFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (eliminarFila(dataGridFactura, e.ColumnIndex, e.RowIndex))
            {
                efosDataGridView1_CellValueChanged(null, null);
            }
        }

        private void campoCantidad_Validated(object sender, EventArgs e)
        {
            try
            {
                campoSubTotal.Text = (Convert.ToDouble(campoCantidad.Text) * Convert.ToDouble(campoPrecio.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("No se agrego el producto");
                campoCantidad.Focus();
            }
            
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            limpiarDatosProducto();
            dataGridFactura.Rows.Clear();
        }

        private void AccionBuscarLupa()
        {
        }

        private void campoCodigo_Validated(object sender, EventArgs e)
        {
            if (campoCodigo.Text == 0.ToString() ||
                    String.IsNullOrEmpty(campoCodigo.Text))
                return;
            string cmd = String.Format("SELECT * FROM producto_encabezado WHERE codiprod={0}",campoCodigo.Text);
            try
            {
                DataTable data = PostgreSQL.Execute(cmd);
                campoDescripcion.Text = data.Rows[0][campoDescripcion.CampoBD].ToString();
                campoPrecio.Text = data.Rows[0][campoPrecio.CampoBD].ToString();
                campoCantidad.Focus();
                data.Dispose();

            }
            catch (Exception)
            {
                if (MessageBox.Show("No existe informacion con el codigo <<" + campoCodigo.Text + ">>", "Consejo || Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AccionBuscarLupa();
                }
            }
            
        }

        private void campoCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(Keys.Enter))
                botonAgregar_Click(null, null);
        }
    }
}
