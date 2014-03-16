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
    public partial class FormBaseConsulta : FormBase
    {
        #region Propiedades
            private string TablaDB { set; get; }
            public string valorCodigo { set; get; }
        #endregion
        
        
        string campoCodigo,campoDescripcion,campoEstado;

        private void inicializar()
        {
            InitializeComponent();
            radioDescripcion.Checked = true;
            DataGrid.BackgroundColor = this.BackColor;
        }
        public FormBaseConsulta()
        {
            inicializar();
        }
        public FormBaseConsulta(string titulo)
        {
            inicializar();
            txtTitulo.Text = titulo.Trim();            
        }
        public FormBaseConsulta(string titulo,
                                string tablaDB,
                                string campoCodigo,
                                string campoDescripcion,
                                string campoEstado)
        {
            inicializar();
            txtTitulo.Text = titulo.Trim().Replace("Mantenimiento","Busqueda");

            this.TablaDB = tablaDB.Trim();
            this.campoCodigo = campoCodigo;
            this.campoDescripcion = campoDescripcion;
            this.campoEstado = campoEstado;
        }
        public void AccionBuscar()
        {

            String[] parametros = new String[5];
            parametros[0] = campoCodigo;
            parametros[1] = campoDescripcion;
            parametros[2] = campoEstado;
            parametros[3] = TablaDB;
            parametros[4] = txtDescripcion.Text.Trim().ToUpper();
            string cmd;
            cmd = String.Format("SELECT {0}, {1}, {2} FROM {3} WHERE {1} like '{4}%' ORDER BY {1};",parametros);
            DataTable dataDB = PostgreSQL.Execute(cmd);
            int indexRow = 0;
            DataGrid.Rows.Clear();
            foreach (DataRow row in dataDB.Rows)
            {
                DataGrid.Rows.Add(1);
                DataGrid.Rows[indexRow].Cells[0].Value = row[campoCodigo];
                DataGrid.Rows[indexRow].Cells[1].Value = row[campoDescripcion];

                if (Convert.ToBoolean(row[campoEstado]))
                    DataGrid.Rows[indexRow].Cells[2].Value = "ACTIVADO";
                else
                    DataGrid.Rows[indexRow].Cells[2].Value = "DESCTIVADO";
                indexRow++;
            }
            
            dataDB.Dispose();
            cmd = null;
            parametros = null;
        }

        
        private void efosCampo1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void efosButtonConsultar1_Click(object sender, EventArgs e)
        {
            AccionBuscar();
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            this.Text = txtTitulo.Text;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioCodigo_Click(object sender, EventArgs e)
        {
            if (radioCodigo.Checked)
            {
                radioDescripcion.Checked = false;
            }
        }

        private void radioDescripcion_Click(object sender, EventArgs e)
        {
            if (radioDescripcion.Checked)
            {
                radioCodigo.Checked = false;
            }
        }

        private void efosButtonBuscador1_Click(object sender, EventArgs e)
        {
            AccionBuscar();
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            txtDescripcion.Text = txtDescripcion.Text.ToUpper().Trim();
        }

        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewCell cell in DataGrid.SelectedCells)
            {                
                valorCodigo = DataGrid.Rows[cell.RowIndex].Cells[0].Value.ToString();
                Close();
                return;
            }
            MessageBox.Show("No se ha Seleccionado un Codigo aun");
        }

        private void DataGrid_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Test: " + DataGrid.Rows[e.RowIndex].Cells[0].Value);
            valorCodigo = DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            valorCodigo = DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            Close();
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyValue == (char)Keys.Enter)            
                AccionBuscar();            
        }
    }
}
