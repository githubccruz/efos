using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlesEfos;

namespace Efos
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }
        public void limpiarControles(Control.ControlCollection controles)
        {
            foreach (Control cltr in controles)
            {
                if (cltr is Panel)
                {
                    limpiarControles(cltr.Controls);
                }
                else if (cltr is GroupBox)
                {
                    limpiarControles(cltr.Controls);
                }
                else if (cltr is TabControl){
                    limpiarControles(cltr.Controls);
                }
                else if (cltr is efosCampo)
                {
                    efosCampo efosCltr = (efosCampo)(cltr);
                    if (efosCltr.Limpiar)
                    {
                        cltr.Text = "";    
                    }                    
                }
                else if (cltr is efosCombo || cltr is ComboBox)
                {
                    efosCombo cmb = (efosCombo)(cltr);
                    cmb.SelectedIndex = -1;
                }
                else if (cltr is DataGridView){
                    efosDataGridView data = (efosDataGridView)(cltr);
                    data.Rows.Clear();
                }
                else if (cltr is CheckBox)
                {
                    CheckBox obj = (CheckBox)(cltr);
                    obj.Checked = false;
                }
                else if (cltr is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)(cltr);
                    dtp.Text = "01/01/1980";

                }
            }
        }

        //public void habilitarCampos(Control.ControlCollection controles)
        //{
        //    foreach (Control cltr in controles)
        //    {
        //        if (cltr is Panel)
        //        {
        //            limpiarControles(cltr.Controls);
        //        }
        //        else if (cltr is GroupBox)
        //        {
        //            limpiarControles(cltr.Controls);
        //        }
        //        else if(cltr is efosCampo)
        //        {
        //            efosCampo obj = (efosCampo)(cltr);
        //            if (!obj.SoloLectura)
        //            {
        //                obj.Enabled = true;
        //            }
        //            else
        //            {
        //                obj.Enabled = false;
        //            }
        //        }
        //    }
        //}
        public void habilitarCampos(Control.ControlCollection controles,bool Habilitar)
        {
            foreach (Control cltr in controles)
            {
                if (cltr is Panel)
                {
                    habilitarCampos(cltr.Controls, Habilitar);
                }
                else if (cltr is GroupBox)
                {
                    habilitarCampos(cltr.Controls, Habilitar);
                }
                else if (cltr is TabControl)
                {
                    habilitarCampos(cltr.Controls, Habilitar);
                }
                else if (cltr is DataGridView)
                {
                    cltr.Enabled = Habilitar;
                }
                else if (cltr is TextBox)
                {
                    efosCampo obj = (efosCampo)(cltr);
                    if (Habilitar)
                    {
                        if (!obj.SoloLectura)
                        {
                            obj.Enabled = Habilitar;
                        }
                    }
                    else
                    {
                        obj.Enabled = Habilitar;
                    }
                }
                else if (cltr is ComboBox)
                {
                    efosCombo obj = (efosCombo)(cltr);
                    obj.Enabled = Habilitar;
                }
                else if (cltr is DateTimePicker)
                    cltr.Enabled = Habilitar;
                else if (cltr is efosDataGridView)
                    cltr.Enabled = Habilitar;
                else if (cltr is efosImage)
                    cltr.Enabled = Habilitar;
            }

        }
        public void eliminarFila(DataGridView dataGrid, int indiceColumna, int indiceFila)
        {
            if ((dataGrid.ColumnCount - 1) == indiceColumna)
            {
                try
                {
                    dataGrid.Rows.RemoveAt(indiceFila);
                }
                catch
                {

                }

            }
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

    }
}
