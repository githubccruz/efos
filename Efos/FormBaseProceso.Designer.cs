﻿namespace Efos
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
            this.botonProcesar = new ControlesEfos.efosButtonProcesar();
            this.botonCancelar = new ControlesEfos.efosButtonCancelar();
            this.botonBuscar = new ControlesEfos.efosButtonBuscar();
            this.botonSalir = new ControlesEfos.efosButtonSalir();
            this.efosLetrero1 = new ControlesEfos.efosLetrero();
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.txtFechaAsunto = new ControlesEfos.efosCampo();
            this.txtNumeroAsunto = new ControlesEfos.efosCampoCodigo();
            this.txtCodigoPaciente = new ControlesEfos.efosCampo();
            this.efosLetrero3 = new ControlesEfos.efosLetrero();
            this.letreroPersona = new ControlesEfos.efosLetrero();
            this.lupaPaciente = new ControlesEfos.efosButtonBuscador();
            this.lupaAsunto = new ControlesEfos.efosButtonBuscador();
            this.botonNuevo = new ControlesEfos.efosButtonNuevo();
            this.SuspendLayout();
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
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(36, 47);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(129, 15);
            this.efosLetrero1.TabIndex = 4;
            this.efosLetrero1.Text = "Numero de Asunto:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(413, 47);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(117, 15);
            this.efosLetrero2.TabIndex = 5;
            this.efosLetrero2.Text = "Fecha de Asunto:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFechaAsunto
            // 
            this.txtFechaAsunto.CampoBD = null;
            this.txtFechaAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaAsunto.Limpiar = true;
            this.txtFechaAsunto.Location = new System.Drawing.Point(537, 44);
            this.txtFechaAsunto.Name = "txtFechaAsunto";
            this.txtFechaAsunto.Size = new System.Drawing.Size(100, 21);
            this.txtFechaAsunto.SoloLectura = false;
            this.txtFechaAsunto.TabIndex = 6;
            // 
            // txtNumeroAsunto
            // 
            this.txtNumeroAsunto.CampoBD = null;
            this.txtNumeroAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroAsunto.Limpiar = true;
            this.txtNumeroAsunto.Location = new System.Drawing.Point(203, 44);
            this.txtNumeroAsunto.Name = "txtNumeroAsunto";
            this.txtNumeroAsunto.Size = new System.Drawing.Size(100, 21);
            this.txtNumeroAsunto.SoloLectura = false;
            this.txtNumeroAsunto.TabIndex = 7;
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.CampoBD = null;
            this.txtCodigoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPaciente.Limpiar = true;
            this.txtCodigoPaciente.Location = new System.Drawing.Point(203, 87);
            this.txtCodigoPaciente.Name = "txtCodigoPaciente";
            this.txtCodigoPaciente.Size = new System.Drawing.Size(100, 21);
            this.txtCodigoPaciente.SoloLectura = false;
            this.txtCodigoPaciente.TabIndex = 8;
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.AutoSize = true;
            this.efosLetrero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero3.Location = new System.Drawing.Point(36, 90);
            this.efosLetrero3.Name = "efosLetrero3";
            this.efosLetrero3.Size = new System.Drawing.Size(116, 15);
            this.efosLetrero3.TabIndex = 9;
            this.efosLetrero3.Text = "Codigo Paciente:";
            this.efosLetrero3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // letreroPersona
            // 
            this.letreroPersona.AutoSize = true;
            this.letreroPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroPersona.Location = new System.Drawing.Point(310, 90);
            this.letreroPersona.Name = "letreroPersona";
            this.letreroPersona.Size = new System.Drawing.Size(148, 15);
            this.letreroPersona.TabIndex = 10;
            this.letreroPersona.Text = "nombre de la persona";
            this.letreroPersona.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lupaPaciente
            // 
            this.lupaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lupaPaciente.Image = ((System.Drawing.Image)(resources.GetObject("lupaPaciente.Image")));
            this.lupaPaciente.Location = new System.Drawing.Point(167, 82);
            this.lupaPaciente.Name = "lupaPaciente";
            this.lupaPaciente.Size = new System.Drawing.Size(35, 30);
            this.lupaPaciente.TabIndex = 11;
            this.lupaPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lupaPaciente.UseVisualStyleBackColor = true;
            // 
            // lupaAsunto
            // 
            this.lupaAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lupaAsunto.Image = ((System.Drawing.Image)(resources.GetObject("lupaAsunto.Image")));
            this.lupaAsunto.Location = new System.Drawing.Point(167, 39);
            this.lupaAsunto.Name = "lupaAsunto";
            this.lupaAsunto.Size = new System.Drawing.Size(35, 30);
            this.lupaAsunto.TabIndex = 12;
            this.lupaAsunto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lupaAsunto.UseVisualStyleBackColor = true;
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
            // FormBaseProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 507);
            this.Controls.Add(this.botonNuevo);
            this.Controls.Add(this.lupaAsunto);
            this.Controls.Add(this.lupaPaciente);
            this.Controls.Add(this.letreroPersona);
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
            this.Name = "FormBaseProceso";
            this.Text = "FormBaseProceso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosButtonProcesar botonProcesar;
        private ControlesEfos.efosButtonCancelar botonCancelar;
        private ControlesEfos.efosButtonBuscar botonBuscar;
        private ControlesEfos.efosButtonSalir botonSalir;
        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosLetrero efosLetrero2;
        private ControlesEfos.efosCampo txtFechaAsunto;
        private ControlesEfos.efosCampoCodigo txtNumeroAsunto;
        private ControlesEfos.efosCampo txtCodigoPaciente;
        private ControlesEfos.efosLetrero efosLetrero3;
        private ControlesEfos.efosLetrero letreroPersona;
        private ControlesEfos.efosButtonBuscador lupaPaciente;
        private ControlesEfos.efosButtonBuscador lupaAsunto;
        private ControlesEfos.efosButtonNuevo botonNuevo;

    }
}