namespace Efos
{
    partial class FormMantenimientoPaciente
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
            this.efosLetrero11 = new ControlesEfos.efosLetrero();
            this.cmbTipoPaciente = new ControlesEfos.efosCombo();
            this.tabPanel.SuspendLayout();
            this.tabDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDatosPersonales
            // 
            this.tabDatosPersonales.Controls.Add(this.cmbTipoPaciente);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero11);
            this.tabDatosPersonales.Controls.SetChildIndex(this.efosLetrero11, 0);
            this.tabDatosPersonales.Controls.SetChildIndex(this.cmbTipoPaciente, 0);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.Click += new System.EventHandler(this.botonBuscarLupa_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // efosLetrero11
            // 
            this.efosLetrero11.AutoSize = true;
            this.efosLetrero11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero11.Location = new System.Drawing.Point(341, 169);
            this.efosLetrero11.Name = "efosLetrero11";
            this.efosLetrero11.Size = new System.Drawing.Size(99, 15);
            this.efosLetrero11.TabIndex = 9;
            this.efosLetrero11.Text = "Tipo Paciente:";
            this.efosLetrero11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoPaciente
            // 
            this.cmbTipoPaciente.CampoBD = null;
            this.cmbTipoPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoPaciente.FormattingEnabled = true;
            this.cmbTipoPaciente.Location = new System.Drawing.Point(467, 165);
            this.cmbTipoPaciente.Name = "cmbTipoPaciente";
            this.cmbTipoPaciente.Size = new System.Drawing.Size(199, 23);
            this.cmbTipoPaciente.Sorted = true;
            this.cmbTipoPaciente.TabIndex = 10;
            // 
            // FormMantenimientoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 530);
            this.Name = "FormMantenimientoPaciente";
            this.Text = "FormMantenimientoPaciente";
            this.tabPanel.ResumeLayout(false);
            this.tabDatosPersonales.ResumeLayout(false);
            this.tabDatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosCombo cmbTipoPaciente;
        private ControlesEfos.efosLetrero efosLetrero11;

    }
}