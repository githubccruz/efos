﻿using System;
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
    public partial class FormMantenimientoCiudad : FormBaseMantenimientoRegion
    {

        public FormMantenimientoCiudad()
        {
            InicializarFormulario();
        }
        private void InicializarFormulario()
        {
            InitializeComponent();
        }
        public FormMantenimientoCiudad(string titulo)
        {
            InicializarFormulario();

            textTitulo.Text = titulo.Trim();
            this.Text = textTitulo.Text;

            HabilitarControl(txtCodigo, true);
            HabilitarControl(txtDescripcion, false);
            HabilitarControl(checkEstado, false);
            HabilitarControl(combo, false);
        }
    }
}
