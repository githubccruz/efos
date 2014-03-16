namespace Efos
{
    partial class FormMantenimientoPregunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaRespuestasDisponibles = new ControlesEfos.efosList();
            this.listaRespuestasElegidas = new ControlesEfos.efosList();
            this.botonAgregar = new ControlesEfos.efosButton();
            this.botonQuitar = new ControlesEfos.efosButton();
            this.efosPanel3 = new ControlesEfos.efosPanel();
            this.efosPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 126);
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(18, 9);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(151, 78);
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.Location = new System.Drawing.Point(256, 72);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Location = new System.Drawing.Point(44, 81);
            // 
            // checkEstado
            // 
            this.checkEstado.Location = new System.Drawing.Point(149, 158);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(42, 164);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(305, 347);
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(495, 347);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(117, 347);
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(210, 347);
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(18, 347);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(399, 347);
            // 
            // listaRespuestasDisponibles
            // 
            this.listaRespuestasDisponibles.campoCodigo = "codiresp";
            this.listaRespuestasDisponibles.campoDescripcion = "descresp";
            this.listaRespuestasDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaRespuestasDisponibles.FormattingEnabled = true;
            this.listaRespuestasDisponibles.ItemHeight = 15;
            this.listaRespuestasDisponibles.Location = new System.Drawing.Point(78, 4);
            this.listaRespuestasDisponibles.Name = "listaRespuestasDisponibles";
            this.listaRespuestasDisponibles.Size = new System.Drawing.Size(154, 124);
            this.listaRespuestasDisponibles.Sorted = true;
            this.listaRespuestasDisponibles.TabIndex = 19;
            this.listaRespuestasDisponibles.tablaBD = "respuesta_encabezado";
            this.listaRespuestasDisponibles.SelectedIndexChanged += new System.EventHandler(this.listaRespuestasDisponibles_SelectedIndexChanged);
            // 
            // listaRespuestasElegidas
            // 
            this.listaRespuestasElegidas.campoCodigo = "codiresp";
            this.listaRespuestasElegidas.campoDescripcion = "descresp";
            this.listaRespuestasElegidas.DisplayMember = "codiresp";
            this.listaRespuestasElegidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaRespuestasElegidas.FormattingEnabled = true;
            this.listaRespuestasElegidas.ItemHeight = 15;
            this.listaRespuestasElegidas.Location = new System.Drawing.Point(319, 4);
            this.listaRespuestasElegidas.Name = "listaRespuestasElegidas";
            this.listaRespuestasElegidas.Size = new System.Drawing.Size(154, 124);
            this.listaRespuestasElegidas.Sorted = true;
            this.listaRespuestasElegidas.TabIndex = 20;
            this.listaRespuestasElegidas.tablaBD = "respuesta_encabezado";
            this.listaRespuestasElegidas.ValueMember = "descresp";
            this.listaRespuestasElegidas.SelectedIndexChanged += new System.EventHandler(this.listaRespuestasElegidas_SelectedIndexChanged);
            // 
            // botonAgregar
            // 
            this.botonAgregar.Enabled = false;
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.ForeColor = System.Drawing.Color.Green;
            this.botonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonAgregar.Location = new System.Drawing.Point(259, 214);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 50);
            this.botonAgregar.TabIndex = 21;
            this.botonAgregar.Text = "&Agregar >>>";
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonQuitar
            // 
            this.botonQuitar.Enabled = false;
            this.botonQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonQuitar.ForeColor = System.Drawing.Color.Red;
            this.botonQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonQuitar.Location = new System.Drawing.Point(259, 271);
            this.botonQuitar.Name = "botonQuitar";
            this.botonQuitar.Size = new System.Drawing.Size(75, 50);
            this.botonQuitar.TabIndex = 22;
            this.botonQuitar.Text = "<<< &Quitar";
            this.botonQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonQuitar.UseVisualStyleBackColor = true;
            this.botonQuitar.Click += new System.EventHandler(this.botonQuitar_Click);
            // 
            // efosPanel3
            // 
            this.efosPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel3.Controls.Add(this.listaRespuestasDisponibles);
            this.efosPanel3.Controls.Add(this.listaRespuestasElegidas);
            this.efosPanel3.Location = new System.Drawing.Point(19, 200);
            this.efosPanel3.Name = "efosPanel3";
            this.efosPanel3.Size = new System.Drawing.Size(552, 138);
            this.efosPanel3.TabIndex = 23;
            // 
            // FormMantenimientoPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 405);
            this.Controls.Add(this.botonQuitar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.efosPanel3);
            this.Name = "FormMantenimientoPregunta";
            this.Text = "FormMantenimientoPregunta";
            this.Controls.SetChildIndex(this.efosPanel3, 0);
            this.Controls.SetChildIndex(this.botonNuevo, 0);
            this.Controls.SetChildIndex(this.botonEditar, 0);
            this.Controls.SetChildIndex(this.botonGuardar, 0);
            this.Controls.SetChildIndex(this.botonCancelar, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.botonBuscar, 0);
            this.Controls.SetChildIndex(this.botonBuscarLupa, 0);
            this.Controls.SetChildIndex(this.botonSalir, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.textTitulo, 0);
            this.Controls.SetChildIndex(this.labelEstado, 0);
            this.Controls.SetChildIndex(this.checkEstado, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.botonAgregar, 0);
            this.Controls.SetChildIndex(this.botonQuitar, 0);
            this.efosPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosList listaRespuestasDisponibles;
        private ControlesEfos.efosList listaRespuestasElegidas;
        private ControlesEfos.efosButton botonAgregar;
        private ControlesEfos.efosButton botonQuitar;
        private ControlesEfos.efosPanel efosPanel3;

    }
}