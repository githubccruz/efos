namespace Efos
{
    partial class FormBaseMantenimiento
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
            this.txtCodigo = new ControlesEfos.efosCampoCodigo();
            this.labelCodigo = new ControlesEfos.efosLetrero();
            this.checkEstado = new ControlesEfos.efosCheck();
            this.labelEstado = new ControlesEfos.efosLetrero();
            this.textTitulo = new System.Windows.Forms.Label();
            this.botonBuscarLupa = new ControlesEfos.efosButtonBuscador();
            this.botonCancelar = new ControlesEfos.efosButtonCancelar();
            this.botonSalir = new ControlesEfos.efosButtonSalir();
            this.botonGuardar = new ControlesEfos.efosButtonGuardar();
            this.botonEditar = new ControlesEfos.efosButtonEditar();
            this.botonNuevo = new ControlesEfos.efosButtonNuevo();
            this.botonBuscar = new ControlesEfos.efosButtonBuscar();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.CampoBD = null;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Limpiar = true;
            this.txtCodigo.Location = new System.Drawing.Point(153, 78);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 21);
            this.txtCodigo.SoloLectura = false;
            this.txtCodigo.TabIndex = 9;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(43, 81);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(56, 15);
            this.labelCodigo.TabIndex = 6;
            this.labelCodigo.Text = "Código:";
            this.labelCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkEstado
            // 
            this.checkEstado.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkEstado.CampoBD = null;
            this.checkEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstado.Location = new System.Drawing.Point(153, 231);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(100, 27);
            this.checkEstado.TabIndex = 14;
            this.checkEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEstado.UseVisualStyleBackColor = true;
            this.checkEstado.CheckedChanged += new System.EventHandler(this.checkEstado_CheckedChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(43, 237);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(59, 15);
            this.labelEstado.TabIndex = 13;
            this.labelEstado.Text = "Estado: ";
            this.labelEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTitulo
            // 
            this.textTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textTitulo.Location = new System.Drawing.Point(20, 9);
            this.textTitulo.Name = "textTitulo";
            this.textTitulo.Size = new System.Drawing.Size(552, 48);
            this.textTitulo.TabIndex = 15;
            this.textTitulo.Text = "label1";
            this.textTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textTitulo.TextChanged += new System.EventHandler(this.textTitulo_TextChanged);
            // 
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarLupa.Image = global::Efos.Properties.Resources.search1;
            this.botonBuscarLupa.Location = new System.Drawing.Point(258, 72);
            this.botonBuscarLupa.Name = "botonBuscarLupa";
            this.botonBuscarLupa.Size = new System.Drawing.Size(32, 32);
            this.botonBuscarLupa.TabIndex = 10;
            this.botonBuscarLupa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonBuscarLupa.UseVisualStyleBackColor = true;
            this.botonBuscarLupa.Click += new System.EventHandler(this.efosButtonBuscador_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Image = global::Efos.Properties.Resources.cancel;
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonCancelar.Location = new System.Drawing.Point(314, 296);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 50);
            this.botonCancelar.TabIndex = 3;
            this.botonCancelar.Text = "&Cancelar";
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.Image = global::Efos.Properties.Resources.logout;
            this.botonSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonSalir.Location = new System.Drawing.Point(504, 296);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 50);
            this.botonSalir.TabIndex = 5;
            this.botonSalir.Text = "&Salir";
            this.botonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.efosButtonSalir1_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonGuardar.Image = global::Efos.Properties.Resources.save;
            this.botonGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonGuardar.Location = new System.Drawing.Point(126, 296);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 50);
            this.botonGuardar.TabIndex = 2;
            this.botonGuardar.Text = "&Guardar";
            this.botonGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEditar.Image = global::Efos.Properties.Resources.edit_document;
            this.botonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonEditar.Location = new System.Drawing.Point(219, 296);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 50);
            this.botonEditar.TabIndex = 1;
            this.botonEditar.Text = "&Editar";
            this.botonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNuevo.Image = global::Efos.Properties.Resources.document_new;
            this.botonNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonNuevo.Location = new System.Drawing.Point(27, 296);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 50);
            this.botonNuevo.TabIndex = 0;
            this.botonNuevo.Text = "&Nuevo";
            this.botonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.efosButtonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Image = global::Efos.Properties.Resources.search_advanced;
            this.botonBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonBuscar.Location = new System.Drawing.Point(408, 296);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 50);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonBuscar.UseVisualStyleBackColor = true;
            // 
            // FormBaseMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(601, 358);
            this.ControlBox = false;
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.textTitulo);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonBuscarLupa);
            this.Controls.Add(this.txtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBaseMantenimiento";
            this.Text = "FormBaseMantenimiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label textTitulo;
        public ControlesEfos.efosCampoCodigo txtCodigo;
        public ControlesEfos.efosButtonBuscador botonBuscarLupa;
        public ControlesEfos.efosLetrero labelCodigo;
        public ControlesEfos.efosCheck checkEstado;
        public ControlesEfos.efosLetrero labelEstado;
        public ControlesEfos.efosButtonCancelar botonCancelar;
        public ControlesEfos.efosButtonSalir botonSalir;
        public ControlesEfos.efosButtonGuardar botonGuardar;
        public ControlesEfos.efosButtonEditar botonEditar;
        public ControlesEfos.efosButtonNuevo botonNuevo;
        public ControlesEfos.efosButtonBuscar botonBuscar;

        //private System.Windows.Forms.Button button1;
        //private System.Windows.Forms.Button button2;

    }
}