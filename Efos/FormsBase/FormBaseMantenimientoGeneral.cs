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
            try
            {
                object[] datos =
                {
                    TablaBD,
                    txtCodigo.Text,
                    txtDescripcion.Text,
                    checkEstado.Checked.ToString()
                };
                
                var cmd = String.Format("SELECT inserta_{0}({1},'{2}',{3});", datos);
                var result = PostgreSql.Execute(cmd).Rows[0][0].ToString();

                txtCodigo.Text = result;
                txtCodigo.Enabled = true;

                cmd = null;
                datos = null;
                result = null;

                botonBuscarLupa.Focus();
            }
            catch (Exception)
            {
                                    
            }
            
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text) && txtCodigo.Text.Trim() != "0" && !String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                object[] datos =
                {
                    txtCodigo.CampoBD,
                    txtDescripcion.CampoBD,
                    checkEstado.CampoBD,
                    TablaBD,
                    txtCodigo.CampoBD,
                    txtCodigo.Text
                };

                var command = String.Format("SELECT {0},{1},{2} FROM {3} WHERE {4} = {5}", datos);

                try
                {
                    DataTable informacion = PostgreSql.Execute(command);
                    txtCodigo.Text = informacion.Rows[0][datos[0].ToString()].ToString();
                    txtDescripcion.Text = informacion.Rows[0][datos[1].ToString()].ToString();
                    checkEstado.Checked = Convert.ToBoolean(informacion.Rows[0][datos[2].ToString()].ToString());
                }
                catch
                {
                    MessageBox.Show(@" No existe Informacion con el Codigo <<<" + datos[5] + @" >>>");
                    txtCodigo.Text = 0.ToString();
                    iniciarValores();
                    return;
                }
                AccionCodigoValidado();                
            }
        }
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text) || (String.IsNullOrEmpty(txtDescripcion.Text)))
            {
                MessageBox.Show(@"No se ha digitado descripcion");
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
            var form = new FormBaseConsulta(textTitulo.Text, TablaBD, txtCodigo.CampoBD, txtDescripcion.CampoBD, checkEstado.CampoBD);
            form.ShowDialog();
            txtCodigo.Text = form.valorCodigo;
            txtCodigo.Focus();
            txtCodigo_Validated(null, null);            
        }

        private void txtDescripcion_Validated(object sender, EventArgs e)
        {
            txtDescripcion.Text = txtDescripcion.Text.ToUpper();
        }
    }
}