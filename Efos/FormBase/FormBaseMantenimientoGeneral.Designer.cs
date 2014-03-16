namespace Efos
{
    partial class FormBaseMantenimientoGeneral
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
            this.lblDescripcion = new ControlesEfos.efosLetrero();
            this.txtDescripcion = new ControlesEfos.efosCampo();
            this.efosPanel1 = new ControlesEfos.efosPanel();
            this.efosPanel2 = new ControlesEfos.efosPanel();
            this.SuspendLayout();
            // 
            // textTitulo
            // 
            this.textTitulo.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.TabIndex = 11;
            this.botonBuscarLupa.Click += new System.EventHandler(this.botonBuscarLupa_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.TabIndex = 1;
            // 
            // checkEstado
            // 
            this.checkEstado.Location = new System.Drawing.Point(153, 158);
            this.checkEstado.TabIndex = 4;
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(43, 164);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(307, 203);
            this.botonCancelar.TabIndex = 8;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(497, 203);
            this.botonSalir.TabIndex = 10;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(119, 203);
            this.botonGuardar.TabIndex = 6;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(212, 203);
            this.botonEditar.TabIndex = 7;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(20, 203);
            this.botonNuevo.TabIndex = 5;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click_1);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(401, 203);
            this.botonBuscar.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(43, 133);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 15);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Descripcion:";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = null;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(153, 126);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(309, 21);
            this.txtDescripcion.SoloLectura = false;
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Validated += new System.EventHandler(this.txtDescripcion_Validated);
            // 
            // efosPanel1
            // 
            this.efosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel1.Location = new System.Drawing.Point(20, 67);
            this.efosPanel1.Name = "efosPanel1";
            this.efosPanel1.Size = new System.Drawing.Size(552, 43);
            this.efosPanel1.TabIndex = 17;
            // 
            // efosPanel2
            // 
            this.efosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel2.Location = new System.Drawing.Point(20, 116);
            this.efosPanel2.Name = "efosPanel2";
            this.efosPanel2.Size = new System.Drawing.Size(552, 77);
            this.efosPanel2.TabIndex = 18;
            // 
            // FormBaseMantenimientoGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(585, 266);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.efosPanel1);
            this.Controls.Add(this.efosPanel2);
            this.Name = "FormBaseMantenimientoGeneral";
            this.Text = "FormBaseMantenimientoTipo";
            this.Load += new System.EventHandler(this.FormBaseMantenimientoGeneral_Load);
            this.Controls.SetChildIndex(this.efosPanel2, 0);
            this.Controls.SetChildIndex(this.efosPanel1, 0);
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
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero lblDescripcion;
        public ControlesEfos.efosCampo txtDescripcion;
        private ControlesEfos.efosPanel efosPanel1;
        public ControlesEfos.efosPanel efosPanel2;

    }
}