namespace Efos
{
    partial class FormBaseProceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseProceso));
            this.letreroNombrePaciente = new ControlesEfos.efosLetrero();
            this.botonNuevo = new ControlesEfos.efosButtonNuevo();
            this.lupaAsunto = new ControlesEfos.efosButtonBuscador();
            this.lupaPaciente = new ControlesEfos.efosButtonBuscador();
            this.efosLetrero3 = new ControlesEfos.efosLetrero();
            this.txtCodigoPaciente = new ControlesEfos.efosCampo();
            this.txtNumeroAsunto = new ControlesEfos.efosCampoCodigo();
            this.txtFechaAsunto = new ControlesEfos.efosCampo();
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.efosLetrero1 = new ControlesEfos.efosLetrero();
            this.botonSalir = new ControlesEfos.efosButtonSalir();
            this.botonBuscar = new ControlesEfos.efosButtonBuscar();
            this.botonCancelar = new ControlesEfos.efosButtonCancelar();
            this.botonProcesar = new ControlesEfos.efosButtonProcesar();
            this.efosGroupBoxPadre = new ControlesEfos.efosGroupBox();
            this.SuspendLayout();
            // 
            // letreroNombrePaciente
            // 
            this.letreroNombrePaciente.AutoSize = true;
            this.letreroNombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNombrePaciente.Location = new System.Drawing.Point(295, 85);
            this.letreroNombrePaciente.Name = "letreroNombrePaciente";
            this.letreroNombrePaciente.Size = new System.Drawing.Size(142, 15);
            this.letreroNombrePaciente.TabIndex = 14;
            this.letreroNombrePaciente.Text = "Nombre del Paciente";
            this.letreroNombrePaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonNuevo.Image = ((System.Drawing.Image)(resources.GetObject("botonNuevo.Image")));
            this.botonNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonNuevo.Location = new System.Drawing.Point(144, 429);
            this.botonNuevo.Name = "botonNuevo";
            this.botonNuevo.Size = new System.Drawing.Size(75, 50);
            this.botonNuevo.TabIndex = 13;
            this.botonNuevo.Text = "&Nuevo";
            this.botonNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonNuevo.UseVisualStyleBackColor = true;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // lupaAsunto
            // 
            this.lupaAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lupaAsunto.Image = ((System.Drawing.Image)(resources.GetObject("lupaAsunto.Image")));
            this.lupaAsunto.Location = new System.Drawing.Point(153, 34);
            this.lupaAsunto.Name = "lupaAsunto";
            this.lupaAsunto.Size = new System.Drawing.Size(35, 30);
            this.lupaAsunto.TabIndex = 12;
            this.lupaAsunto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lupaAsunto.UseVisualStyleBackColor = true;
            // 
            // lupaPaciente
            // 
            this.lupaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lupaPaciente.Image = ((System.Drawing.Image)(resources.GetObject("lupaPaciente.Image")));
            this.lupaPaciente.Location = new System.Drawing.Point(153, 77);
            this.lupaPaciente.Name = "lupaPaciente";
            this.lupaPaciente.Size = new System.Drawing.Size(35, 30);
            this.lupaPaciente.TabIndex = 11;
            this.lupaPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lupaPaciente.UseVisualStyleBackColor = true;
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.AutoSize = true;
            this.efosLetrero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero3.Location = new System.Drawing.Point(22, 85);
            this.efosLetrero3.Name = "efosLetrero3";
            this.efosLetrero3.Size = new System.Drawing.Size(116, 15);
            this.efosLetrero3.TabIndex = 9;
            this.efosLetrero3.Text = "Codigo Paciente:";
            this.efosLetrero3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.CampoBD = null;
            this.txtCodigoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPaciente.Limpiar = true;
            this.txtCodigoPaciente.Location = new System.Drawing.Point(189, 82);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(100, 21);
            this.txtCodigoPaciente.SoloLectura = false;
            this.txtCodigoPaciente.TabIndex = 8;
            this.txtCodigoPaciente.Validated += new System.EventHandler(this.txtCodigoPaciente_Validated);
            // 
            // txtNumeroAsunto
            // 
            this.txtNumeroAsunto.CampoBD = null;
            this.txtNumeroAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroAsunto.Limpiar = true;
            this.txtNumeroAsunto.Location = new System.Drawing.Point(189, 39);
            this.txtNumeroAsunto.Name = "txtNumeroAsunto";
            this.txtNumeroAsunto.Size = new System.Drawing.Size(100, 21);
            this.txtNumeroAsunto.SoloLectura = false;
            this.txtNumeroAsunto.TabIndex = 7;
            // 
            // txtFechaAsunto
            // 
            this.txtFechaAsunto.CampoBD = null;
            this.txtFechaAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAsunto.Limpiar = true;
            this.txtFechaAsunto.Location = new System.Drawing.Point(523, 39);
            this.txtFechaAsunto.Name = "txtFechaAsunto";
            this.txtFechaAsunto.Size = new System.Drawing.Size(100, 21);
            this.txtFechaAsunto.SoloLectura = false;
            this.txtFechaAsunto.TabIndex = 6;
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(399, 42);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(117, 15);
            this.efosLetrero2.TabIndex = 5;
            this.efosLetrero2.Text = "Fecha de Asunto:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(22, 42);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(129, 15);
            this.efosLetrero1.TabIndex = 4;
            this.efosLetrero1.Text = "Numero de Asunto:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // botonSalir
            // 
            this.botonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.Image = ((System.Drawing.Image)(resources.GetObject("botonSalir.Image")));
            this.botonSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonSalir.Location = new System.Drawing.Point(562, 429);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 50);
            this.botonSalir.TabIndex = 3;
            this.botonSalir.Text = "&Salir";
            this.botonSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.efosButtonSalir1_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("botonBuscar.Image")));
            this.botonBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonBuscar.Location = new System.Drawing.Point(460, 429);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 50);
            this.botonBuscar.TabIndex = 2;
            this.botonBuscar.Text = "&Buscar";
            this.botonBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botonCancelar.Image")));
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonCancelar.Location = new System.Drawing.Point(352, 429);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 50);
            this.botonCancelar.TabIndex = 1;
            this.botonCancelar.Text = "&Cancelar";
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonProcesar
            // 
            this.botonProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonProcesar.Image = ((System.Drawing.Image)(resources.GetObject("botonProcesar.Image")));
            this.botonProcesar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonProcesar.Location = new System.Drawing.Point(250, 429);
            this.botonProcesar.Name = "botonProcesar";
            this.botonProcesar.Size = new System.Drawing.Size(75, 50);
            this.botonProcesar.TabIndex = 0;
            this.botonProcesar.Text = "&Procesar";
            this.botonProcesar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonProcesar.UseVisualStyleBackColor = true;
            this.botonProcesar.Click += new System.EventHandler(this.botonProcesar_Click);
            // 
            // efosGroupBoxPadre
            // 
            this.efosGroupBoxPadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBoxPadre.Location = new System.Drawing.Point(12, 21);
            this.efosGroupBoxPadre.Name = "efosGroupBoxPadre";
            this.efosGroupBoxPadre.Size = new System.Drawing.Size(677, 100);
            this.efosGroupBoxPadre.TabIndex = 15;
            this.efosGroupBoxPadre.TabStop = false;
            // 
            // FormBaseProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 507);
            this.Controls.Add(this.letreroNombrePaciente);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.lupaAsunto);
            this.Controls.Add(this.lupaPaciente);
            this.Controls.Add(this.efosLetrero3);
            this.Controls.Add(this.txtCodigoPaciente);
            this.Controls.Add(this.txtNumeroAsunto);
            this.Controls.Add(this.txtFechaAsunto);
            this.Controls.Add(this.efosLetrero2);
            this.Controls.Add(this.efosLetrero1);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonProcesar);
            this.Controls.Add(this.efosGroupBoxPadre);
            this.Name = "FormBaseProceso";
            this.Text = "FormBaseProceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ControlesEfos.efosButtonProcesar botonProcesar;
        public ControlesEfos.efosButtonCancelar botonCancelar;
        public ControlesEfos.efosButtonBuscar botonBuscar;
        public ControlesEfos.efosButtonSalir botonSalir;
        public ControlesEfos.efosButtonNuevo botonNuevo;
        public ControlesEfos.efosLetrero efosLetrero1;
        public ControlesEfos.efosLetrero efosLetrero2;
        public ControlesEfos.efosCampo txtFechaAsunto;
        public ControlesEfos.efosCampoCodigo txtNumeroAsunto;
        public ControlesEfos.efosCampo txtCodigoPaciente;
        public ControlesEfos.efosLetrero efosLetrero3;
        public ControlesEfos.efosButtonBuscador lupaPaciente;
        public ControlesEfos.efosButtonBuscador lupaAsunto;
        public ControlesEfos.efosLetrero letreroNombrePaciente;
        public ControlesEfos.efosGroupBox efosGroupBoxPadre;

    }
}