namespace Efos
{
    partial class FormMantenimientoDoctor
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
            this.efosLetrero1 = new ControlesEfos.efosLetrero();
            this.efosCampo1 = new ControlesEfos.efosCampo();
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.efosLetrero3 = new ControlesEfos.efosLetrero();
            this.efosLetrero4 = new ControlesEfos.efosLetrero();
            this.efosLetrero5 = new ControlesEfos.efosLetrero();
            this.efosLetrero6 = new ControlesEfos.efosLetrero();
            this.efosLetrero11 = new ControlesEfos.efosLetrero();
            this.cmbTipoDoctor = new ControlesEfos.efosCombo();
            this.cmpExequeatur = new ControlesEfos.efosCampo();
            this.efosLetrero12 = new ControlesEfos.efosLetrero();
            this.tabPanel.SuspendLayout();
            this.tabDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Size = new System.Drawing.Size(730, 268);
            // 
            // tabDatosPersonales
            // 
            this.tabDatosPersonales.Controls.Add(this.efosLetrero12);
            this.tabDatosPersonales.Controls.Add(this.cmpExequeatur);
            this.tabDatosPersonales.Controls.Add(this.cmbTipoDoctor);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero11);
            this.tabDatosPersonales.Size = new System.Drawing.Size(722, 239);
            this.tabDatosPersonales.Controls.SetChildIndex(this.efosLetrero11, 0);
            this.tabDatosPersonales.Controls.SetChildIndex(this.cmbTipoDoctor, 0);
            this.tabDatosPersonales.Controls.SetChildIndex(this.cmpExequeatur, 0);
            this.tabDatosPersonales.Controls.SetChildIndex(this.efosLetrero12, 0);
            // 
            // efosPanel2
            // 
            this.efosPanel2.Location = new System.Drawing.Point(24, 479);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // checkEstado
            // 
            this.checkEstado.Location = new System.Drawing.Point(157, 483);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(47, 489);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(388, 520);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(578, 520);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(200, 520);
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(293, 520);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(101, 520);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(482, 520);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(287, 71);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(123, 15);
            this.efosLetrero1.TabIndex = 13;
            this.efosLetrero1.Text = "Segundo Nombre:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosCampo1
            // 
            this.efosCampo1.CampoBD = null;
            this.efosCampo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo1.Limpiar = true;
            this.efosCampo1.Location = new System.Drawing.Point(416, 68);
            this.efosCampo1.Name = "efosCampo1";
            this.efosCampo1.Size = new System.Drawing.Size(141, 21);
            this.efosCampo1.SoloLectura = false;
            this.efosCampo1.TabIndex = 14;
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(25, 180);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(123, 15);
            this.efosLetrero2.TabIndex = 15;
            this.efosLetrero2.Text = "Segundo Nombre:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.AutoSize = true;
            this.efosLetrero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero3.Location = new System.Drawing.Point(287, 173);
            this.efosLetrero3.Name = "efosLetrero3";
            this.efosLetrero3.Size = new System.Drawing.Size(85, 15);
            this.efosLetrero3.TabIndex = 16;
            this.efosLetrero3.Text = "Tipo Doctor:";
            this.efosLetrero3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero4
            // 
            this.efosLetrero4.AutoSize = true;
            this.efosLetrero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero4.Location = new System.Drawing.Point(30, 295);
            this.efosLetrero4.Name = "efosLetrero4";
            this.efosLetrero4.Size = new System.Drawing.Size(76, 15);
            this.efosLetrero4.TabIndex = 17;
            this.efosLetrero4.Text = "Exequatur:";
            this.efosLetrero4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero5
            // 
            this.efosLetrero5.AutoSize = true;
            this.efosLetrero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero5.Location = new System.Drawing.Point(287, 115);
            this.efosLetrero5.Name = "efosLetrero5";
            this.efosLetrero5.Size = new System.Drawing.Size(124, 15);
            this.efosLetrero5.TabIndex = 18;
            this.efosLetrero5.Text = "Segundo Apellido:";
            this.efosLetrero5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero6
            // 
            this.efosLetrero6.AutoSize = true;
            this.efosLetrero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero6.Location = new System.Drawing.Point(25, 71);
            this.efosLetrero6.Name = "efosLetrero6";
            this.efosLetrero6.Size = new System.Drawing.Size(110, 15);
            this.efosLetrero6.TabIndex = 19;
            this.efosLetrero6.Text = "Primer Apellido:";
            this.efosLetrero6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero11
            // 
            this.efosLetrero11.AutoSize = true;
            this.efosLetrero11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero11.Location = new System.Drawing.Point(344, 172);
            this.efosLetrero11.Name = "efosLetrero11";
            this.efosLetrero11.Size = new System.Drawing.Size(85, 15);
            this.efosLetrero11.TabIndex = 9;
            this.efosLetrero11.Text = "Tipo Doctor:";
            this.efosLetrero11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoDoctor
            // 
            this.cmbTipoDoctor.CampoBD = null;
            this.cmbTipoDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDoctor.FormattingEnabled = true;
            this.cmbTipoDoctor.Location = new System.Drawing.Point(467, 167);
            this.cmbTipoDoctor.Name = "cmbTipoDoctor";
            this.cmbTipoDoctor.Size = new System.Drawing.Size(199, 23);
            this.cmbTipoDoctor.Sorted = true;
            this.cmbTipoDoctor.TabIndex = 10;
            // 
            // cmpExequeatur
            // 
            this.cmpExequeatur.CampoBD = null;
            this.cmpExequeatur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpExequeatur.Limpiar = true;
            this.cmpExequeatur.Location = new System.Drawing.Point(130, 198);
            this.cmpExequeatur.Name = "cmpExequeatur";
            this.cmpExequeatur.Size = new System.Drawing.Size(199, 21);
            this.cmpExequeatur.SoloLectura = false;
            this.cmpExequeatur.TabIndex = 11;
            // 
            // efosLetrero12
            // 
            this.efosLetrero12.AutoSize = true;
            this.efosLetrero12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero12.Location = new System.Drawing.Point(22, 203);
            this.efosLetrero12.Name = "efosLetrero12";
            this.efosLetrero12.Size = new System.Drawing.Size(76, 15);
            this.efosLetrero12.TabIndex = 12;
            this.efosLetrero12.Text = "Exequatur:";
            this.efosLetrero12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMantenimientoDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 577);
            this.Name = "FormMantenimientoDoctor";
            this.Text = "FormMantenimientoDoctor";
            this.tabPanel.ResumeLayout(false);
            this.tabDatosPersonales.ResumeLayout(false);
            this.tabDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero6;
        private ControlesEfos.efosLetrero efosLetrero5;
        private ControlesEfos.efosLetrero efosLetrero4;
        private ControlesEfos.efosLetrero efosLetrero3;
        private ControlesEfos.efosLetrero efosLetrero2;
        private ControlesEfos.efosCampo efosCampo1;
        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosLetrero efosLetrero12;
        private ControlesEfos.efosCampo cmpExequeatur;
        private ControlesEfos.efosCombo cmbTipoDoctor;
        private ControlesEfos.efosLetrero efosLetrero11;
    }
}