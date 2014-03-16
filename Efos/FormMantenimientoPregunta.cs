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
    public partial class FormMantenimientoPregunta : FormBaseMantenimientoGeneral
    {
        public FormMantenimientoPregunta()
        {
            InitializeComponent();
        }
        private void inicializar()
        {
            InitializeComponent();
        }
        public FormMantenimientoPregunta(string titulo,string tablaBD,string campoCodigo,string campoDescripcion, string campoEstado)
        {
            inicializar();
            textTitulo.Text = titulo.Trim();

            txtCodigo.CampoBD = campoCodigo;
            txtDescripcion.CampoBD = campoDescripcion;
            checkEstado.CampoBD = campoEstado;

            this.TablaBD = tablaBD;           
        }
        private void AccionBotonNuevo_2()
        {
            listaRespuestasDisponibles.Items.Clear();
            listaRespuestasElegidas.Items.Clear();

            DataTable dt =  PostgreSQL.Execute("SELECT "+listaRespuestasDisponibles.campoDescripcion+" FROM "+listaRespuestasDisponibles.tablaBD+" WHERE estado=true");
            
            foreach (System.Data.DataRow row in dt.Rows)            
                listaRespuestasDisponibles.Items.Add(row["descresp"]);

            listaRespuestasElegidas.Enabled = true;
            listaRespuestasDisponibles.Enabled = true;
        }
        private void botonNuevo_Click(object sender, EventArgs e)
        {
            AccionBotonNuevo_2();
        }        

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            HabilitarControl(botonAgregar, false);

            if (listaRespuestasDisponibles.SelectedIndex > -1)            
                transferirValores(listaRespuestasDisponibles, listaRespuestasElegidas);            
            
        }
        private void transferirValores(ControlesEfos.efosList desde, ControlesEfos.efosList hasta)
        {            
            hasta.Items.Add(desde.Text);
            desde.Items.RemoveAt(desde.SelectedIndex);
        }
        private void botonQuitar_Click(object sender, EventArgs e)
        {
            HabilitarControl(botonQuitar, false);

            if (listaRespuestasElegidas.SelectedIndex > -1)            
                transferirValores(listaRespuestasElegidas, listaRespuestasDisponibles);                     
        }
        private void listaRespuestasDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaRespuestasDisponibles.SelectedIndex > -1)            
                HabilitarControl(botonAgregar, true);            
            else
                HabilitarControl(botonAgregar, false);
        }
        private void listaRespuestasElegidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaRespuestasElegidas.SelectedIndex > -1)
                HabilitarControl(botonQuitar, true);
            else
                HabilitarControl(botonQuitar, false);
        }
        private void botonGuardar_Click(object sender, EventArgs e)
        {
            PostgreSQL.Execute(String.Format("select limpiaCodigoRespuesta({0})",txtCodigo.Text));

            foreach (string item in listaRespuestasElegidas.Items)
	        {
                txtCodigo.Text = PostgreSQL.Execute(String.Format("SELECT inserta_pregunta_vs_respuesta_detalle({0},'{1}');", txtCodigo.Text, item)).Rows[0][0].ToString();
	        }
            HabilitarControl(listaRespuestasElegidas, false);
            HabilitarControl(listaRespuestasDisponibles, false);
        }

        private void efosButton1_Click(object sender, EventArgs e)
        {
            AccionBotonNuevo_2();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            listaRespuestasDisponibles.Items.Clear();

            listaRespuestasDisponibles.Enabled = false;
            listaRespuestasElegidas.Enabled = false;
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            HabilitarControl(listaRespuestasDisponibles, true);
            HabilitarControl(listaRespuestasElegidas, true);
        }

        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            listaRespuestasDisponibles.Items.Clear();
            listaRespuestasElegidas.Items.Clear();

            string cmd = String.Format("SELECT {0},{1} from vista_pregunta WHERE {2}={3}",
                    listaRespuestasElegidas.campoCodigo,
                    listaRespuestasElegidas.campoDescripcion,
                    txtCodigo.CampoBD,
                    txtCodigo.Text);

            DataTable dt = PostgreSQL.Execute(cmd);
            List<string> lista = new List<string>();

            foreach (DataRow item in dt.Rows)
            {
                lista.Add(item["codiresp"].ToString());
                listaRespuestasElegidas.Items.Add(item["descresp"]);
            }
            string[] argumentos = new string[lista.Count];
            int indice = 0;

            foreach (string item in lista)
            {
                argumentos[indice] = item;
                indice++;
            }
            cmd = String.Format("SELECT {0} from vista_pregunta WHERE {2}={3}",
                    listaRespuestasElegidas.campoCodigo,
                    listaRespuestasElegidas.campoDescripcion,
                    txtCodigo.CampoBD,
                    txtCodigo.Text);

            cmd = String.Format("SELECT descresp FROM respuesta_encabezado WHERE codiresp not in ({0})",cmd);

            dt = PostgreSQL.Execute(cmd);
            
            foreach (DataRow item in dt.Rows)
            {
                listaRespuestasDisponibles.Items.Add(item["descresp"]);
            }
            
            listaRespuestasDisponibles.Enabled = false;
            listaRespuestasElegidas.Enabled = false;

            lista = null;
            cmd = null;
            argumentos = null;
            dt = null;
        }
    }
}