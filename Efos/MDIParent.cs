using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Efos.FormProceso;

namespace Efos
{
    public partial class MDIParent : Form
    {
        //private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
            confirmar();                                       
        }
        private bool checkForm(string nameForm)
        {
            foreach (Form formChild in this.MdiChildren)           
                if (formChild.Text.Equals(nameForm))                                    
                    return true;                            
            return false;
        }
        private void confirmar()
        {
            DataTable data = PostgreSQL.Execute("SELECT 1 as One");
            CambiarEstadoConexion(true);
            if (data == null)
                CambiarEstadoConexion(false);
        }
        private void confirmarConexion(object sender, EventArgs e)
        {
            confirmar();
        }
        private void CambiarEstadoConexion(bool estado)
        {
            if (estado==true)
            {
                this.estadoConexion.ForeColor = Color.White;
                this.estadoConexion.BackColor = Color.LightGreen;
                this.estadoConexion.Text = "Conectado";
            }
            else
            {
                this.estadoConexion.ForeColor = Color.White;
                this.estadoConexion.BackColor = Color.Red;
                this.estadoConexion.Text = "No hay Conexion";
            }
        }

        //private void ShowNewForm(object sender, EventArgs e)
        //{
        //    Form childForm = new Form();
        //    childForm.MdiParent = this;
        //    childForm.Text = "Ventana " + childFormNumber++;
        //    childForm.Show();
        //}

        //private void OpenFile(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new OpenFileDialog();
        //    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (openFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = openFileDialog.FileName;
        //    }
        //}

        //private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        //    saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
        //    if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        string FileName = saveFileDialog.FileName;
        //    }
        //}

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        //private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.Cascade);
        //}

        //private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.TileVertical);
        //}

        //private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.TileHorizontal);
        //}

        //private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    LayoutMdi(MdiLayout.ArrangeIcons);
        //}

        //private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (Form childForm in MdiChildren)
        //    {
        //        childForm.Close();
        //    }
        //}

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Banco"))
                return;

            FormMantenimientoBanco Form = new FormMantenimientoBanco("Mantenimiento de Banco","banco_encabezado","codibanc","descbanc","estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();           
        }

        private void Salir()
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                    childForm.Dispose();
                }
                this.Close();
            }  
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkForm("Facturacion"))
                return;

            FormProcesoFactura Form = new FormProcesoFactura();
            Form.Text = "Facturacion";
            Form.MdiParent = this;            
            Form.Show();
        }

        private void ordenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Ordenes de Trabajo"))
                return;

            FormProcesoOrdenTrabajo Form = new FormProcesoOrdenTrabajo();
            Form.Text = "Ordenes de Trabajo";
            Form.MdiParent = this;
            Form.Show();
        }

        private void ordenesDeTrabajoLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Ordenes de Trabajo de Laboratorio"))
                return;

            FormProcesoTrabajoDentales Form = new FormProcesoTrabajoDentales();
            Form.Text = "Ordenes de Trabajo de Laboratorio";
            Form.MdiParent = this;
            Form.Show();
        }

        private void ordenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Ordenes de Compra"))
                return;

            FormProcesoOrdenesCompra Form = new FormProcesoOrdenesCompra();
            Form.Text = "Ordenes de Compra";
            Form.MdiParent = this;
            Form.Show();
        }

        private void odontogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Odontograma de Pacientes"))
                return;

            FormProcesoOdontograma Form = new FormProcesoOdontograma();
            Form.Text = "Odontograma de Pacientes";
            Form.MdiParent = this;
            Form.Show();
        }

        private void recetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Receta de Pacientes"))
                return;

            FormProcesoReceta Form = new FormProcesoReceta();
            Form.Text = "Receta de Pacientes";
            Form.MdiParent = this;
            Form.Show();
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Doctor"))
                return;

            FormMantenimientoDoctor Form = new FormMantenimientoDoctor();
            Form.textTitulo.Text = "Mantenimiento de Doctor";
            Form.MdiParent = this;
            Form.Show();                       
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Paciente"))
                return;

            FormMantenimientoPaciente Form = new FormMantenimientoPaciente();
            Form.textTitulo.Text = "Mantenimiento de Paciente";
            Form.MdiParent = this;
            Form.Show();
        }

        private void ingredienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Ingrediente"))
                return;

            FormMantenimientoIngrediente Form = new FormMantenimientoIngrediente("Mantenimiento de Ingrediente","ingrediente_encabezado","codiingr","descingr","estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void nacionalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Nacionalidad"))
                return;
            FormMantenimientoNacionalidad Form = new FormMantenimientoNacionalidad("Mantenimiento de Nacionalidad");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Dominio Email's"))
                return;

            FormMantenimientoDominioEmail Form = new FormMantenimientoDominioEmail("Mantenimiento de Dominio Email's","dominio_email_encabezado","codidoem","descdoem","estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void estadosCivilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Estado Civil"))
                return;
            FormMantenimientoEstadoCivil Form = new FormMantenimientoEstadoCivil("Mantenimiento de Estado Civil","estado_civil_encabezado","codiesci","descesci","estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void nivelAcademicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Nivel Academico"))
                return;
            FormMantenimientoNivelAcademico Form = new FormMantenimientoNivelAcademico("Mantenimiento Nivel Academico", "nivel_academico_encabezado", "codiniac", "descniac", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void sexosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Genero"))
                return;
            
            FormMantenimientoSexo Form = new FormMantenimientoSexo("Mantenimiento de Genero", "sexo_encabezado", "codisexo", "descsexo", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void preguntaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Pregunta"))
                return;
            
            FormMantenimientoPregunta Form = new FormMantenimientoPregunta("Mantenimiento de Pregunta", "pregunta_encabezado", "codipreg", "descpreg", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void respuestaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Respuesta"))
                return;
            
            FormMantenimientoRespuesta Form = new FormMantenimientoRespuesta("Mantenimiento de Respuesta", "respuesta_encabezado", "codiresp", "descresp", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Ciudad"))
                return;

            FormMantenimientoCiudad Form = new FormMantenimientoCiudad("Mantenimiento de Ciudad");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Pais"))
                return;

            FormMantenimientoPais Form = new FormMantenimientoPais("Mantenimiento de Pais", "pais_encabezado", "codipais", "descpais", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void provinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Provincia"))
                return;

            FormMantenimientoProvincia Form = new FormMantenimientoProvincia("Mantenimiento de Provincia");
            Form.MdiParent = this;
            Form.Show();
        }

        private void sectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Sector"))
                return;

            FormMantenimientoSector Form = new FormMantenimientoSector("Mantenimiento de Sector");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void estadosPresupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Estado de Presupuesto"))
                return;

            FormMantenimientoEstadoPresupuesto Form = new FormMantenimientoEstadoPresupuesto("Mantenimiento de Estado de Presupuesto", "estado_presupuesto_encabezado", "codiespr", "descespr", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void terceroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Estado de Tercero"))
                return;

            FormMantenimientoEstadoTercero Form = new FormMantenimientoEstadoTercero("Mantenimiento de Estado de Tercero", "estado_tercero_encabezado", "codieste", "desceste", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void trabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Estado de Trabajo Dental"))
                return;

            FormMantenimientoEstadoTrabajo Form = new FormMantenimientoEstadoTrabajo("Mantenimiento de Estado de Trabajo Dental", "estado_trabajo_dental_encabezado", "codiesta", "descesta", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void dosisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Dosis"))
                return;

            FormMantenimientoDosi Form = new FormMantenimientoDosi("Mantenimiento de Dosis", "dosi_encabezado", "codidosi", "descdosi", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void ladoPiezaDentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Lado Pieza Dental"))
                return;

            FormMantenimientoLadoPiezaDental Form = new FormMantenimientoLadoPiezaDental("Mantenimiento de Lado Pieza Dental", "lado_pieza_dental_encabezado", "codilapi", "desclapi", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void medicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Medicamento"))
                return;

            FormMantenimientoMedicamento Form = new FormMantenimientoMedicamento();
            Form.textTitulo.Text = "Mantenimiento de Medicamento";
            Form.MdiParent = this;
            Form.Show();
        }

        private void patologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Patologia"))
                return;

            FormMantenimientoPatologia Form = new FormMantenimientoPatologia("Mantenimiento de Patologia", "patologia_encabezado", "codipato", "descpato", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void descuentosEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo Cuenta Empleado"))
                return;

            FormMantenimientoTipoDescuentoEmpleado Form = new FormMantenimientoTipoDescuentoEmpleado("Mantenimiento de Tipo Cuenta Empleado", "tipo_cuenta_empleado_encabezado", "coditicu", "descticu", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo de Empleado"))
                return;

            FormMantenimientoTipoEmpleado Form = new FormMantenimientoTipoEmpleado("Mantenimiento de Tipo de Empleado", "tipo_empleado_encabezado", "coditiem", "desctiem", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo de Factura"))
                return;

            FormMantenimientoTipoFactura Form = new FormMantenimientoTipoFactura("Mantenimiento de Tipo de Factura", "tipo_factura_encabezado", "coditifa", "desctifa", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void identificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo de Identificacion"))
                return;

            FormMantenimientoTipoIdentificacion Form = new FormMantenimientoTipoIdentificacion("Mantenimiento de Tipo de Identificacion", "tipo_identificacion_encabezado", "coditiid", "desctiid", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void medicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Sector"))
                return;

            FormMantenimientoTipoMedicamento Form = new FormMantenimientoTipoMedicamento();
            Form.textTitulo.Text = "Mantenimiento de Tipo de Medicamento";
            Form.MdiParent = this;
            Form.Show();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo de Paciente"))
                return;

            FormMantenimientoTipoPaciente Form = new FormMantenimientoTipoPaciente("Mantenimiento de Tipo de Paciente", "tipo_paciente_encabezado", "coditipa", "desctipa", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo de Pago"))
                return;

            FormMantenimientoTipoPago Form = new FormMantenimientoTipoPago("Mantenimiento de Tipo de Pago", "tipo_pago_encabezado", "coditipa", "desctipa", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo de Persona"))
                return;

            FormMantenimientoTipoPersona Form = new FormMantenimientoTipoPersona("Mantenimiento de Tipo de Persona", "tipo_persona_encabezado", "coditipe", "desctipe", "estado");            
            Form.MdiParent = this;
            Form.Show();
        }

        private void precioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo de Precio de Servicio"))
                return;

            FormMantenimientoTipoPrecioServicio Form = new FormMantenimientoTipoPrecioServicio("Mantenimiento de Tipo de Precio de Servicio", "tipo_precio_servicio_encabezado", "coditips", "desctips", "estado");         
            Form.MdiParent = this;
            Form.Show();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();            
            p.StartInfo.FileName = @"calc.exe";
            p.Start();            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaseMantenimientoPersona formu = new FormBaseMantenimientoPersona();
            formu.MdiParent = this;
            formu.Show();
        }

        private void confirmarConexion()
        {

        }

        private void cuestionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Tipo de Cuestionario"))
                return;

            FormMantenimientoTipoCuestionario formu = new FormMantenimientoTipoCuestionario("Mantenimiento de Tipo de Cuestionario","tipo_cuestionario_encabezado","coditicu","descticu","estado");
            formu.MdiParent = this;
            formu.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = @"notepad.exe";
            p.Start();  
        }

        private void cuestionarioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string tituloForm = "Mantenimiento de Cuestionario";

            if (checkForm(tituloForm))
                return;

            FormMantenimientoCuestionario Form = new FormMantenimientoCuestionario(tituloForm);
            Form.MdiParent = this;
            Form.Show();
        }

        private void testFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormBaseProceso Form = new FormBaseProceso();
            //Form.MdiParent = this;
            //Form.Show();
            //FormBaseConsulta Form = new FormBaseConsulta("Consulta Tipo de Paciente","tipo_paciente_encabezado","coditipa","desctipa","estado");
            //FormBaseConsultaPersona Form = new FormBaseConsultaPersona();
            //Form.Show();            
            //FormProcesoOrdenTrabajo Form = new FormProcesoOrdenTrabajo();
            //Form.Show();
            FormMantenimientoPaciente Form = new FormMantenimientoPaciente();
            Form.MdiParent = this;
            Form.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkForm("Mantenimiento de Producto"))
                return;
            FormMantenimientoProducto Form = new FormMantenimientoProducto();
            Form.textTitulo.Text = "Mantenimiento de Producto";
            Form.MdiParent = this;
            Form.Show();
        }

        private void precioProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo = "Mantenimiento de Tipo Precio Producto";
            if (checkForm(titulo))
                return;
            FormMantenimientoTipoPrecioProducto Form = new FormMantenimientoTipoPrecioProducto(titulo,"tipo_precio_producto_encabezado",
                "coditipr","desctipr","estado");           
            Form.MdiParent = this;
            Form.Show();            
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string titulo = "Mantenimiento Tipo de Producto";
            if (checkForm(titulo))
                return;
            FormMantenimientoTipoProducto Form = new FormMantenimientoTipoProducto(titulo, "tipo_producto_encabezado", "coditipr", "desctipr", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void preguntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo = "Mantenimiento Tipo de Pregunta";
            if (checkForm(titulo))
                return;
            FormMantenimientoTipoPregunta Form = new FormMantenimientoTipoPregunta(titulo, "tipo_pregunta_encabezado", "coditipr", "desctipr", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void telefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo = "Mantenimiento Tipo de Telefono";
            if (checkForm(titulo))
                return;
            FormMantenimientoTipoTelefono Form = new FormMantenimientoTipoTelefono(titulo, "tipo_telefono_encabezado", "coditite", "desctite", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo = "Mantenimiento Tipo de Servicios";
            if (checkForm(titulo))
                return;
            FormMantenimientoTipoTelefono Form = new FormMantenimientoTipoTelefono(titulo, "tipo_servicio_encabezado", "coditise", "desctise", "estado");
            Form.MdiParent = this;
            Form.Show();
        }

        private void insumoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo = "Mantenimiento de Insumo";
            if(checkForm(titulo))
                return;

            FormMantenimientoInsumo Form = new FormMantenimientoInsumo(titulo);
            Form.MdiParent = this;
            Form.Show();

        }

        private void servicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo = "Mantenimiento de Servicio";
            if (checkForm(titulo))
                return;

            FormMantenimientoServicio Form = new FormMantenimientoServicio();
            Form.MdiParent = this;
            Form.Show();
        }

        private void pacientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Reportes.SimpleReport Form = new Reportes.SimpleReport();
            Form.MdiParent = this;
            Form.Show();
        }

        private void cuestionarioToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }     
    }
}