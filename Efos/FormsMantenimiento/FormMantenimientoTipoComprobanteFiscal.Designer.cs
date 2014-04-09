namespace Efos.FormMantenimiento
{
    partial class FormMantenimientoTipoComprobanteFiscal
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
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = "desctico";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CampoBD = "coditico";
            // 
            // checkEstado
            // 
            this.checkEstado.CampoBD = "estado";
            // 
            // FormMantenimientoTipoComprobanteFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 266);
            this.Name = "FormMantenimientoTipoComprobanteFiscal";
            this.TablaBD = "tipo_comprobante_fiscal_encabezado";
            this.Text = "FormMantenimientoTipoComprobanteFiscal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}