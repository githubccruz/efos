namespace Efos
{
    partial class FormMantenimientoCiudad
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
            this.efosLetrero2.Size = new System.Drawing.Size(70, 15);
            this.efosLetrero2.Text = "Provincia:";
            // 
            // combo
            // 
            this.combo.CampoBD = "codiprov";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = "descciud";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CampoBD = "codiciud";
            // 
            // checkEstado
            // 
            this.checkEstado.CampoBD = "estado";
            // 
            // FormMantenimientoCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.campoCodigoCombo = "codiprov";
            this.campoDescripcionCombo = "descprov";
            this.ClientSize = new System.Drawing.Size(601, 295);
            this.Name = "FormMantenimientoCiudad";
            this.TablaBD = "ciudad_encabezado";
            this.tablaCombo = "provincia_encabezado";
            this.Text = "FormMantenimientoCiudad";
            this.efosPanel2.ResumeLayout(false);
            this.efosPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}