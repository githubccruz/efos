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
    public partial class FormMantenimientoTipoDescuentoEmpleado : FormBaseMantenimientoGeneral
    {
        public FormMantenimientoTipoDescuentoEmpleado()
        {
            InitializeComponent();
        }
        private void inicializar()
        {
            InitializeComponent();
        }
        public FormMantenimientoTipoDescuentoEmpleado(string titulo,string tablaBD,string campoCodigo,string campoDescripcion, string campoEstado)
        {
            inicializar();
            textTitulo.Text = titulo.Trim();

            txtCodigo.CampoBD = campoCodigo;
            txtDescripcion.CampoBD = campoDescripcion;
            checkEstado.CampoBD = campoEstado;

            this.TablaBD = tablaBD;           
        }
    }
}
