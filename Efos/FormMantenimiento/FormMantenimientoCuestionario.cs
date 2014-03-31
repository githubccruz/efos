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
    public partial class FormMantenimientoCuestionario : FormBaseMantenimiento
    {
        public FormMantenimientoCuestionario()
        {
            inicializarFormulario();
        }
        public FormMantenimientoCuestionario(string titulo)
        {
            Text = titulo;
            textTitulo.Text = titulo;
            inicializarFormulario();
        }

        private void inicializarFormulario()
        {
            InitializeComponent();
            inicializarValores();
        }

        private void inicializarValores()
        {
            gridPreguntas.BackgroundColor = this.BackColor;
            txtCodigo.Text = 0.ToString();
            txtCodigo.Enabled = true;
            
            cmpFechaCreacion.Text = System.DateTime.Today.ToString().Substring(0, 10);
            cmpFechaCreacion.Enabled = false;

            gridPreguntas.Enabled = false;
            cmbTipoCuestionario.Enabled = false;

            botonBuscar.Enabled = true;
            botonNuevo.Enabled = true;
            botonSalir.Enabled = true;
            botonBuscarLupa.Enabled = true;

            botonGuardar.Enabled = false;
            botonCancelar.Enabled = false;
            botonEditar.Enabled = false;
        }

        private void cargarInformacion()
        {
            PostgreSQL.FillComboBox(cmbTipoCuestionario, "coditicu", "descticu", "tipo_cuestionario_encabezado", filter: "estado=true");
            string cmd = String.Format("SELECT * FROM pregunta_encabezado WHERE estado={0} ORDER BY descpreg",true);
            
            DataTable datos = PostgreSQL.Execute(cmd);
            int indexRow = 0;
            gridPreguntas.Rows.Clear();
            foreach (DataRow row in datos.Rows)
            {
                gridPreguntas.Rows.Add(1);
                gridPreguntas.Rows[indexRow].Cells[0].Value = row["descpreg"].ToString();
                gridPreguntas.Rows[indexRow].Cells[1].Value = row["codipreg"].ToString();                
                indexRow++;
            }
        }

        private void botonNuevo_Click(object sender, EventArgs e)
        {            
            gridPreguntas.Rows.Clear();
            cargarInformacion(); 
            habilitarCampos(this.Controls, true);
            //inicializarValores();
            txtCodigo.Enabled = false;
            cmbTipoCuestionario.Enabled = true;

            gridPreguntas.Enabled = true;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            gridPreguntas.Enabled = false;
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            try
            {            
                string[] datos = new string[3];
                datos[0] = txtCodigo.Text.ToString().Trim();
                datos[1] = cmbTipoCuestionario.SelectedValue.ToString();
                datos[2] = checkEstado.Checked.ToString();

                string cmd = String.Format("SELECT inserta_cuestionario_encabezado({0},{1},{2})",datos);
                DataTable result = PostgreSQL.Execute(cmd);
                if (result.Rows[0][0].ToString().Equals((-1).ToString()))
                {
                    MessageBox.Show("Ya existe un cuestionario especifico para " + cmbTipoCuestionario.Text);
                    return;
                }
                datos[0] = result.Rows[0][0].ToString(); 

                PostgreSQL.Execute(String.Format("SELECT limpiaCodigoPreguntaCuestionario({0});", datos[0]));
                foreach (DataGridViewRow row in gridPreguntas.Rows)
                {                
                    if (Convert.ToBoolean(row.Cells[2].Value))
                    {
                        cmd = String.Format("SELECT inserta_cuestionario_vs_pregunta_detalle({0},{1});", datos[0], row.Cells[1].Value);                    
                        PostgreSQL.Execute(cmd);
                    }
                }
                txtCodigo.Text = datos[0];
            }
            catch (Exception)
            {
                MessageBox.Show("Esto es Embarasozo  :-(, Existe un Problema con la Conexion a la Base de Datos");
            }
        }

        private void activarPregunta(string value)
        {
            foreach (DataGridViewRow row in gridPreguntas.Rows)
            {                
                if (row.Cells[1].Value.ToString().Equals(value))
                {                    
                    row.Cells[2].Value = true;
                    return;
                }
            }
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if(IsEmpty(txtCodigo.Text.Trim()))            
                return;
            
            string codigo = txtCodigo.Text.Trim();
            try
            {
                cargarInformacion();
                string cmd = String.Format("SELECT * FROM cuestionario_encabezado WHERE codicues={0}", codigo);
                DataTable data = PostgreSQL.Execute(cmd);

                cmpFechaCreacion.Text = data.Rows[0]["fechcues"].ToString().Substring(0,10);
                cmbTipoCuestionario.SelectedValue = Convert.ToInt32(data.Rows[0]["coditicu"]);
                checkEstado.Checked = Convert.ToBoolean(data.Rows[0]["estado"]);
            }
            catch (Exception)
            {
                MessageBox.Show("No existe cuestionario con el codigo << "+codigo+" >>");
                gridPreguntas.Rows.Clear();
                inicializarValores();
                return;
            }

            try
            {
                string cmd = String.Format("SELECT * FROM cuestionario_vs_pregunta_detalle WHERE codicues={0}",codigo);
                DataTable data = PostgreSQL.Execute(cmd);

                this.AccionCodigoValidado();
                foreach (DataRow row in data.Rows)
                {                   
                    activarPregunta(row["codipreg"].ToString());
                }
            }
            catch (Exception)
            {
                
            }            
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            gridPreguntas.Enabled = true;
            cmpFechaCreacion.Enabled = false;
        }
    }
}
