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
    public partial class FormBaseProceso : FormBase
    {
        public FormBaseProceso()
        {
            InitializeComponent();
            inicializar(true, true);
            AccionBotonCancelar();
        }
        public void inicializar(bool botones,bool valores)
        {
            if (botones)
                inicializarBotones();
            if (valores)
                inicializarValores();
        }

        private void inicializarBotones()
        {            

            botonProcesar.Enabled = false;
            botonCancelar.Enabled = false;

            botonNuevo.Enabled = true;
            botonSalir.Enabled = true;
            botonBuscar.Enabled = true;
        }
        public void AccionBotonNuevo()
        {
            botonNuevo.Enabled = false;
            botonProcesar.Enabled = true;
            botonCancelar.Enabled = true;
            botonBuscar.Enabled = false;
            botonSalir.Enabled = false;

            limpiarControles(this.Controls);
            txtNumeroAsunto.Text = 0.ToString();
            txtNumeroAsunto.Enabled = false;
            txtFechaAsunto.Text = DateTime.Now.ToString().Substring(0, 10);
            txtFechaAsunto.Enabled = false;
            lupaAsunto.Enabled = false;
            lupaPaciente.Enabled = true;

            letreroPersona.Text = "";
            txtCodigoPaciente.Text = 0.ToString();
            txtCodigoPaciente.Enabled = true;

        }
        public void AccionBotonProcesar()
        {
            botonNuevo.Enabled = true;
            botonProcesar.Enabled = false;
            botonCancelar.Enabled = false;
            botonBuscar.Enabled = true;
            botonSalir.Enabled = true;
        }
        public void AccionBotonCancelar()
        {
            limpiarControles(this.Controls);
            habilitarCampos(this.Controls, false);

            botonNuevo.Enabled = true;
            botonProcesar.Enabled = false;
            botonCancelar.Enabled = false;
            botonBuscar.Enabled = true;
            botonSalir.Enabled = true;

            lupaAsunto.Enabled = true;
            lupaPaciente.Enabled = false;

            txtFechaAsunto.Text = DateTime.Now.ToString().Substring(0, 10);

            txtNumeroAsunto.Text = 0.ToString();
            txtNumeroAsunto.Enabled = true;
            letreroPersona.Text = "";            
        }
        public void AccionBotonBuscar()
        {
        }
        private void inicializarValores()
        {
            txtNumeroAsunto.Text = 0.ToString();
            txtFechaAsunto.Text = System.DateTime.Now.ToString().Substring(0, 10);
        }

        private void efosButtonSalir1_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void botonProcesar_Click(object sender, EventArgs e)
        {
            AccionBotonProcesar();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            AccionBotonNuevo();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            AccionBotonCancelar();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            AccionBotonBuscar();
        }
    }
}
