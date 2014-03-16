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
            this.efosTabControl1 = new ControlesEfos.efosTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridInsumo = new ControlesEfos.efosDataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.efosPanel4 = new ControlesEfos.efosPanel();
            this.columnaInsumo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBotonEliminarInsumo = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrecioServicio)).BeginInit();
            this.efosPanel3.SuspendLayout();
            this.efosTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInsumo)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.checkEstado.Location = new System.Drawing.Point(138, 486);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(28, 492);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(299, 537);
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(489, 537);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(111, 537);
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(204, 537);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(12, 537);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(393, 537);
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
            this.dataGridPrecioServicio.Location = new System.Drawing.Point(63, 6);
            this.dataGridPrecioServicio.Name = "dataGridPrecioServicio";
            this.dataGridPrecioServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridPrecioServicio.Size = new System.Drawing.Size(419, 214);
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
            this.columnaBotonEliminar.Width = 75;
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
            this.efosPanel3.Controls.Add(this.efosTabControl1);
            this.efosPanel3.Location = new System.Drawing.Point(13, 205);
            this.efosPanel3.Name = "efosPanel3";
            this.efosPanel3.Size = new System.Drawing.Size(551, 265);
            this.efosPanel3.TabIndex = 27;
            // 
            // efosTabControl1
            // 
            this.efosTabControl1.Controls.Add(this.tabPage1);
            this.efosTabControl1.Controls.Add(this.tabPage2);
            this.efosTabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosTabControl1.Location = new System.Drawing.Point(3, 3);
            this.efosTabControl1.Name = "efosTabControl1";
            this.efosTabControl1.SelectedIndex = 0;
            this.efosTabControl1.Size = new System.Drawing.Size(541, 255);
            this.efosTabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridInsumo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(533, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insumos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridInsumo
            // 
            this.dataGridInsumo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridInsumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridInsumo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridInsumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInsumo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaInsumo,
            this.columnaCantidad,
            this.columnaBotonEliminarInsumo});
            this.dataGridInsumo.Location = new System.Drawing.Point(62, 6);
            this.dataGridInsumo.Name = "dataGridInsumo";
            this.dataGridInsumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridInsumo.Size = new System.Drawing.Size(424, 150);
            this.dataGridInsumo.StandardTab = true;
            this.dataGridInsumo.TabIndex = 0;
            this.dataGridInsumo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.efosDataGridView1_CellClick_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridPrecioServicio);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(533, 226);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Precios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // efosPanel4
            // 
            this.efosPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel4.Location = new System.Drawing.Point(13, 476);
            this.efosPanel4.Name = "efosPanel4";
            this.efosPanel4.Size = new System.Drawing.Size(551, 45);
            this.efosPanel4.TabIndex = 28;
            // 
            // columnaInsumo
            // 
            this.columnaInsumo.HeaderText = "Insumo";
            this.columnaInsumo.Name = "columnaInsumo";
            this.columnaInsumo.Width = 200;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.HeaderText = "Cantidad";
            this.columnaCantidad.Name = "columnaCantidad";
            // 
            // columnaBotonEliminarInsumo
            // 
            this.columnaBotonEliminarInsumo.HeaderText = "Eliminar";
            this.columnaBotonEliminarInsumo.Name = "columnaBotonEliminarInsumo";
            this.columnaBotonEliminarInsumo.Text = "Eliminar";
            this.columnaBotonEliminarInsumo.ToolTipText = "Eliminar";
            this.columnaBotonEliminarInsumo.UseColumnTextForButtonValue = true;
            this.columnaBotonEliminarInsumo.Width = 80;
            // 
            // FormMantenimientoServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 594);
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
            this.efosTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInsumo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosCampo campoFechaCreacion;
        private ControlesEfos.efosDataGridView dataGridPrecioServicio;
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
        private System.Windows.Forms.DataGridViewComboBoxColumn columnaTipoPrecioServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecioServicio;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonEliminar;
        private ControlesEfos.efosTabControl efosTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private ControlesEfos.efosDataGridView dataGridInsumo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnaInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonEliminarInsumo;
    }
}