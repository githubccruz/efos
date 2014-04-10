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
            try
            {
                var command = String.Format("SELECT numero_orden,fecha,codigo_paciente, sum(cantidad_servicio*precio_servicio) as Total FROM vista_orden_trabajo "
                                            +"GROUP BY numero_orden,fecha,codigo_paciente HAVING codigo_paciente={0} ORDER BY fecha DESC;", txtCodigoPaciente.Text);
                
                var data = PostgreSql.Execute(command);
                letreroNombrePaciente.Text = PostgreSql.Execute("SELECT nombre FROM vista_persona_consulta WHERE codigo="+txtCodigoPaciente.Text+";").Rows[0][0].ToString();
                var newRow = 0;
                dataGridOrdenTrabajo.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    dataGridOrdenTrabajo.Rows.Add(1);
                    dataGridOrdenTrabajo.Rows[newRow].Cells[columnaNumeroOrdenTrabajo.Index].Value = row["numero_orden"];
                    dataGridOrdenTrabajo.Rows[newRow].Cells[columnaFechaOrdenTrabajo.Index].Value =  Convert.ToDateTime(row["fecha"]).ToString().Substring(0,10);
                    dataGridOrdenTrabajo.Rows[newRow].Cells[columnaTotalOrdenTrabajo.Index].Value = row["Total"].ToString();
                    dataGridOrdenTrabajo.Rows[newRow].Cells[columnaBalancePedienteOrdenTrabajo.Index].Value = row["Total"].ToString();
                    newRow++;
                }
                botonAplicar.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show(String.Format("El Paciente codigo {0} no tiene Ordenes de Trabajo pendiente",txtCodigoPaciente.Text));
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            comboTipoComprobanteFiscal.Enabled = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            comboTipoComprobanteFiscal.Enabled = true;
            botonAplicar.Enabled = false;
        }

        private void botonAplicar_Click(object sender, EventArgs e)
        {
            lupaPaciente.Enabled = false;
            txtCodigoPaciente.Enabled = false;
            var Total = 0.00;
            try
            {
                Total = Convert.ToDouble(campoMontoAPagar.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("Debe digitar un valor valido");
                campoMontoAPagar.Focus();
                return;
            }
            DistribuirPagos(Total);
        }
        private void DistribuirPagos(Double Total)
        {
            foreach (DataGridViewRow row in dataGridOrdenTrabajo.Rows)
            {
                var celda = (Convert.ToDouble(row.Cells[columnaBalancePedienteOrdenTrabajo.Index].Value));
                if (Total > 0)
                {
                    if ((celda - Total) == 0)
                    {
                        //row.Cells[columnaBalancePedienteOrdenTrabajo.Index].Value = 0;
                        row.Cells[columnaBalanceRestanteOrdenTrabajo.Index].Value = 0;
                        row.Cells[columnaMontoAPagar.Index].Value = Total;
                        Total = 0;
                    }
                    else if ((Total - celda) > 0)
                    {
                        //row.Cells[columnaBalancePedienteOrdenTrabajo.Index].Value = 0;
                        row.Cells[columnaBalanceRestanteOrdenTrabajo.Index].Value = 0;
                        row.Cells[columnaMontoAPagar.Index].Value = celda;
                        Total -= celda;
                    }
                    else
                    {
                        row.Cells[columnaBalanceRestanteOrdenTrabajo.Index].Value = Convert.ToDouble(row.Cells[columnaBalancePedienteOrdenTrabajo.Index].Value) - Total;
                        row.Cells[columnaMontoAPagar.Index].Value = Total;
                        
                        Total = 0;
                    }
                }
            }
            
            campoDevuelta.Text = Total.ToString();
        }

        private void dataGridOrdenTrabajo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == (dataGridOrdenTrabajo.Columns.Count - 1))
            {
                var numeroOrden = dataGridOrdenTrabajo.Rows[e.RowIndex].Cells[0].Value.ToString();
                var commando = String.Format("SELECT * FROM vista_reporte_orden_trabajo WHERE numero_orden={0}", numeroOrden);
                var Data = PostgreSql.Execute(commando);
                Efos.Reportes.SimpleReport report = new Reportes.SimpleReport();
                report.ShowReport(Data, "ReportOrdenTrabajo");
                report.Show();
                //MessageBox.Show("Numero de Orden: "+numeroOrden);
                //var form = new FormProcesoOrdenTrabajo(numeroOrden);
                //form.ShowDialog();
            }
        }

        private void dataGridOrdenTrabajo_Sorted(object sender, EventArgs e)
        {
            
        }
    }
}
