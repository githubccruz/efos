namespace Efos
{
    partial class FormMantenimientoProvincia
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
            this.efosPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.Size = new System.Drawing.Size(39, 15);
            this.efosLetrero2.Text = "Pais:";
            // 
            // combo
            // 
            this.combo.CampoBD = "codipais";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = "descprov";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CampoBD = "codiprov";
            // 
            // checkEstado
            // 
            this.checkEstado.CampoBD = "estado";
            // 
            // FormMantenimientoProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.campoCodigoCombo = "codipais";
            this.campoDescripcionCombo = "descpais";
            this.ClientSize = new System.Drawing.Size(601, 297);
            this.Name = "FormMantenimientoProvincia";
            this.TablaBD = "provincia_encabezado";
            this.tablaCombo = "pais_encabezado";
            this.Text = "FormMantenimientoProvincia";
            this.efosPanel2.ResumeLayout(false);
            this.efosPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}