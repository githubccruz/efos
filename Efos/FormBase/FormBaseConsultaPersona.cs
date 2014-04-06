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
    public partial class FormBaseConsultaPersona : FormBase
    {
        public FormBaseConsultaPersona()
        {
            InitializeComponent();
        }
        #region Propiedades
            public string valorCodigo{ get; set; }
        #endregion
        private void efosButtonCancelar1_Click(object sender, EventArgs e)
        {
            valorCodigo = 0.ToString();
            Close();
        }

        private void efosButtonSeleccionar1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in DataGrid.SelectedCells)
            {
                valorCodigo = DataGrid.Rows[cell.RowIndex].Cells[0].Value.ToString();
                Close();
                return;
            }
            MessageBox.Show("No se ha Seleccionado un Codigo aun");
        }

        private void AccionBuscar()
        {
            string filtro = "nombre";            
            string cmd;
            var valorBusqueda = campoBusqueda.Text.ToString().ToUpper();            

            if (radioFechaNacimiento.Checked)
            {
                filtro = "fechanacimiento";
                campoBusqueda.Text = campoBusqueda.Text.Replace("/", "-");
                campoBusqueda.Text = campoBusqueda.Text.Replace("_", "-");
                campoBusqueda.Text = campoBusqueda.Text.Replace("_", "-");

                cmd = String.Format("SELECT * FROM vista_persona_consulta WHERE {0} = {1}", filtro, campoBusqueda.Text.Trim().ToUpper());
            }
            else
            {
                cmd = String.Format("SELECT * FROM vista_persona_consulta WHERE {0} like '%{1}%'", filtro, campoBusqueda.Text.Trim().ToUpper());
            }
            
            
            DataTable data = PostgreSql.Execute(cmd);
            DataGrid.Rows.Clear();
            int indexRow= 0;
            foreach (DataRow row in data.Rows)
            {
                DataGrid.Rows.Add(1);
                
                DataGrid.Rows[indexRow].Cells[0].Value = row["codigo"].ToString();
                DataGrid.Rows[indexRow].Cells[1].Value = row["nombre"].ToString();
                DataGrid.Rows[indexRow].Cells[2].Value = row["nacionalidad"].ToString();
                DataGrid.Rows[indexRow].Cells[3].Value = row["sexo"].ToString();
                DataGrid.Rows[indexRow].Cells[4].Value = row["fechanacimiento"].ToString().Substring(0,10);
                DataGrid.Rows[indexRow].Cells[5].Value = row["estado"].ToString();

            }
            
        }
        private void efosButtonBuscador1_Click(object sender, EventArgs e)
        {
            AccionBuscar();
        }

        private void efosCampo1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)                
                AccionBuscar();     
        }

        private void radioNombre_Click(object sender, EventArgs e)
        {
            radioFechaNacimiento.Checked = false;
            textoFormato.Visible = false;
        }

        private void radioFechaNacimiento_Click(object sender, EventArgs e)
        {
            radioNombre.Checked = false;
            textoFormato.Visible = true;
        }

        private void efosGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void campoBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void campoBusqueda_Validated(object sender, EventArgs e)
        {
            campoBusqueda.Text = campoBusqueda.Text.ToUpper();
        }
    }
}
