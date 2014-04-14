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
                var command = String.Format("SELECT numero_orden, fecha, sum(cantidad_servicio*precio_servicio) as Total, codigo_paciente from vista_orden_trabajo "+
                                            "GROUP BY numero_orden,fecha,codigo_paciente "+
                                            "HAVING codigo_paciente={0} ORDER BY fecha ASC;", txtCodigoPaciente.Text);

                var data = PostgreSql.Execute(command);
                letreroNombrePaciente.Text = PostgreSql.Execute("SELECT nombre FROM vista_persona_consulta WHERE codigo="+txtCodigoPaciente.Text+";").Rows[0][0].ToString();
                var newRow = 0;

                dataGridOrdenTrabajo.Rows.Clear();
                foreach (DataRow row in data.Rows)
                {
                    dataGridOrdenTrabajo.Rows.Add(1);
                    dataGridOrdenTrabajo.Rows[newRow].Cells[columnaNumeroOrdenTrabajo.Index].Value = row["numero_orden"];

                    dataGridOrdenTrabajo.Rows[newRow].Cells[columnaFechaOrdenTrabajo.Index].Value = Convert.ToDateTime(row["fecha"]).ToString().Substring(0, 10);
                    dataGridOrdenTrabajo.Rows[newRow].Cells[columnaTotalOrdenTrabajo.Index].Value = row["total"].ToString();
                    
                    //dataGridOrdenTrabajo.Rows[newRow].Cells[columnaBalancePedienteOrdenTrabajo.Index].Value = row["Pendiente"].ToString();
                    //dataGridOrdenTrabajo.Rows[newRow].Cells[columnaBalanceRestanteOrdenTrabajo.Index].Value = row["Pendiente"].ToString();

                    newRow++;
                    
                }

                foreach (DataGridViewRow row in dataGridOrdenTrabajo.Rows)
                {
                    /// Cuanto se ha pagado de la Orden de Trabajo ///
                    command = "SELECT numeortr, sum(montcobr) AS total FROM cobro_detalle as detalle inner join " +
                              " cobro_encabezado AS encabezado ON detalle.numecobr=encabezado.numecobr " +
                              "GROUP BY numeortr HAVING numeortr=" + row.Cells[columnaNumeroOrdenTrabajo.Index].Value;

                    data = PostgreSql.Execute(command);
                    if (data.Rows.Count>0)
                    {
                        row.Cells[columnaBalancePedienteOrdenTrabajo.Index].Value
                                = (Convert.ToDouble(row.Cells[columnaTotalOrdenTrabajo.Index].Value.ToString()) - Convert.ToDouble(data.Rows[0]["total"].ToString())).ToString();                                           
                    }
                    else
                    {
                        row.Cells[columnaBalancePedienteOrdenTrabajo.Index].Value = row.Cells[columnaTotalOrdenTrabajo.Index].Value;
                    }
                    if(IsEmpty(row.Cells[columnaBalancePedienteOrdenTrabajo.Index].Value.ToString())){
                        dataGridOrdenTrabajo.Rows.RemoveAt(row.Index);
                    }
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
                        row.Cells[columnaBalanceRestanteOrdenTrabajo.Index].Value = 0;
                        row.Cells[columnaMontoAPagar.Index].Value = Total;
                        Total = 0;
                    }
                    else if ((Total - celda) > 0)
                    {
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
            }
        }

        private void dataGridOrdenTrabajo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var totalRestante = 0.00;
            var totalOrdenes = 0.00;
            foreach (DataGridViewRow row in dataGridOrdenTrabajo.Rows)
            {
                totalRestante += Convert.ToDouble(row.Cells[columnaBalanceRestanteOrdenTrabajo.Index].Value);                
                totalOrdenes += Convert.ToDouble(row.Cells[columnaTotalOrdenTrabajo.Index].Value);
            }
            campoTotal.Text = totalOrdenes.ToString();
            campoBalancePendiente.Text = totalRestante.ToString();
        }

        private void botonProcesar_Click(object sender, EventArgs e)
        {
            object[] data = {txtNumeroAsunto.Text,comboTipoComprobanteFiscal.SelectedValue};
            var commando = String.Format("SELECT inserta_cobro_encabezado({0},{1});",data);            
            var dataCobro = PostgreSql.Execute(commando);

            foreach (DataGridViewRow row in dataGridOrdenTrabajo.Rows)
            {
                if ((row.Cells[columnaMontoAPagar.Index].Value!=null && !IsEmpty((row.Cells[columnaMontoAPagar.Index].Value).ToString())))
                {
                    MessageBox.Show("Test: "+row.Cells[columnaMontoAPagar.Index].Value);
                    commando = String.Format("SELECT inserta_cobro_detalle({0},{1},{2});",
                        dataCobro.Rows[0][0].ToString(),
                        row.Cells[columnaNumeroOrdenTrabajo.Index].Value,
                        row.Cells[columnaMontoAPagar.Index].Value);

                    PostgreSql.Execute(commando);
                }
            }
            letreroNCF.Text = PostgreSql.Execute("SELECT numecncf FROM cobro_encabezado WHERE numecobr=" + dataCobro.Rows[0][0].ToString()).Rows[0][0].ToString();
            txtNumeroAsunto.Text = dataCobro.Rows[0][0].ToString();

            txtNumeroAsunto.Enabled = true;
            lupaAsunto.Enabled = true;
            comboTipoComprobanteFiscal.Enabled = true;

        }

        private void campoMontoAPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))            
                botonAplicar_Click(null, null);                
            
        }
    }
}
