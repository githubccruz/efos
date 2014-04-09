namespace Efos
{
    partial class FormMantenimientoProducto
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
            this.efosLetrero3 = new ControlesEfos.efosLetrero();
            this.efosLetrero4 = new ControlesEfos.efosLetrero();
            this.efosLetrero5 = new ControlesEfos.efosLetrero();
            this.campoDescripcion = new ControlesEfos.efosCampo();
            this.campoCostoInicial = new ControlesEfos.efosCampo();
            this.campoCostoPromedio = new ControlesEfos.efosCampo();
            this.campoExistencia = new ControlesEfos.efosCampo();
            this.comboTipoProducto = new ControlesEfos.efosCombo();
            this.gridPrecioProducto = new ControlesEfos.efosDataGridView();
            this.columnaTipoPrecio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnaPrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBotonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.efosPanel1 = new ControlesEfos.efosPanel();
            this.efosPanel2 = new ControlesEfos.efosPanel();
            this.efosPanel3 = new ControlesEfos.efosPanel();
            this.efosLetrero6 = new ControlesEfos.efosLetrero();
            this.campoFechaCreacion = new ControlesEfos.efosCampo();
            this.efosPanel4 = new ControlesEfos.efosPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridPrecioProducto)).BeginInit();
            this.efosPanel2.SuspendLayout();
            this.efosPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(7, 9);
            this.textTitulo.Size = new System.Drawing.Size(595, 48);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(122, 95);
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.Location = new System.Drawing.Point(227, 89);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Location = new System.Drawing.Point(12, 98);
            // 
            // checkEstado
            // 
            this.checkEstado.Location = new System.Drawing.Point(125, 440);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(15, 446);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(316, 481);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(506, 481);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(128, 481);
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(221, 481);
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(29, 481);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(410, 481);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(15, 151);
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
            this.efosLetrero2.Location = new System.Drawing.Point(15, 183);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(90, 15);
            this.efosLetrero2.TabIndex = 17;
            this.efosLetrero2.Text = "Costo Inicial:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.AutoSize = true;
            this.efosLetrero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero3.Location = new System.Drawing.Point(298, 183);
            this.efosLetrero3.Name = "efosLetrero3";
            this.efosLetrero3.Size = new System.Drawing.Size(113, 15);
            this.efosLetrero3.TabIndex = 18;
            this.efosLetrero3.Text = "Costo Promedio:";
            this.efosLetrero3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero4
            // 
            this.efosLetrero4.AutoSize = true;
            this.efosLetrero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero4.Location = new System.Drawing.Point(15, 216);
            this.efosLetrero4.Name = "efosLetrero4";
            this.efosLetrero4.Size = new System.Drawing.Size(100, 15);
            this.efosLetrero4.TabIndex = 19;
            this.efosLetrero4.Text = "Tipo Producto:";
            this.efosLetrero4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero5
            // 
            this.efosLetrero5.AutoSize = true;
            this.efosLetrero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero5.Location = new System.Drawing.Point(298, 216);
            this.efosLetrero5.Name = "efosLetrero5";
            this.efosLetrero5.Size = new System.Drawing.Size(77, 15);
            this.efosLetrero5.TabIndex = 20;
            this.efosLetrero5.Text = "Existencia:";
            this.efosLetrero5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoDescripcion
            // 
            this.campoDescripcion.CampoBD = null;
            this.campoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescripcion.Limpiar = true;
            this.campoDescripcion.Location = new System.Drawing.Point(121, 148);
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(467, 21);
            this.campoDescripcion.SoloLectura = false;
            this.campoDescripcion.TabIndex = 21;
            // 
            // campoCostoInicial
            // 
            this.campoCostoInicial.CampoBD = null;
            this.campoCostoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCostoInicial.Limpiar = true;
            this.campoCostoInicial.Location = new System.Drawing.Point(121, 180);
            this.campoCostoInicial.Name = "campoCostoInicial";
            this.campoCostoInicial.Size = new System.Drawing.Size(171, 21);
            this.campoCostoInicial.SoloLectura = false;
            this.campoCostoInicial.TabIndex = 22;
            this.campoCostoInicial.TextChanged += new System.EventHandler(this.campoCostoInicial_TextChanged);
            // 
            // campoCostoPromedio
            // 
            this.campoCostoPromedio.CampoBD = null;
            this.campoCostoPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCostoPromedio.Limpiar = true;
            this.campoCostoPromedio.Location = new System.Drawing.Point(417, 180);
            this.campoCostoPromedio.Name = "campoCostoPromedio";
            this.campoCostoPromedio.Size = new System.Drawing.Size(171, 21);
            this.campoCostoPromedio.SoloLectura = false;
            this.campoCostoPromedio.TabIndex = 23;
            // 
            // campoExistencia
            // 
            this.campoExistencia.CampoBD = null;
            this.campoExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoExistencia.Limpiar = true;
            this.campoExistencia.Location = new System.Drawing.Point(417, 213);
            this.campoExistencia.Name = "campoExistencia";
            this.campoExistencia.Size = new System.Drawing.Size(171, 21);
            this.campoExistencia.SoloLectura = false;
            this.campoExistencia.TabIndex = 24;
            // 
            // comboTipoProducto
            // 
            this.comboTipoProducto.CampoBD = null;
            this.comboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoProducto.FormattingEnabled = true;
            this.comboTipoProducto.Location = new System.Drawing.Point(121, 212);
            this.comboTipoProducto.Name = "comboTipoProducto";
            this.comboTipoProducto.Size = new System.Drawing.Size(171, 23);
            this.comboTipoProducto.Sorted = true;
            this.comboTipoProducto.TabIndex = 25;
            // 
            // gridPrecioProducto
            // 
            this.gridPrecioProducto.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.gridPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPrecioProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridPrecioProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPrecioProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaTipoPrecio,
            this.columnaPrecioProducto,
            this.columnaBotonEliminar});
            this.gridPrecioProducto.Enabled = false;
            this.gridPrecioProducto.Location = new System.Drawing.Point(98, 6);
            this.gridPrecioProducto.Name = "gridPrecioProducto";
            this.gridPrecioProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridPrecioProducto.Size = new System.Drawing.Size(394, 150);
            this.gridPrecioProducto.StandardTab = true;
            this.gridPrecioProducto.TabIndex = 26;
            this.gridPrecioProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrecioProducto_CellClick);
            // 
            // columnaTipoPrecio
            // 
            this.columnaTipoPrecio.HeaderText = "Tipo Precio";
            this.columnaTipoPrecio.Name = "columnaTipoPrecio";
            this.columnaTipoPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnaTipoPrecio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnaTipoPrecio.Width = 200;
            // 
            // columnaPrecioProducto
            // 
            this.columnaPrecioProducto.HeaderText = "Precio Producto";
            this.columnaPrecioProducto.Name = "columnaPrecioProducto";
            // 
            // columnaBotonEliminar
            // 
            this.columnaBotonEliminar.HeaderText = "Eliminar";
            this.columnaBotonEliminar.Name = "columnaBotonEliminar";
            this.columnaBotonEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnaBotonEliminar.Text = "Eliminar";
            this.columnaBotonEliminar.ToolTipText = "Eliminar";
            this.columnaBotonEliminar.UseColumnTextForButtonValue = true;
            this.columnaBotonEliminar.Width = 50;
            // 
            // efosPanel1
            // 
            this.efosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel1.Location = new System.Drawing.Point(7, 138);
            this.efosPanel1.Name = "efosPanel1";
            this.efosPanel1.Size = new System.Drawing.Size(595, 115);
            this.efosPanel1.TabIndex = 27;
            // 
            // efosPanel2
            // 
            this.efosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel2.Controls.Add(this.gridPrecioProducto);
            this.efosPanel2.Location = new System.Drawing.Point(7, 259);
            this.efosPanel2.Name = "efosPanel2";
            this.efosPanel2.Size = new System.Drawing.Size(595, 166);
            this.efosPanel2.TabIndex = 28;
            // 
            // efosPanel3
            // 
            this.efosPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel3.Controls.Add(this.efosLetrero6);
            this.efosPanel3.Controls.Add(this.campoFechaCreacion);
            this.efosPanel3.Location = new System.Drawing.Point(7, 79);
            this.efosPanel3.Name = "efosPanel3";
            this.efosPanel3.Size = new System.Drawing.Size(595, 53);
            this.efosPanel3.TabIndex = 29;
            // 
            // efosLetrero6
            // 
            this.efosLetrero6.AutoSize = true;
            this.efosLetrero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero6.Location = new System.Drawing.Point(329, 17);
            this.efosLetrero6.Name = "efosLetrero6";
            this.efosLetrero6.Size = new System.Drawing.Size(111, 15);
            this.efosLetrero6.TabIndex = 1;
            this.efosLetrero6.Text = "Fecha Creacion:";
            this.efosLetrero6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoFechaCreacion
            // 
            this.campoFechaCreacion.CampoBD = null;
            this.campoFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoFechaCreacion.Limpiar = true;
            this.campoFechaCreacion.Location = new System.Drawing.Point(453, 14);
            this.campoFechaCreacion.Name = "campoFechaCreacion";
            this.campoFechaCreacion.Size = new System.Drawing.Size(100, 21);
            this.campoFechaCreacion.SoloLectura = false;
            this.campoFechaCreacion.TabIndex = 0;
            // 
            // efosPanel4
            // 
            this.efosPanel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel4.Location = new System.Drawing.Point(7, 431);
            this.efosPanel4.Name = "efosPanel4";
            this.efosPanel4.Size = new System.Drawing.Size(595, 44);
            this.efosPanel4.TabIndex = 30;
            // 
            // FormMantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 539);
            this.Controls.Add(this.comboTipoProducto);
            this.Controls.Add(this.campoExistencia);
            this.Controls.Add(this.campoCostoPromedio);
            this.Controls.Add(this.campoCostoInicial);
            this.Controls.Add(this.campoDescripcion);
            this.Controls.Add(this.efosLetrero5);
            this.Controls.Add(this.efosLetrero4);
            this.Controls.Add(this.efosLetrero3);
            this.Controls.Add(this.efosLetrero2);
            this.Controls.Add(this.efosLetrero1);
            this.Controls.Add(this.efosPanel1);
            this.Controls.Add(this.efosPanel2);
            this.Controls.Add(this.efosPanel3);
            this.Controls.Add(this.efosPanel4);
            this.Name = "FormMantenimientoProducto";
            this.Text = "FormMantenimientoProducto";
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
            this.Controls.SetChildIndex(this.efosLetrero2, 0);
            this.Controls.SetChildIndex(this.efosLetrero3, 0);
            this.Controls.SetChildIndex(this.efosLetrero4, 0);
            this.Controls.SetChildIndex(this.efosLetrero5, 0);
            this.Controls.SetChildIndex(this.campoDescripcion, 0);
            this.Controls.SetChildIndex(this.campoCostoInicial, 0);
            this.Controls.SetChildIndex(this.campoCostoPromedio, 0);
            this.Controls.SetChildIndex(this.campoExistencia, 0);
            this.Controls.SetChildIndex(this.comboTipoProducto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridPrecioProducto)).EndInit();
            this.efosPanel2.ResumeLayout(false);
            this.efosPanel3.ResumeLayout(false);
            this.efosPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosLetrero efosLetrero2;
        private ControlesEfos.efosLetrero efosLetrero3;
        private ControlesEfos.efosLetrero efosLetrero4;
        private ControlesEfos.efosLetrero efosLetrero5;
        private ControlesEfos.efosCampo campoDescripcion;
        private ControlesEfos.efosCampo campoCostoInicial;
        private ControlesEfos.efosCampo campoCostoPromedio;
        private ControlesEfos.efosCampo campoExistencia;
        private ControlesEfos.efosCombo comboTipoProducto;
        private ControlesEfos.efosDataGridView gridPrecioProducto;
        private ControlesEfos.efosPanel efosPanel1;
        private ControlesEfos.efosPanel efosPanel2;
        private ControlesEfos.efosPanel efosPanel3;
        private ControlesEfos.efosPanel efosPanel4;
        private ControlesEfos.efosLetrero efosLetrero6;
        private ControlesEfos.efosCampo campoFechaCreacion;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnaTipoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecioProducto;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonEliminar;

    }
}