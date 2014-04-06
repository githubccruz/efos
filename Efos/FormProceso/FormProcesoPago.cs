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

            
        }
    }
}
