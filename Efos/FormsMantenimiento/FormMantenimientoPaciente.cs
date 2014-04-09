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
    public partial class FormMantenimientoPaciente : FormBaseMantenimientoPersona
    {
        public FormMantenimientoPaciente()
        {
            inicializarFormulario();
        }
        private void inicializarFormulario()
        {
            InitializeComponent();
            cmbTipoPaciente.Enabled = false;
        }
        private void cancelar()
        {
            cmbTipoPaciente.Enabled = false;
        }
        private void cargarInformacion()
        {
            PostgreSql.FillComboBox(cmbTipoPaciente,"coditipa","desctipa","tipo_paciente_encabezado",filter:"estado=true");
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            cargarInformacion();
            cmbTipoPaciente.Enabled = true;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            cmbTipoPaciente.Enabled = false;
            if (cmbTipoPaciente.SelectedIndex != -1)
            {
                string cmd = String.Format("SELECT inserta_paciente_encabezado({0},{1})", codigoGenerado, cmbTipoPaciente.SelectedValue);
                PostgreSql.Execute(cmd);
                txtCodigo.Text = codigoGenerado;
            }
            else
            {
                MessageBox.Show("Esta persona no queda registrada como Paciente");
            }
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            cmbTipoPaciente.Enabled = true;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            cargarInformacion();
            try
            {
                int codigoI = Convert.ToInt32(txtCodigo.Text);

                if (txtCodigo.Text == 0.ToString() || String.IsNullOrEmpty(txtCodigo.Text))
                    return;
            }
            catch (Exception)
            {
                return;
            }            
            DataTable data = PostgreSql.Execute("SELECT * FROM vista_paciente_tipo WHERE codigo=" + txtCodigo.Text);
            try
            {
                cmbTipoPaciente.SelectedValue = Convert.ToInt32(data.Rows[0][1].ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Esta persona aun no se ha registrado como paciente");
                cmbTipoPaciente.SelectedIndex = -1;
            }
            
            cmbTipoPaciente.Enabled = false;
            
        }

        private void botonBuscarLupa_Click(object sender, EventArgs e)
        {
            
        }
    }
}
