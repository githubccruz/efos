namespace Efos
{
    partial class FormMantenimientoServicio
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
            this.campoFechaCreacion = new ControlesEfos.efosCampo();
            this.dataGridPrecioServicio = new ControlesEfos.efosDataGridView();
            this.columnaTipoPrecioServicio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnaPrecioServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBotonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.campoDescripcion = new ControlesEfos.efosCampo();
            this.comboTipoServicio = new ControlesEfos.efosCombo();
            this.efosLetrero3 = new ControlesEfos.efosLetrero();
            this.efosLetrero4 = new ControlesEfos.efosLetrero();
            this.campoCostoServicio = new ControlesEfos.efosCampo();
            this.efosPanel1 = new ControlesEfos.efosPanel();
            this.efosPanel2 = new ControlesEfos.efosPanel();
            this.efosPanel3 = new ControlesEfos.efosPanel();
            this.efosPanel4 = new ControlesEfos.efosPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrecioServicio)).BeginInit();
            this.efosPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(12, 9);
            this.textTitulo.Text = "Mantenimiento de Servicio";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(138, 79);
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.Location = new System.Drawing.Point(243, 73);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Location = new System.Drawing.Point(28, 82);
            // 
            // checkEstado
            // 
            this.checkEstado.Location = new System.Drawing.Point(138, 384);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(28, 390);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(299, 435);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(489, 435);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(111, 435);
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(204, 435);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(12, 435);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(393, 435);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(303, 82);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(111, 15);
            this.efosLetrero1.TabIndex = 16;
            this.efosLetrero1.Text = "Fecha Creacion:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoFechaCreacion
            // 
            this.campoFechaCreacion.CampoBD = null;
            this.campoFechaCreacion.Enabled = false;
            this.campoFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFechaCreacion.Limpiar = true;
            this.campoFechaCreacion.Location = new System.Drawing.Point(421, 79);
            this.campoFechaCreacion.Name = "campoFechaCreacion";
            this.campoFechaCreacion.Size = new System.Drawing.Size(100, 21);
            this.campoFechaCreacion.SoloLectura = false;
            this.campoFechaCreacion.TabIndex = 17;
            // 
            // dataGridPrecioServicio
            // 
            this.dataGridPrecioServicio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridPrecioServicio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridPrecioServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridPrecioServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrecioServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaTipoPrecioServicio,
            this.columnaPrecioServicio,
            this.columnaBotonEliminar});
            this.dataGridPrecioServicio.Location = new System.Drawing.Point(78, 3);
            this.dataGridPrecioServicio.Name = "dataGridPrecioServicio";
            this.dataGridPrecioServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridPrecioServicio.Size = new System.Drawing.Size(398, 150);
            this.dataGridPrecioServicio.StandardTab = true;
            this.dataGridPrecioServicio.TabIndex = 18;
            this.dataGridPrecioServicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.efosDataGridView1_CellClick);
            // 
            // columnaTipoPrecioServicio
            // 
            this.columnaTipoPrecioServicio.HeaderText = "Tipo Precio";
            this.columnaTipoPrecioServicio.Name = "columnaTipoPrecioServicio";
            this.columnaTipoPrecioServicio.Width = 200;
            // 
            // columnaPrecioServicio
            // 
            this.columnaPrecioServicio.HeaderText = "Precio Servicio";
            this.columnaPrecioServicio.Name = "columnaPrecioServicio";
            // 
            // columnaBotonEliminar
            // 
            this.columnaBotonEliminar.HeaderText = "Eliminar";
            this.columnaBotonEliminar.Name = "columnaBotonEliminar";
            this.columnaBotonEliminar.Text = "Eliminar";
            this.columnaBotonEliminar.ToolTipText = "Eliminar";
            this.columnaBotonEliminar.UseColumnTextForButtonValue = true;
            this.columnaBotonEliminar.Width = 50;
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(31, 139);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(87, 15);
            this.efosLetrero2.TabIndex = 19;
            this.efosLetrero2.Text = "Descripcion:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoDescripcion
            // 
            this.campoDescripcion.CampoBD = null;
            this.campoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescripcion.Limpiar = true;
            this.campoDescripcion.Location = new System.Drawing.Point(138, 132);
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(383, 21);
            this.campoDescripcion.SoloLectura = false;
            this.campoDescripcion.TabIndex = 20;
            this.campoDescripcion.Validated += new System.EventHandler(this.campoDescripcion_Validated);
            // 
            // comboTipoServicio
            // 
            this.comboTipoServicio.CampoBD = null;
            this.comboTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoServicio.FormattingEnabled = true;
            this.comboTipoServicio.Location = new System.Drawing.Point(138, 165);
            this.comboTipoServicio.Name = "comboTipoServicio";
            this.comboTipoServicio.Size = new System.Drawing.Size(224, 23);
            this.comboTipoServicio.Sorted = true;
            this.comboTipoServicio.TabIndex = 21;
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.AutoSize = true;
            this.efosLetrero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero3.Location = new System.Drawing.Point(31, 169);
            this.efosLetrero3.Name = "efosLetrero3";
            this.efosLetrero3.Size = new System.Drawing.Size(39, 15);
            this.efosLetrero3.TabIndex = 22;
            this.efosLetrero3.Text = "Tipo:";
            this.efosLetrero3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero4
            // 
            this.efosLetrero4.AutoSize = true;
            this.efosLetrero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero4.Location = new System.Drawing.Point(368, 169);
            this.efosLetrero4.Name = "efosLetrero4";
            this.efosLetrero4.Size = new System.Drawing.Size(47, 15);
            this.efosLetrero4.TabIndex = 23;
            this.efosLetrero4.Text = "Costo:";
            this.efosLetrero4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoCostoServicio
            // 
            this.campoCostoServicio.CampoBD = null;
            this.campoCostoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCostoServicio.Limpiar = true;
            this.campoCostoServicio.Location = new System.Drawing.Point(421, 166);
            this.campoCostoServicio.Name = "campoCostoServicio";
            this.campoCostoServicio.Size = new System.Drawing.Size(100, 21);
            this.campoCostoServicio.SoloLectura = false;
            this.campoCostoServicio.TabIndex = 24;
            // 
            // efosPanel1
            // 
            this.efosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel1.Location = new System.Drawing.Point(13, 61);
            this.efosPanel1.Name = "efosPanel1";
            this.efosPanel1.Size = new System.Drawing.Size(551, 52);
            this.efosPanel1.TabIndex = 25;
            // 
            // efosPanel2
            // 
            this.efosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel2.Location = new System.Drawing.Point(12, 120);
            this.efosPanel2.Name = "efosPanel2";
            this.efosPanel2.Size = new System.Drawing.Size(552, 80);
            this.efosPanel2.TabIndex = 26;
            // 
            // efosPanel3
            // 
            this.efosPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel3.Controls.Add(this.dataGridPrecioServicio);
            this.efosPanel3.Location = new System.Drawing.Point(13, 205);
            this.efosPanel3.Name = "efosPanel3";
            this.efosPanel3.Size = new System.Drawing.Size(551, 164);
            this.efosPanel3.TabIndex = 27;
            // 
            // efosPanel4
            // 
            this.efosPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel4.Location = new System.Drawing.Point(13, 374);
            this.efosPanel4.Name = "efosPanel4";
            this.efosPanel4.Size = new System.Drawing.Size(551, 45);
            this.efosPanel4.TabIndex = 28;
            // 
            // FormMantenimientoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 493);
            this.Controls.Add(this.campoCostoServicio);
            this.Controls.Add(this.efosLetrero4);
            this.Controls.Add(this.efosLetrero3);
            this.Controls.Add(this.comboTipoServicio);
            this.Controls.Add(this.campoDescripcion);
            this.Controls.Add(this.efosLetrero2);
            this.Controls.Add(this.campoFechaCreacion);
            this.Controls.Add(this.efosLetrero1);
            this.Controls.Add(this.efosPanel1);
            this.Controls.Add(this.efosPanel2);
            this.Controls.Add(this.efosPanel3);
            this.Controls.Add(this.efosPanel4);
            this.Name = "FormMantenimientoServicio";
            this.Text = "Mantenimiento de Servicio";
            this.Controls.SetChildIndex(this.efosPanel4, 0);
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
            this.Controls.SetChildIndex(this.campoFechaCreacion, 0);
            this.Controls.SetChildIndex(this.efosLetrero2, 0);
            this.Controls.SetChildIndex(this.campoDescripcion, 0);
            this.Controls.SetChildIndex(this.comboTipoServicio, 0);
            this.Controls.SetChildIndex(this.efosLetrero3, 0);
            this.Controls.SetChildIndex(this.efosLetrero4, 0);
            this.Controls.SetChildIndex(this.campoCostoServicio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrecioServicio)).EndInit();
            this.efosPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosCampo campoFechaCreacion;
        private ControlesEfos.efosDataGridView dataGridPrecioServicio;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnaTipoPrecioServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecioServicio;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonEliminar;
        private ControlesEfos.efosLetrero efosLetrero2;
        private ControlesEfos.efosCampo campoDescripcion;
        private ControlesEfos.efosCombo comboTipoServicio;
        private ControlesEfos.efosLetrero efosLetrero3;
        private ControlesEfos.efosLetrero efosLetrero4;
        private ControlesEfos.efosCampo campoCostoServicio;
        private ControlesEfos.efosPanel efosPanel1;
        private ControlesEfos.efosPanel efosPanel2;
        private ControlesEfos.efosPanel efosPanel3;
        private ControlesEfos.efosPanel efosPanel4;
    }
}