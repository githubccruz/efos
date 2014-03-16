namespace Efos
{
    partial class FormProcesoOrdenTrabajo
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
            this.checkEstado = new ControlesEfos.efosCheck();
            this.efosLetrero4 = new ControlesEfos.efosLetrero();
            this.SuspendLayout();
            // 
            // checkEstado
            // 
            this.checkEstado.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkEstado.CampoBD = null;
            this.checkEstado.Checked = true;
            this.checkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstado.ForeColor = System.Drawing.Color.Blue;
            this.checkEstado.Location = new System.Drawing.Point(203, 393);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(100, 26);
            this.checkEstado.TabIndex = 14;
            this.checkEstado.Text = "Activar";
            this.checkEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // efosLetrero4
            // 
            this.efosLetrero4.AutoSize = true;
            this.efosLetrero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero4.Location = new System.Drawing.Point(39, 399);
            this.efosLetrero4.Name = "efosLetrero4";
            this.efosLetrero4.Size = new System.Drawing.Size(55, 15);
            this.efosLetrero4.TabIndex = 13;
            this.efosLetrero4.Text = "Estado:";
            this.efosLetrero4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormProcesoOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 507);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.efosLetrero4);
            this.Name = "FormProcesoOrdenTrabajo";
            this.Text = "FormProcesoOrdenTrabajo";
            this.Controls.SetChildIndex(this.efosLetrero4, 0);
            this.Controls.SetChildIndex(this.checkEstado, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero4;
        private ControlesEfos.efosCheck checkEstado;

    }
}