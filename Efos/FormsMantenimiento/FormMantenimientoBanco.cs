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
    public partial class FormMantenimientoBanco : FormBaseMantenimientoGeneral
    {
        private void inicializar()
        {
            InitializeComponent();
            habilitarCampos(this.Controls, false);
            txtCodigo.Enabled = true;
        }
        public FormMantenimientoBanco()
        {
            inicializar();            
        }
        public FormMantenimientoBanco(string titulo)
        {
            inicializar();
            textTitulo.Text = titulo.Trim();
        }
        public FormMantenimientoBanco(string titulo,string tablaBD,string campoCodigo,string campoDescripcion, string campoEstado)
        {
            inicializar();
            textTitulo.Text = titulo.Trim();

            txtCodigo.CampoBD = campoCodigo;
            txtDescripcion.CampoBD = campoDescripcion;
            checkEstado.CampoBD = campoEstado;

            this.TablaBD = tablaBD;           
        }

        private void botonBuscarLupa_Click(object sender, EventArgs e)
        {
            //FormBaseConsulta Form = new FormBaseConsulta("Consulta Banco", "banco_encabezado", "codibanc", "descbanc", "estado");
            //Form.ShowDialog();
            //txtCodigo.Text = Form.valorCodigo;
            //txtCodigo.Focus();
            //botonEditar.Focus();
            ////Form.Dispose();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {

        }
    }
}
