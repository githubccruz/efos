namespace Efos
{
    partial class FormMantenimientoInsumo
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
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.txtDescripcion = new ControlesEfos.efosCampo();
            this.txtCosto = new ControlesEfos.efosCampo();
            this.efosPanel1 = new ControlesEfos.efosPanel();
            this.efosPanel2 = new ControlesEfos.efosPanel();
            this.txtExistencia = new ControlesEfos.efosCampo();
            this.efosLetrero3 = new ControlesEfos.efosLetrero();
            this.efosPanel3 = new ControlesEfos.efosPanel();
            this.efosPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.CampoBD = "codiinsu";
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Location = new System.Drawing.Point(49, 81);
            // 
            // checkEstado
            // 
            this.checkEstado.CampoBD = "estado";
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(49, 237);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(314, 276);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(504, 276);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(126, 276);
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(219, 276);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(27, 276);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(408, 276);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(49, 130);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(87, 15);
            this.efosLetrero1.TabIndex = 16;
            this.efosLetrero1.Text = "Descripcion:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(49, 177);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(47, 15);
            this.efosLetrero2.TabIndex = 17;
            this.efosLetrero2.Text = "Costo:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = "descinsu";
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(153, 130);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(236, 21);
            this.txtDescripcion.SoloLectura = false;
            this.txtDescripcion.TabIndex = 18;
            // 
            // txtCosto
            // 
            this.txtCosto.CampoBD = "costinsu";
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Limpiar = true;
            this.txtCosto.Location = new System.Drawing.Point(153, 174);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 21);
            this.txtCosto.SoloLectura = false;
            this.txtCosto.TabIndex = 19;
            // 
            // efosPanel1
            // 
            this.efosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel1.Location = new System.Drawing.Point(27, 60);
            this.efosPanel1.Name = "efosPanel1";
            this.efosPanel1.Size = new System.Drawing.Size(552, 51);
            this.efosPanel1.TabIndex = 20;
            // 
            // efosPanel2
            // 
            this.efosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel2.Controls.Add(this.txtExistencia);
            this.efosPanel2.Controls.Add(this.efosLetrero3);
            this.efosPanel2.Location = new System.Drawing.Point(26, 118);
            this.efosPanel2.Name = "efosPanel2";
            this.efosPanel2.Size = new System.Drawing.Size(553, 91);
            this.efosPanel2.TabIndex = 21;
            // 
            // txtExistencia
            // 
            this.txtExistencia.CampoBD = "exisinsu";
            this.txtExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExistencia.Limpiar = true;
            this.txtExistencia.Location = new System.Drawing.Point(366, 54);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(100, 21);
            this.txtExistencia.SoloLectura = false;
            this.txtExistencia.TabIndex = 1;
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.AutoSize = true;
            this.efosLetrero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero3.Location = new System.Drawing.Point(271, 57);
            this.efosLetrero3.Name = "efosLetrero3";
            this.efosLetrero3.Size = new System.Drawing.Size(77, 15);
            this.efosLetrero3.TabIndex = 0;
            this.efosLetrero3.Text = "Existencia:";
            this.efosLetrero3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosPanel3
            // 
            this.efosPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel3.Location = new System.Drawing.Point(27, 216);
            this.efosPanel3.Name = "efosPanel3";
            this.efosPanel3.Size = new System.Drawing.Size(552, 51);
            this.efosPanel3.TabIndex = 22;
            // 
            // FormMantenimientoInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 335);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.efosLetrero2);
            this.Controls.Add(this.efosLetrero1);
            this.Controls.Add(this.efosPanel1);
            this.Controls.Add(this.efosPanel2);
            this.Controls.Add(this.efosPanel3);
            this.Name = "FormMantenimientoInsumo";
            this.TablaBD = "insumo_encabezado";
            this.Text = "FormMantenimientoInsumo";
            this.Controls.SetChildIndex(this.efosPanel3, 0);
            this.Controls.SetChildIndex(this.efosPanel2, 0);
            this.Controls.SetChildIndex(this.efosPanel1, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.botonBuscarLupa, 0);
            this.Controls.SetChildIndex(this.botonCancelar, 0);
            this.Controls.SetChildIndex(this.botonSalir, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.botonGuardar, 0);
            this.Controls.SetChildIndex(this.textTitulo, 0);
            this.Controls.SetChildIndex(this.botonEditar, 0);
            this.Controls.SetChildIndex(this.labelEstado, 0);
            this.Controls.SetChildIndex(this.botonNuevo, 0);
            this.Controls.SetChildIndex(this.checkEstado, 0);
            this.Controls.SetChildIndex(this.botonBuscar, 0);
            this.Controls.SetChildIndex(this.efosLetrero1, 0);
            this.Controls.SetChildIndex(this.efosLetrero2, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.Controls.SetChildIndex(this.txtCosto, 0);
            this.efosPanel2.ResumeLayout(false);
            this.efosPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosLetrero efosLetrero2;
        private ControlesEfos.efosCampo txtDescripcion;
        private ControlesEfos.efosCampo txtCosto;
        private ControlesEfos.efosPanel efosPanel1;
        private ControlesEfos.efosPanel efosPanel2;
        private ControlesEfos.efosPanel efosPanel3;
        private ControlesEfos.efosCampo txtExistencia;
        private ControlesEfos.efosLetrero efosLetrero3;
    }
}