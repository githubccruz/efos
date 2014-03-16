namespace Efos
{
    partial class FormMantenimientoSector
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
            // combo
            // 
            this.combo.CampoBD = "codiciud";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = "descsect";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CampoBD = "codisect";
            // 
            // checkEstado
            // 
            this.checkEstado.CampoBD = "estado";
            // 
            // FormMantenimientoSector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.campoCodigoCombo = "codiciud";
            this.campoDescripcionCombo = "descciud";
            this.ClientSize = new System.Drawing.Size(601, 297);
            this.Name = "FormMantenimientoSector";
            this.TablaBD = "sector_encabezado";
            this.tablaCombo = "ciudad_encabezado";
            this.Text = "FormMantenimientoSector";
            this.efosPanel2.ResumeLayout(false);
            this.efosPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}