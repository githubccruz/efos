namespace Efos
{
    partial class FormMantenimientoCuestionario
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
            this.cmpFechaCreacion = new ControlesEfos.efosCampo();
            this.efosLetrero1 = new ControlesEfos.efosLetrero();
            this.gridPreguntas = new ControlesEfos.efosDataGridView();
            this.ColumnaPregunta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaIncluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.cmbTipoCuestionario = new ControlesEfos.efosCombo();
            this.efosPanel1 = new ControlesEfos.efosPanel();
            this.efosPanel2 = new ControlesEfos.efosPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridPreguntas)).BeginInit();
            this.efosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // checkEstado
            // 
            this.checkEstado.Location = new System.Drawing.Point(153, 427);
            this.checkEstado.Size = new System.Drawing.Size(100, 26);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(43, 433);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(311, 475);
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(501, 475);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(123, 475);
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(216, 475);
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(24, 475);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(405, 475);
            // 
            // cmpFechaCreacion
            // 
            this.cmpFechaCreacion.CampoBD = null;
            this.cmpFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpFechaCreacion.Limpiar = true;
            this.cmpFechaCreacion.Location = new System.Drawing.Point(455, 78);
            this.cmpFechaCreacion.Name = "cmpFechaCreacion";
            this.cmpFechaCreacion.Size = new System.Drawing.Size(100, 21);
            this.cmpFechaCreacion.SoloLectura = false;
            this.cmpFechaCreacion.TabIndex = 16;
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(318, 81);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(111, 15);
            this.efosLetrero1.TabIndex = 17;
            this.efosLetrero1.Text = "Fecha Creacion:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridPreguntas
            // 
            this.gridPreguntas.AllowUserToAddRows = false;
            this.gridPreguntas.AllowUserToDeleteRows = false;
            this.gridPreguntas.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.gridPreguntas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPreguntas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridPreguntas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPreguntas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaPregunta,
            this.ColumnCodigo,
            this.ColumnaIncluir});
            this.gridPreguntas.Location = new System.Drawing.Point(15, 126);
            this.gridPreguntas.Name = "gridPreguntas";
            this.gridPreguntas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridPreguntas.Size = new System.Drawing.Size(573, 282);
            this.gridPreguntas.StandardTab = true;
            this.gridPreguntas.TabIndex = 18;
            // 
            // ColumnaPregunta
            // 
            this.ColumnaPregunta.HeaderText = "Pregunta";
            this.ColumnaPregunta.Name = "ColumnaPregunta";
            this.ColumnaPregunta.ReadOnly = true;
            this.ColumnaPregunta.Width = 479;
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Column1";
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.ReadOnly = true;
            this.ColumnCodigo.Visible = false;
            // 
            // ColumnaIncluir
            // 
            this.ColumnaIncluir.HeaderText = "Incluir";
            this.ColumnaIncluir.Name = "ColumnaIncluir";
            this.ColumnaIncluir.Width = 50;
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(246, 16);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(124, 15);
            this.efosLetrero2.TabIndex = 19;
            this.efosLetrero2.Text = "Tipo Cuestionario:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoCuestionario
            // 
            this.cmbTipoCuestionario.CampoBD = null;
            this.cmbTipoCuestionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCuestionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCuestionario.FormattingEnabled = true;
            this.cmbTipoCuestionario.Location = new System.Drawing.Point(387, 429);
            this.cmbTipoCuestionario.Name = "cmbTipoCuestionario";
            this.cmbTipoCuestionario.Size = new System.Drawing.Size(192, 23);
            this.cmbTipoCuestionario.Sorted = true;
            this.cmbTipoCuestionario.TabIndex = 20;
            // 
            // efosPanel1
            // 
            this.efosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel1.Controls.Add(this.efosLetrero2);
            this.efosPanel1.Location = new System.Drawing.Point(12, 415);
            this.efosPanel1.Name = "efosPanel1";
            this.efosPanel1.Size = new System.Drawing.Size(577, 54);
            this.efosPanel1.TabIndex = 21;
            // 
            // efosPanel2
            // 
            this.efosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel2.Location = new System.Drawing.Point(12, 60);
            this.efosPanel2.Name = "efosPanel2";
            this.efosPanel2.Size = new System.Drawing.Size(577, 60);
            this.efosPanel2.TabIndex = 22;
            // 
            // FormMantenimientoCuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 537);
            this.Controls.Add(this.cmbTipoCuestionario);
            this.Controls.Add(this.gridPreguntas);
            this.Controls.Add(this.efosLetrero1);
            this.Controls.Add(this.cmpFechaCreacion);
            this.Controls.Add(this.efosPanel1);
            this.Controls.Add(this.efosPanel2);
            this.Name = "FormMantenimientoCuestionario";
            this.Text = "Mantenimiento de Cuestionario";
            this.Controls.SetChildIndex(this.efosPanel2, 0);
            this.Controls.SetChildIndex(this.efosPanel1, 0);
            this.Controls.SetChildIndex(this.cmpFechaCreacion, 0);
            this.Controls.SetChildIndex(this.efosLetrero1, 0);
            this.Controls.SetChildIndex(this.gridPreguntas, 0);
            this.Controls.SetChildIndex(this.cmbTipoCuestionario, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridPreguntas)).EndInit();
            this.efosPanel1.ResumeLayout(false);
            this.efosPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosCampo cmpFechaCreacion;
        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosDataGridView gridPreguntas;
        private ControlesEfos.efosLetrero efosLetrero2;
        private ControlesEfos.efosCombo cmbTipoCuestionario;
        private ControlesEfos.efosPanel efosPanel1;
        private ControlesEfos.efosPanel efosPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaPregunta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnaIncluir;
    }
}