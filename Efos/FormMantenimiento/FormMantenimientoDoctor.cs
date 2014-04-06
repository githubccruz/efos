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
    public partial class FormMantenimientoDoctor : FormBaseMantenimientoPersona
    {
        public FormMantenimientoDoctor()
        {
            InitializeComponent();
            cmpExequeatur.Enabled = false;
            cmbTipoDoctor.Enabled = false;
        }

        private void cargarInformacion(bool estado)
        {
            if (estado)
                PostgreSql.FillComboBox(cmbTipoDoctor, "coditido", "desctido", "tipo_doctor_encabezado", filter: "estado="+estado);
            else
                PostgreSql.FillComboBox(cmbTipoDoctor, "coditido", "desctido", "tipo_doctor_encabezado");
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            cargarInformacion(true);
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (txtCodigo.Text == 0.ToString() || String.IsNullOrEmpty(txtCodigo.Text))
            {
                return;
            }
            try
            {                
                cargarInformacion(false);
                string cmd = String.Format("SELECT * FROM doctor_encabezado WHERE coditerc={0}",txtCodigo.Text);
                DataTable result = PostgreSql.Execute(cmd);
                cmpExequeatur.Text = result.Rows[0]["exeqdoct"].ToString();
                cmbTipoDoctor.SelectedValue = Convert.ToInt32(result.Rows[0]["coditido"].ToString());
                checkEstado.Checked = Convert.ToBoolean(result.Rows[0]["estado"].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Esta persona no ha sido registrada como Doctor");

                checkEstado.Checked = false;
                cmbTipoDoctor.SelectedIndex = -1;
                cmpExequeatur.Text = "";
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDoctor.SelectedIndex == -1)
            {
                MessageBox.Show("No hay Tipo de Doctor seleccionado");
                cmbTipoDoctor.Focus();
                return;
            }
            
            if (String.IsNullOrEmpty(cmpExequeatur.Text.Trim()))
            {
                MessageBox.Show("No se ha digitado el Exequatur del Doctor");
                cmpExequeatur.Focus();
                return;
            }

            string[] datos = new string[4];
            datos[0] = codigoGenerado;
            datos[1] = cmpExequeatur.Text.Trim();
            datos[2] = cmbTipoDoctor.SelectedValue.ToString().Trim();
            datos[3] = checkEstado.Checked.ToString();
            
            string cmd = String.Format("SELECT inserta_doctor_encabezado({0},'{1}', {2}, {3});", datos);
            
            PostgreSql.Execute(cmd);

            txtCodigo.Text = codigoGenerado;
        }
    }
}
