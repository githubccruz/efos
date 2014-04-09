namespace Efos
{
    partial class FormMantenimientoNacionalidad
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
            this.efosLetrero2.Location = new System.Drawing.Point(43, 153);
            // 
            // combo
            // 
            this.combo.CampoBD = "codipais";
            this.combo.Location = new System.Drawing.Point(153, 149);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = "descnaci";
            this.txtDescripcion.Location = new System.Drawing.Point(125, 8);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.Location = new System.Drawing.Point(43, 124);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(20, 232);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(212, 232);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(119, 232);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(307, 232);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(401, 232);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(497, 232);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CampoBD = "codinaci";
            // 
            // checkEstado
            // 
            this.checkEstado.CampoBD = "estado";
            this.checkEstado.Location = new System.Drawing.Point(153, 178);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(43, 182);
            // 
            // FormMantenimientoNacionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.campoCodigoCombo = "codipais";
            this.campoDescripcionCombo = "descpais";
            this.ClientSize = new System.Drawing.Size(590, 300);
            this.Name = "FormMantenimientoNacionalidad";
            this.TablaBD = "nacionalidad_encabezado";
            this.tablaCombo = "pais_encabezado";
            this.Text = "FormMantenimientoNacionalidad";
            this.efosPanel2.ResumeLayout(false);
            this.efosPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    }
}