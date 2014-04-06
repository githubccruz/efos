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
    public partial class FormMantenimientoInsumo : FormBaseMantenimiento
    {
        private void inicializarFormulario()
        {
            InitializeComponent();
            habilitarCampos(this.Controls, false);
            txtCodigo.Enabled = true;
            txtCodigo.Text = 0.ToString();
        }
        public FormMantenimientoInsumo()
        {
            inicializarFormulario();
        }
        public FormMantenimientoInsumo(string titulo)
        {
            inicializarFormulario();
            this.Text = titulo;
            textTitulo.Text = titulo;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string[] datos = { txtCodigo.Text, txtDescripcion.Text, txtCosto.Text, checkEstado.Checked.ToString(),txtExistencia.Text};
                string cmd = String.Format("SELECT inserta_insumo_encabezado({0},'{1}',{2},{3},{4});", datos);
                DataTable data = PostgreSql.Execute(cmd);
                txtCodigo.Text = data.Rows[0][0].ToString();
                data.Dispose();
            }
            catch (Exception error)
            {
                MessageBox.Show("Estos es embarazoso, no pudimos guardar la informacion Referencia ==>"+error.Message);
            }
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (txtCodigo.Text == 0.ToString() || String.IsNullOrEmpty(txtCodigo.Text))
                return;

            try
            {
                string codigo = txtCodigo.Text.ToString().Trim();
                string cmd = String.Format("SELECT * FROM insumo_encabezado WHERE codiinsu={0}", codigo);
                DataTable data = PostgreSql.Execute(cmd);
                txtDescripcion.Text = data.Rows[0][txtDescripcion.CampoBD].ToString();
                txtCosto.Text = data.Rows[0][txtCosto.CampoBD].ToString();
                checkEstado.Checked = Convert.ToBoolean(data.Rows[0][checkEstado.CampoBD].ToString());
                txtExistencia.Text = data.Rows[0][txtExistencia.CampoBD].ToString();
                AccionCodigoValidado();

                data.Dispose();
                codigo = null;
                cmd = null;
            }
            catch (Exception)
            {
                MessageBox.Show("No existe informacion con el codigo <<"+txtCodigo.Text+">>");
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = 0.ToString();
        }
    }
}
