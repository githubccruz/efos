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
    public partial class FormBaseMantenimiento : FormBase
    {
        public FormBaseMantenimiento()
        {
            InitializeComponent();
            controlTextBotonEstado();
            this.Text = textTitulo.Text;

            AccionBotonCancelar();

            txtCodigo.Text = "0";
            HabilitarControl(txtCodigo, true);
        }

        #region Propiedades del Formulario
            public string TablaBD { set; get; }
        #endregion

        private void Habilitar(bool habilitar)
        {
            habilitarCampos(this.Controls, habilitar);
        }
        public void Salir()
        {
            Close();
        }
        private void efosButtonSalir1_Click(object sender, EventArgs e)
        {
            this.Salir();
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

        private void efosCheck_CheckedChanged(object sender, EventArgs e)
        {
            controlTextBotonEstado();
        }

        private void efosButtonBuscador_Click(object sender, EventArgs e)
        {

        }

        private void efosButtonEstado_Click(object sender, EventArgs e)
        {
            checkEstado.Checked = !checkEstado.Checked;
        }

        private void textTitulo_TextChanged(object sender, EventArgs e)
        {
            this.Text = textTitulo.Text;
        }

        public void iniciarValores()
        {
            botonBuscar.Enabled = true;
            botonNuevo.Enabled = true;
            botonSalir.Enabled = true;
            botonBuscarLupa.Enabled = true;

            botonGuardar.Enabled = false;
            botonCancelar.Enabled = false;
            botonEditar.Enabled = false;

        }

        private void efosButtonNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = 0.ToString();
            limpiarControles(this.Controls);            
            AccionBotonNuevo();
        }

        #region Funciones para Comportamiento
            public void HabilitarControl(Control obj, bool habilitar)
            {
                obj.Enabled = habilitar;                
            }
            
            public void AccionBotonNuevo()
            {
                HabilitarControl(botonNuevo, false);
                HabilitarControl(botonSalir, false);
                HabilitarControl(botonBuscar, false);
                HabilitarControl(botonBuscarLupa, false);

                HabilitarControl(botonGuardar, true);
                HabilitarControl(botonEditar, false);
                HabilitarControl(botonCancelar, true);
                checkEstado.Enabled = true;
                checkEstado.Checked = true;

                habilitarCampos(this.Controls, true);
                txtCodigo.Text = "0";
                txtCodigo.Enabled = false;
            }
            //public bool isEmpty(Control control)
            //{
            //    bool result = false;
            //    if(String.IsNullOrEmpty(control.Text) || String.IsNullOrWhiteSpace(control.Text))
            //    {
            //        result = true;
            //    }
                
            //    return result;
            //}
            public void AccionCodigoValidado()
            {
                HabilitarControl(botonEditar, true);
                HabilitarControl(botonNuevo, false);
                HabilitarControl(botonCancelar, true);
                HabilitarControl(botonSalir, false);
                HabilitarControl(botonGuardar, false);
                HabilitarControl(botonSalir, false);
                HabilitarControl(botonBuscar, false);
                

                botonEditar.Focus();
            }
            public void AccionBotonGuardar()
            {
                foreach (Control control in this.Controls)
                {
                    if (control is ControlesEfos.efosCampo)
                    {
                        if (IsEmpty(control.Text))
                            return;
                    }
                    else if(control is ControlesEfos.efosCombo)
                    {
                        if (IsEmpty(control.Text))
                            return;
                    }
                }
                HabilitarControl(botonNuevo, true);
                HabilitarControl(botonSalir, true);
                HabilitarControl(botonBuscar, true);
                HabilitarControl(botonBuscarLupa, true);
                checkEstado.Enabled = false;

                HabilitarControl(botonGuardar, false);
                HabilitarControl(botonEditar, false);
                HabilitarControl(botonCancelar, false);
                HabilitarControl(txtCodigo, true);

                habilitarCampos(this.Controls, false);
                HabilitarControl(txtCodigo, true);
                txtCodigo.Focus();
            }

            public void AccionBotonCancelar()
            {
                HabilitarControl(botonNuevo, true);
                HabilitarControl(botonSalir, true);
                HabilitarControl(botonBuscar, true);
                HabilitarControl(botonBuscarLupa, true);
                checkEstado.Enabled = false;

                HabilitarControl(botonGuardar, false);
                HabilitarControl(botonEditar, false);
                HabilitarControl(botonCancelar, false);
                HabilitarControl(txtCodigo, true);
                
                habilitarCampos(this.Controls, false);
                HabilitarControl(txtCodigo, true);
            }
            public void AccionBotonEditar()
            {
                HabilitarControl(txtCodigo, false);
                HabilitarControl(botonNuevo, false);
                HabilitarControl(botonSalir, false);
                HabilitarControl(botonBuscar, false);
                HabilitarControl(botonBuscarLupa, false);

                HabilitarControl(botonGuardar, true);
                HabilitarControl(botonEditar, false);
                HabilitarControl(botonCancelar, true);
                checkEstado.Enabled = true;

                habilitarCampos(this.Controls, true);
                HabilitarControl(txtCodigo, false);
            }
        #endregion

        private void botonEditar_Click(object sender, EventArgs e)
        {
            AccionBotonEditar();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            AccionBotonGuardar();                       
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            AccionBotonCancelar();            
        }

        private void checkEstado_CheckedChanged(object sender, EventArgs e)
        {
            controlTextBotonEstado();
        }
    }
}
