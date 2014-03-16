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
    public partial class FormBaseMantenimientoRegion : FormBaseMantenimiento
    {
        public FormBaseMantenimientoRegion()
        {
            InitializeComponent();
        }
        
        public string tablaCombo { set; get; }
        public string campoCodigoCombo { set; get; }
        public string campoDescripcionCombo { set; get; }

        private void AccionGuardar()
        {
            HabilitarControl(botonBuscar, true);
            HabilitarControl(botonBuscarLupa, true);
            HabilitarControl(botonNuevo, true);
            HabilitarControl(botonSalir, true);

            HabilitarControl(botonCancelar, false);
            HabilitarControl(botonGuardar, false);
            HabilitarControl(botonEditar, false);

            habilitarCampos(this.Controls, false);
            HabilitarControl(txtCodigo, true);

            checkEstado.Enabled = false;

            string[] datos = new string[5];

            datos[0] = this.TablaBD;
            datos[1] = txtCodigo.Text.Trim();
            datos[2] = txtDescripcion.Text.Trim();
            datos[3] = combo.Text;
            datos[4] = checkEstado.Checked.ToString();

            string command = String.Format("select inserta_{0}({1},'{2}','{3}',{4});", datos);
            try
            {
                txtCodigo.Text = PostgreSQL.Execute(command).Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("Tenemos un problema houston :(. \n\nNo se pudo Guardar la Informacion", "Aviso");
            }

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            AccionGuardar();
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCodigo.Text) && txtCodigo.Text.Trim() != "0" && !String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                string[] datos = new string[7];

                datos[0] = this.txtCodigo.CampoBD;
                datos[1] = this.txtDescripcion.CampoBD;
                datos[2] = this.combo.CampoBD;
                datos[3] = this.checkEstado.CampoBD;
                datos[4] = this.TablaBD;
                datos[5] = this.txtCodigo.CampoBD;
                datos[6] = this.txtCodigo.Text;
                string command = String.Format("SELECT {0}, {1}, {2}, {3} FROM {4} WHERE {5} = {6}", datos);
                try
                {
                    DataTable informacion = PostgreSQL.Execute(command);                    
                    PostgreSQL.FillComboBox(combo, this.campoCodigoCombo, this.campoDescripcionCombo, this.tablaCombo);
                    txtCodigo.Text = informacion.Rows[0][datos[0]].ToString();
                    txtDescripcion.Text = informacion.Rows[0][datos[1]].ToString();
                    int display = Convert.ToInt32(informacion.Rows[0][datos[2]].ToString());
                    string cmd = String.Format("SELECT {0} FROM {1} WHERE {2}={3}", this.campoDescripcionCombo, this.tablaCombo, this.campoCodigoCombo, display.ToString());                    
                    string descripcion = PostgreSQL.Execute(cmd).Rows[0][0].ToString();
                    combo.SelectedIndex = combo.FindString(descripcion);
                    checkEstado.Checked = Convert.ToBoolean(informacion.Rows[0][datos[3]].ToString());

                }
                catch
                {
                    AccionBotonCancelar();
                    combo.DataSource = null;
                    txtDescripcion.Text = "";
                    MessageBox.Show(" No existe Informacion con el Codigo <<<" + datos[6] + ">>>");
                    return;
                }
                HabilitarControl(botonEditar, true);
                HabilitarControl(botonNuevo, false);
                HabilitarControl(botonCancelar, true);
                HabilitarControl(botonSalir, false);
                HabilitarControl(botonGuardar, false);
                HabilitarControl(botonSalir, false);
                HabilitarControl(botonBuscar, false);

                botonEditar.Focus();
            }
        }

        private void AccionNuevo()
        {            
            PostgreSQL.FillComboBox(combo,this.campoCodigoCombo,this.campoDescripcionCombo,this.tablaCombo,filter:"estado = true");
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            AccionNuevo();
        }
    }
}
