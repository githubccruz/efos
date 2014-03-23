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
    public partial class FormProcesoOrdenTrabajo : FormBaseProceso
    {
        public FormProcesoOrdenTrabajo()
        {
            InitializeComponent();
            checkEstado.Checked = false;
            
        }

        private void dataGridServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(dataGridServicios, e.ColumnIndex, e.RowIndex);
        }

    }
}
