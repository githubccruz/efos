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
    public partial class FormBaseMantenimientoPersona : FormBaseMantenimiento
    {

        public FormBaseMantenimientoPersona()
        {
            inicializarFormulario();
        }

        public FormBaseMantenimientoPersona(string Titulo)
        {
            inicializarFormulario();
            textTitulo.Text = Titulo.Trim();
            this.Text = Titulo.Trim();            
        }

        private void inicializarFormulario()
        {            
            InitializeComponent();
            InicializarForm();
        }

        public Image imagenDefecto { set;get;}

        public string codigoGenerado { set; get; }

        public void InicializarForm()
        {
            foreach (TabPage item in tabPanel.TabPages)
            {
                item.BackColor = this.BackColor;
            }
            gridIdentificacion.BackgroundColor = this.BackColor;
            gridTelefono.BackgroundColor = this.BackColor;
            gridDireccion.BackgroundColor = this.BackColor;

            botonEliminarDireccion.Text = "Eliminar";
            botonEliminarIdentificacion.Text = "Eliminar";
            botonEliminarTelefono.Text = "Eliminar";
            
            
            botonEliminarTelefono.UseColumnTextForButtonValue = true;

            AccionBotonCancelar();
            HabilitarDataGrid(false);

            
            imagenDefecto = imagePerson.Image;
        }

        private void loadImage()
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(dlg.FileName);
                imagePerson.Image = img;
                imagePerson.RutaImagen = dlg.FileName;
            }

            dlg.Dispose();
        }

        private void imagePerson_Click(object sender, EventArgs e)
        {
            loadImage();
        }

        private void checkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cargarInformacion()
        {
            cmpFechaCreacion.Text = System.DateTime.Today.ToString().Substring(0, 10);
            cmpFechaCreacion.Enabled = false;
            imagePerson.Enabled = true;

            tabPanel.SelectedTab = tabDatosPersonales;

            PostgreSql.FillComboBox(columnTipoIdentificacion, "coditiid", "desctiid", "tipo_identificacion_encabezado", filter: "estado=true");
            PostgreSql.FillComboBox(columnTipoTelefono, "coditite", "desctite", "tipo_telefono_encabezado", filter: "estado=true");
            PostgreSql.FillComboBox(columnSector, "codisect", "descsect", "sector_encabezado", filter: "estado=true");

            PostgreSql.FillComboBox(cmbNacionalidad, "codinaci", "descnaci", "nacionalidad_encabezado", filter: "estado=true");
            PostgreSql.FillComboBox(cmbSexo, "codisexo", "descsexo", "sexo_encabezado", filter: "estado=true");
            PostgreSql.FillComboBox(cmbEstadoCivil, "codiesci", "descesci", "estado_civil_encabezado", filter: "estado=true");
            PostgreSql.FillComboBox(cmbNivelAcademico, "codiniac", "descniac", "nivel_academico_encabezado", filter: "estado=true");
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "0";
            cargarInformacion();
            HabilitarDataGrid(true);
            imagePerson.Image = imagenDefecto;
        }        
        
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[11];
            datos[0] = txtCodigo.Text;
            datos[1] = cmbSexo.SelectedValue.ToString();
            datos[2] = cmbNacionalidad.SelectedValue.ToString();
            datos[3] = cmbNivelAcademico.SelectedValue.ToString();
            datos[4] = cmbEstadoCivil.SelectedValue.ToString();
            
            datos[5] = checkEstado.Checked.ToString();
            datos[6] = cmpNombre1.Text.Trim();
            datos[7] = cmpNombre2.Text.Trim();

            datos[8] = cmpApellido1.Text.Trim();
            datos[9] = cmpApellido2.Text.Trim();
            datos[10] = cmpFechaNacimiento.Text.Trim();

            string cmd = (String.Format("SELECT inserta_persona_encabezado({0}, {1}, {2}, {3}, {4}, {5}, '{6}', '{7}', '{8}', '{9}', '{10}');",datos));
            //MessageBox.Show("Query is ==> "+cmd);
            
            string codigo = PostgreSql.Execute(cmd).Rows[0][0].ToString();
            imagePerson.Enabled = false;
            codigoGenerado = codigo;
            PostgreSql.Execute(String.Format("SELECT limpiaCodigoIdentificacionPersona({0})",codigo));
            
            foreach (DataGridViewRow row in gridIdentificacion.Rows)
            {
                if (row.Cells[0].Value != null && !String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    cmd = String.Format("SELECT inserta_persona_vs_identificacion_detalle({0},{1},'{2}');", codigo, row.Cells[0].Value.ToString(), row.Cells[1].Value);

                    PostgreSql.Execute(cmd);
                }
            }
            PostgreSql.Execute(String.Format("SELECT limpiaCodigoTelefonoPersona({0})", codigo));
            foreach (DataGridViewRow row in gridTelefono.Rows)
            {
                if (row.Cells[0].Value != null && !String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {
                    cmd = String.Format("SELECT inserta_persona_vs_telefono_detalle({0},'{2}',{1});", codigo, row.Cells[0].Value.ToString(), row.Cells[1].Value);
                    PostgreSql.Execute(cmd);
                }
            }
            PostgreSql.Execute(String.Format("SELECT limpiaCodigoDireccionPersona({0})", codigo));
            foreach (DataGridViewRow row in gridDireccion.Rows)
            {
                if (row.Cells[0].Value != null && !String.IsNullOrEmpty(row.Cells[0].Value.ToString()))
                {                    
                    cmd = String.Format("SELECT inserta_persona_vs_direccion_detalle({0},'{1}','{2}','{3}','{4}',{5});",
                        codigo, row.Cells[0].Value, row.Cells[1].Value,row.Cells[2].Value,row.Cells[3].Value,row.Cells[4].Value.ToString());
                    //MessageBox.Show("Test Query: "+cmd);
                    PostgreSql.Execute(cmd);
                }
            }
            HabilitarDataGrid(false);
            if (!String.IsNullOrEmpty(imagePerson.RutaImagen) && imagePerson.RutaImagen.Trim() != "")
                PostgreSql.guardarImagen("persona_encabezado", "coditerc", "imagpers", codigo, imagePerson.RutaImagen);
        }

        private void botonBuscarLupa_Click(object sender, EventArgs e)
        {
            //imagePerson.Image = PostgreSQL.GetProductImage("1");
            //string json = JsonConvert.SerializeObject(table, Formatting.Indented);

        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            limpiarControles(this.Controls);
            tabPanel.SelectedTab = tabDatosPersonales;
            txtCodigo.Text = "0";
            imagePerson.Enabled = false;
            imagePerson.Image = imagenDefecto;
            HabilitarDataGrid(false);               
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            imagePerson.Enabled = true;
            HabilitarDataGrid(true);
            cmpFechaCreacion.Enabled = false;
        }
        
        private void gridIdentificacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(gridIdentificacion, e.ColumnIndex, e.RowIndex);
        }

        private void gridDireccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(gridDireccion, e.ColumnIndex, e.RowIndex);
        }

        private void gridTelefono_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            eliminarFila(gridTelefono, e.ColumnIndex, e.RowIndex);
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            try
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
            }
            catch (Exception)
            {
                errorConsulta();
                return;
            }
            if (String.IsNullOrEmpty(txtCodigo.Text) || txtCodigo.Text==0.ToString())            
                return;
            try
            {                
                cargarInformacion();
                string codigo = txtCodigo.Text.ToString().Trim();
                limpiarControles(this.Controls);                
                DataTable data = PostgreSql.Execute("SELECT * FROM vista_persona_datosPersonales where codigo=" + codigo);                
                txtCodigo.Text = data.Rows[0]["codigo"].ToString();                
                cmpFechaCreacion.Text = data.Rows[0]["fechacreacion"].ToString().Substring(0,10);                
                cmpNombre1.Text = data.Rows[0]["nombre1"].ToString();
                cmpNombre2.Text = data.Rows[0]["nombre2"].ToString();
                cmpApellido1.Text = data.Rows[0]["apellido1"].ToString();
                cmpApellido2.Text = data.Rows[0]["apellido2"].ToString();
                cmpFechaNacimiento.Text = data.Rows[0]["fechanacimiento"].ToString();

                checkEstado.Checked = Convert.ToBoolean(data.Rows[0]["estado"].ToString());

                cmbEstadoCivil.SelectedIndex =cmbEstadoCivil.FindString(data.Rows[0]["estadocivil"].ToString());
                cmbNacionalidad.SelectedIndex = cmbNacionalidad.FindString(data.Rows[0]["nacionalidad"].ToString());
                cmbSexo.SelectedIndex = cmbSexo.FindString(data.Rows[0]["sexo"].ToString());
                cmbNivelAcademico.SelectedIndex = cmbNivelAcademico.FindString(data.Rows[0]["nivelacademico"].ToString());
                data = PostgreSql.Execute("SELECT * FROM vista_identificacion WHERE codigo=" + codigo);

                int indexRow = 0;
                if (data!=null)
                foreach (DataRow row in data.Rows)
	            {
                    gridIdentificacion.Rows.Add(1);
		            gridIdentificacion.Rows[indexRow].Cells[0].Value = Convert.ToInt32(row["tipo"]);
                    gridIdentificacion.Rows[indexRow].Cells[1].Value = row["referencia"].ToString(); 
                    indexRow++;                    
	            }                
                data = PostgreSql.Execute("SELECT * FROM vista_direccion_persona WHERE codigo=" + codigo);
                indexRow = 0;
                if (data != null)
                foreach (DataRow row in data.Rows)
                {
                    gridDireccion.Rows.Add(1);                    
                    gridDireccion.Rows[indexRow].Cells[0].Value = row["calle"].ToString();                    
                    gridDireccion.Rows[indexRow].Cells[1].Value = row["casa"].ToString();                    
                    gridDireccion.Rows[indexRow].Cells[2].Value = row["habitacion"].ToString();                    
                    gridDireccion.Rows[indexRow].Cells[3].Value = row["nivel"].ToString();                    
                    gridDireccion.Rows[indexRow].Cells[4].Value = Convert.ToInt32(row["sector"]);                    
                    indexRow++;                    
                }                
                data = PostgreSql.Execute("SELECT * FROM vista_telefono_persona WHERE codigo=" + codigo);
                indexRow = 0;
                if (data != null)
                foreach (DataRow row in data.Rows)
                {
                    gridTelefono.Rows.Add(1);
                    gridTelefono.Rows[indexRow].Cells[0].Value = Convert.ToInt32(row["tipo"]);
                    gridTelefono.Rows[indexRow].Cells[1].Value = row["descripcion"];
                    indexRow++;                    
                }
                
                Image imagen = PostgreSql.extraerImagen(codigo);

                if (imagen != null)
                    imagePerson.Image = imagen;
                else
                {
                    imagePerson.Image = imagenDefecto;
                }
                AccionCodigoValidado();
                imagePerson.Enabled = false;
            }
            catch
            {
                MessageBox.Show("No existen personas con el codigo "+txtCodigo.Text,"Aviso!!!");
                errorConsulta();
            }            

        }

        private void errorConsulta()
        {
            imagePerson.Image = imagenDefecto;
            habilitarCampos(this.Controls, false);
            limpiarControles(this.Controls);
            AccionBotonCancelar();            
            iniciarValores();
        }

        private void HabilitarDataGrid(bool habilitar)
        {
            gridDireccion.Enabled = habilitar;
            gridIdentificacion.Enabled = habilitar;
            gridTelefono.Enabled = habilitar;            
        }
        
        private void checkEstado_Click(object sender, EventArgs e)
        {

        }
    }
}