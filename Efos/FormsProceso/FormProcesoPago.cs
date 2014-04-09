using System;
using System.Data;
using System.Windows.Forms;

namespace Efos.FormProceso
{
    public partial class FormProcesoPago : FormBaseProceso
    {
        public FormProcesoPago()
        {
            InitializeComponent();
            PostgreSql.FillComboBox(comboTipoComprobanteFiscal,
                "coditico",
                "desctico",
                "tipo_comprobante_fiscal_encabezado",
                "estado=true and coditico=1 or coditico=2");

            comboTipoComprobanteFiscal.SelectedValue = 2;            
        }

        private void txtCodigoPaciente_Validated(object sender, System.EventArgs e)
        {
            if (IsEmpty(txtCodigoPaciente.Text))            
                return;
            
            var command = String.Format("SELECT * FROM vista_ordenes_trabajo WHERE codigo_paciente={0}",txtCodigoPaciente.Text);
            var data = PostgreSql.Execute(command);

        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            comboTipoComprobanteFiscal.Enabled = false;
            //DataTable 
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            comboTipoComprobanteFiscal.Enabled = true;
            
        }
    }
}
