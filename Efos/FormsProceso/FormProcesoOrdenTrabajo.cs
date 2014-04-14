using System;
using System.Data;
using System.Globalization;
using System.Linq;
using Efos.Reportes;
using System.Windows.Forms;

namespace Efos.FormProceso
{
    public partial class FormProcesoOrdenTrabajo : FormBaseProceso
    {
        DataTable _data;
        string _numerOrden;

        public FormProcesoOrdenTrabajo()
        {
            InitializeComponent();
            
            dataGridServicios_CellValueChanged(null, null);
        }
        public FormProcesoOrdenTrabajo(string numeroOrden)
        {
            InitializeComponent();
            dataGridServicios_CellValueChanged(null, null);
            txtNumeroAsunto.Text = numeroOrden;
            _numerOrden = numeroOrden;
        }

        private void txtCodigoPaciente_Validated(object sender, EventArgs e)
        {
            if (txtCodigoPaciente.Text == 0.ToString(CultureInfo.InvariantCulture) || String.IsNullOrEmpty(txtCodigoPaciente.Text))
            {
                LimpiarDatosServicio();
                
                campoCodigo.Enabled = false;
                lupaServicio.Enabled = false;
                return;
            }
            try
            {
                var cmd = String.Format("SELECT * FROM vista_persona_consulta WHERE codigo in (SELECT coditerc FROM paciente_encabezado) AND codigo={0} AND estado=true", txtCodigoPaciente.Text);
                DataTable data = PostgreSql.Execute(cmd);
                letreroNombrePaciente.Text = data.Rows[0]["nombre"].ToString();
                data.Dispose();
                campoCodigo.Enabled = true;
                lupaServicio.Enabled = true;
                dataGridServicios.Enabled = true;
            }
            catch (Exception)
            {
                letreroNombrePaciente.Text = String.Empty;
                if (MessageBox.Show(@"No existe informacion o el Paciente esta Inactivo, con el codigo digitado ==>" + txtCodigoPaciente.Text + "\n, ¿Desea usar el Buscador?", "Consejo || Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lupaPaciente_Click(null, null);
                }
                campoCodigo.Enabled = false;
                lupaServicio.Enabled = false;
            }
        }

        private void dataGridServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(dataGridServicios, e.ColumnIndex, e.RowIndex);
        }

        private void LimpiarDatosServicio()
        {
            campoCodigo.Text = String.Empty;
            campoDescripcioServicio.Text = String.Empty;
            campoPrecio.Text = 0.ToString();
            campoCantidad.Text = 0.ToString();
            campoCantidad.Enabled = false;
            campoTotal.Text = 0.ToString();

            comboTipoPrecio.Enabled = false;
            comboTipoPrecio.SelectedIndex = -1;
            campoCodigoDoctor.Text = String.Empty;
            campoDescripcionDoctor.Text = String.Empty;
            campoCodigoDoctor.Enabled = false;
            campoDescripcionDoctor.Enabled = false;
            lupaPaciente.Enabled = false;
            campoCodigo.Focus();
        }

        private void efosButtonBuscador2_Click(object sender, EventArgs e)
        {
            if (campoCodigo.Text == 0.ToString() ||
                    String.IsNullOrEmpty(campoCodigo.Text) ||
                        campoCantidad.Text == 0.ToString() ||
                            String.IsNullOrEmpty(campoCantidad.Text))
            {                
                return;
            }


            foreach (DataGridViewRow row in dataGridServicios.Rows)
            {
                if (campoCodigo.Text.ToString().Trim() == row.Cells[0].Value.ToString().Trim() &&
                    comboTipoPrecio.Text.Equals(row.Cells[3].Value.ToString()))
                {
                    row.Cells[columnaCodigoServicio.Index].Value = campoCodigo.Text.ToString().Trim();                    
                    row.Cells[columnaTipoPrecio.Index].Value = comboTipoPrecio.Text;
                    row.Cells[columnaCantidad.Index].Value = (Convert.ToDouble(campoCantidad.Text.ToString().Trim()) + Convert.ToDouble(row.Cells[columnaCantidad.Index].Value.ToString()));
                    row.Cells[columnaSubTotal.Index].Value = (Convert.ToDouble(row.Cells[columnaCantidad.Index].Value) * Convert.ToDouble(row.Cells[columnaPrecioServicio.Index].Value)).ToString();                    
                    LimpiarDatosServicio();
                    txtCodigoPaciente.Enabled = false;
                    lupaPaciente.Enabled = false;
                    return;
                }
            }

            int newRow = dataGridServicios.Rows.Add(1);
            dataGridServicios.Rows[newRow].Cells[columnaCodigoServicio.Index].Value = campoCodigo.Text.ToString().Trim();
            dataGridServicios.Rows[newRow].Cells[columnaDescripcionServicio.Index].Value = campoDescripcioServicio.Text.ToString().Trim();            
            dataGridServicios.Rows[newRow].Cells[columnaCodigoTipoPrecio.Index].Value = comboTipoPrecio.SelectedValue.ToString();            
            dataGridServicios.Rows[newRow].Cells[columnaTipoPrecio.Index].Value = comboTipoPrecio.Text;
            dataGridServicios.Rows[newRow].Cells[columnaCantidad.Index].Value = Convert.ToDouble(campoCantidad.Text.ToString().Trim());
            dataGridServicios.Rows[newRow].Cells[columnaPrecioServicio.Index].Value = campoPrecio.Text.ToString().Trim();
            dataGridServicios.Rows[newRow].Cells[columnaSubTotal.Index].Value = (Convert.ToDouble(dataGridServicios.Rows[newRow].Cells[columnaCantidad.Index].Value) * Convert.ToDouble(dataGridServicios.Rows[newRow].Cells[columnaPrecioServicio.Index].Value)).ToString();
            dataGridServicios.Rows[newRow].Cells[columnaCodigoDoctor.Index].Value = campoCodigoDoctor.Text.Trim();
            dataGridServicios.Rows[newRow].Cells[columnaNombreDoctor.Index].Value = campoDescripcionDoctor.Text.Trim();

            txtCodigoPaciente.Enabled = false;
            lupaPaciente.Enabled = false;
            lupaDoctor.Enabled = false;
            LimpiarDatosServicio();
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarDatosServicio();
            dataGridServicios.Rows.Clear();
        }

        private void lupaPaciente_Click(object sender, EventArgs e)
        {
            
        }

        private void AsignarPrecio()
        {
            if (comboTipoPrecio.Enabled && _data != null)
            {
                var results = (from m in _data.AsEnumerable()
                               where m.Field<int>("coditips") == Convert.ToInt32(comboTipoPrecio.SelectedValue)
                               select m).FirstOrDefault();
                if(results!=null)
                    campoPrecio.Text = results["precserv"].ToString();
            }
        }

        private void campoCodigo_Validated(object sender, EventArgs e)
        {
            if (IsEmpty(campoCodigo.Text))            
                return;
            
            var cmd = String.Format("SELECT * FROM vista_servicio_precios WHERE codiserv={0} AND estado_servicio=true AND estado_precio=true", campoCodigo.Text);
            try
            {
                _data = PostgreSql.Execute(cmd);

                campoDescripcioServicio.Text = _data.Rows[0][campoDescripcioServicio.CampoBD].ToString();
                comboTipoPrecio.DataSource = _data;
                comboTipoPrecio.DisplayMember = "desctips";
                comboTipoPrecio.ValueMember = "coditips";

                campoCodigoDoctor.Enabled = true;
                lupaDoctor.Enabled = true;
                campoCantidad.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format("No hay informacion con el Codigo << {0} >>",campoCodigo.Text));
                comboTipoPrecio.Enabled = false;
                campoCantidad.Enabled = false;
                botonAgregar.Enabled = false;
                comboTipoPrecio.SelectedIndex = -1;
                LimpiarDatosServicio();
                return;
            }
            comboTipoPrecio.Enabled = true;
            campoCantidad.Enabled = true;
            botonAgregar.Enabled = true;

            comboTipoPrecio_SelectedIndexChanged(null, null);
        }

        private void comboTipoPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            AsignarPrecio();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void campoCodigoDoctor_Validated(object sender, EventArgs e)
        {
            if (IsEmpty(campoCodigoDoctor.Text))
                return;

            try
            {
                var cmd =
                    String.Format(
                        "select * from vista_persona_consulta where codigo in (select coditerc from doctor_encabezado ) and codigo={0}",
                        campoCodigoDoctor.Text);                

                DataTable data = PostgreSql.Execute(cmd);
                campoDescripcionDoctor.Text = data.Rows[0]["nombre"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show(String.Format("No Existe un Doctor con el Codigo <<{0}>> o el Doctor esta Desactivado",
                    campoCodigoDoctor.Text.Trim()));
            }
        }

        private void botonProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridServicios.Rows.Count <= 0)
                {
                    MessageBox.Show(@"Aun no se ha digitado ningun servicio para procesar");
                    return;
                }
                object[] datos = {
                                 txtNumeroAsunto.Text.Trim(),
                                 txtCodigoPaciente.Text.Trim()
                };
                
                var commando = String.Format("SELECT inserta_orden_trabajo_encabezado(" +
                    "{0}," +
                    "(select current_date),"
                    + "{1}," +
                    "(select codiesot from estado_orden_trabajo_encabezado where descesot='PENDIENTE' limit 1));", datos);

                var data = PostgreSql.Execute(commando);
                var codigo = data.Rows[0][0].ToString();
                foreach (DataGridViewRow row in dataGridServicios.Rows)
                {
                    commando = String.Format("SELECT inserta_orden_trabajo_detalle({0},{1},{2},{3},{4},{5});",
                        codigo,
                        row.Cells[columnaCantidad.Index].Value,
                        row.Cells[columnaCodigoServicio.Index].Value,
                        row.Cells[columnaPrecioServicio.Index].Value.ToString(),
                        row.Cells[columnaCodigoTipoPrecio.Index].Value,
                        row.Cells[columnaCodigoDoctor.Index].Value
                        );

                    PostgreSql.Execute(commando);
                }
                var numeroOrden = codigo;
                commando = String.Format("SELECT * FROM vista_reporte_orden_trabajo WHERE numero_orden={0}", numeroOrden);
                var Data = PostgreSql.Execute(commando);
                Efos.Reportes.SimpleReport report = new Reportes.SimpleReport();
                report.ShowReport(Data, "ReportOrdenTrabajo");
                report.Show();
            }
            catch(Exception){

            }
            if (MessageBox.Show(@"¿El pago de esta Orden se hara ahora?", @"Confirmacion || Importante", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return;
            }            
        }

        private void campoCodigoDoctor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                campoCodigoDoctor_Validated(null,null);
                efosButtonBuscador2_Click(null, null);
            }
        }

        private void dataGridServicios_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridServicios.Rows)
            {
                total = Convert.ToDouble(row.Cells[columnaSubTotal.Index].Value);
            }
            campoTotal.Text = total.ToString();
        }

        private void txtNumeroAsunto_Validated(object sender, EventArgs e)
        {
            botonNuevo_Click(null, null);

        }
    }
}