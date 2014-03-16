namespace Efos
{
    partial class FormBaseMantenimientoRegion
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
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.efosLetrero1 = new ControlesEfos.efosLetrero();
            this.combo = new ControlesEfos.efosCombo();
            this.efosPanel2 = new ControlesEfos.efosPanel();
            this.txtDescripcion = new ControlesEfos.efosCampo();
            this.efosPanel1 = new ControlesEfos.efosPanel();
            this.efosPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(20, 231);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(212, 231);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(119, 231);
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(307, 231);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(401, 231);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(497, 231);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(153, 75);
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.Location = new System.Drawing.Point(258, 69);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Location = new System.Drawing.Point(43, 78);
            // 
            // checkEstado
            // 
            this.checkEstado.Location = new System.Drawing.Point(153, 184);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(43, 190);
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(43, 161);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(56, 15);
            this.efosLetrero2.TabIndex = 22;
            this.efosLetrero2.Text = "Combo:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(43, 128);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(87, 15);
            this.efosLetrero1.TabIndex = 20;
            this.efosLetrero1.Text = "Descripcion:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // combo
            // 
            this.combo.CampoBD = "";
            this.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.FormattingEnabled = true;
            this.combo.Location = new System.Drawing.Point(153, 155);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(204, 23);
            this.combo.Sorted = true;
            this.combo.TabIndex = 21;
            // 
            // efosPanel2
            // 
            this.efosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel2.Controls.Add(this.txtDescripcion);
            this.efosPanel2.Location = new System.Drawing.Point(26, 110);
            this.efosPanel2.Name = "efosPanel2";
            this.efosPanel2.Size = new System.Drawing.Size(552, 106);
            this.efosPanel2.TabIndex = 24;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = "";
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(125, 13);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(204, 21);
            this.txtDescripcion.SoloLectura = false;
            this.txtDescripcion.TabIndex = 19;
            // 
            // efosPanel1
            // 
            this.efosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel1.Location = new System.Drawing.Point(26, 60);
            this.efosPanel1.Name = "efosPanel1";
            this.efosPanel1.Size = new System.Drawing.Size(552, 51);
            this.efosPanel1.TabIndex = 25;
            // 
            // FormBaseMantenimientoRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 297);
            this.Controls.Add(this.efosLetrero2);
            this.Controls.Add(this.efosLetrero1);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.efosPanel2);
            this.Controls.Add(this.efosPanel1);
            this.Name = "FormBaseMantenimientoRegion";
            this.Text = "FormBaseMantenimientoRegion";
            this.Controls.SetChildIndex(this.efosPanel1, 0);
            this.Controls.SetChildIndex(this.efosPanel2, 0);
            this.Controls.SetChildIndex(this.botonNuevo, 0);
            this.Controls.SetChildIndex(this.botonEditar, 0);
            this.Controls.SetChildIndex(this.botonGuardar, 0);
            this.Controls.SetChildIndex(this.botonCancelar, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.botonBuscar, 0);
            this.Controls.SetChildIndex(this.botonBuscarLupa, 0);
            this.Controls.SetChildIndex(this.botonSalir, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.textTitulo, 0);
            this.Controls.SetChildIndex(this.labelEstado, 0);
            this.Controls.SetChildIndex(this.checkEstado, 0);
            this.Controls.SetChildIndex(this.combo, 0);
            this.Controls.SetChildIndex(this.efosLetrero1, 0);
            this.Controls.SetChildIndex(this.efosLetrero2, 0);
            this.efosPanel2.ResumeLayout(false);
            this.efosPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ControlesEfos.efosLetrero efosLetrero2;
        public ControlesEfos.efosCombo combo;
        public ControlesEfos.efosPanel efosPanel2;
        public ControlesEfos.efosCampo txtDescripcion;
        public ControlesEfos.efosPanel efosPanel1;
        public ControlesEfos.efosLetrero efosLetrero1;
    }
}