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
    public partial class FormBaseMantenimientoGeneral : FormBaseMantenimiento
    {
        public FormBaseMantenimientoGeneral()
        {
            InitializeComponent();
            txtCodigo.Enabled = true;
        }

        private void controlTextBotonEstado()
        {
            if (checkEstado.Checked)
            {
                checkEstado.Text = "Desactivar";
                checkEstado.ForeColor = Color.Red;
            }
            else
            {
                checkEstado.Text = "Activar";
                checkEstado.ForeColor = Color.Blue;
            }
        }

        private void GuardarInformacion() 
        {
            string[] datos = new string[4];

            datos[0] =  this.TablaBD;
            datos[1] = txtCodigo.Text;
            datos[2] = txtDescripcion.Text;
            datos[3] = checkEstado.Checked.ToString();

            string cmd = String.Format("SELECT inserta_{0}({1},'{2}',{3});",datos);
            string result = PostgreSQL.Execute(cmd).Rows[0][0].ToString();

            txtCodigo.Text = result;
            txtCodigo.Enabled = true;
            
            cmd = null;
            datos = null;
            result = null;

            botonBuscarLupa.Focus();
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text) && txtCodigo.Text.Trim() != "0" && !String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                string[] datos = new string[6];

                datos[0] = txtCodigo.CampoBD;
                datos[1] = txtDescripcion.CampoBD;
                datos[2] = checkEstado.CampoBD;
                datos[3] = this.TablaBD;
                datos[4] = txtCodigo.CampoBD;
                datos[5] = txtCodigo.Text;

                string command = String.Format("SELECT {0},{1},{2} FROM {3} WHERE {4} = {5}", datos);

                try
                {
                    DataTable informacion = PostgreSQL.Execute(command);
                    txtCodigo.Text = informacion.Rows[0][datos[0]].ToString();
                    txtDescripcion.Text = informacion.Rows[0][datos[1]].ToString();
                    checkEstado.Checked = Convert.ToBoolean(informacion.Rows[0][datos[2]].ToString());
                }
                catch
                {
                    MessageBox.Show(" No existe Informacion con el Codigo <<<" + datos[5] + " >>>");
                    txtCodigo.Text = 0.ToString();
                    iniciarValores();
                    return;
                }

                AccionCodigoValidado();                
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {

        }
        
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text) || (String.IsNullOrEmpty(txtDescripcion.Text)))
            {
                MessageBox.Show("No se ha digitado descripcion");
                return;
            }
                           
            GuardarInformacion();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = false;
        }

        private void FormBaseMantenimientoGeneral_Load(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = false;
        }

        private void botonNuevo_Click_1(object sender, EventArgs e)
        {
            txtCodigo.Text = 0.ToString();
        }

        private void botonBuscarLupa_Click(object sender, EventArgs e)
        {
            FormBaseConsulta Form = new FormBaseConsulta(this.textTitulo.Text, this.TablaBD, this.txtCodigo.CampoBD, this.txtDescripcion.CampoBD, this.checkEstado.CampoBD);
            Form.ShowDialog();
            txtCodigo.Text = Form.valorCodigo;
            txtCodigo.Focus();
            txtCodigo_Validated(null, null);
            Form = null;
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            txtDescripcion.Text = txtDescripcion.Text.ToUpper();
        }
    }
}
