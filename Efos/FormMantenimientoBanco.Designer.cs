namespace Efos
{
    partial class FormMantenimientoBanco
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
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.Click += new System.EventHandler(this.botonBuscarLupa_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // FormMantenimientoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 263);
            this.Name = "FormMantenimientoBanco";
            this.Text = "FormMantenimientoBanco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



    }
}