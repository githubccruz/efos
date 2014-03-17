namespace Efos
{
    partial class FormProcesoFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcesoFactura));
            this.efosLetrero4 = new ControlesEfos.efosLetrero();
            this.efosLetrero5 = new ControlesEfos.efosLetrero();
            this.efosLetrero6 = new ControlesEfos.efosLetrero();
            this.efosLetrero7 = new ControlesEfos.efosLetrero();
            this.campoCantidad = new ControlesEfos.efosCampo();
            this.campoCodigo = new ControlesEfos.efosCampo();
            this.campoDescripcion = new ControlesEfos.efosCampo();
            this.campoPrecio = new ControlesEfos.efosCampo();
            this.campoSubTotal = new ControlesEfos.efosCampo();
            this.efosLetrero8 = new ControlesEfos.efosLetrero();
            this.lupaProducto = new ControlesEfos.efosButtonBuscador();
            this.efosGroupBox1 = new ControlesEfos.efosGroupBox();
            this.botonAgregar = new ControlesEfos.efosButton();
            this.dataGridFactura = new ControlesEfos.efosDataGridView();
            this.columnaCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBotonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.efosGroupBox2 = new ControlesEfos.efosGroupBox();
            this.campoTotal = new ControlesEfos.efosCampo();
            this.efosLetrero9 = new ControlesEfos.efosLetrero();
            this.efosLetrero10 = new ControlesEfos.efosLetrero();
            this.efosGroupBox3 = new ControlesEfos.efosGroupBox();
            this.efosGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFactura)).BeginInit();
            this.efosGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonProcesar
            // 
            this.botonProcesar.Location = new System.Drawing.Point(209, 419);
            this.botonProcesar.TabIndex = 16;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(311, 419);
            this.botonCancelar.TabIndex = 17;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(419, 419);
            this.botonBuscar.TabIndex = 18;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(521, 419);
            this.botonSalir.TabIndex = 19;
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(103, 419);
            this.botonNuevo.TabIndex = 15;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // efosLetrero4
            // 
            this.efosLetrero4.AutoSize = true;
            this.efosLetrero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero4.Location = new System.Drawing.Point(357, 143);
            this.efosLetrero4.Name = "efosLetrero4";
            this.efosLetrero4.Size = new System.Drawing.Size(64, 15);
            this.efosLetrero4.TabIndex = 15;
            this.efosLetrero4.Text = "Cantidad";
            this.efosLetrero4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero5
            // 
            this.efosLetrero5.AutoSize = true;
            this.efosLetrero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero5.Location = new System.Drawing.Point(27, 143);
            this.efosLetrero5.Name = "efosLetrero5";
            this.efosLetrero5.Size = new System.Drawing.Size(52, 15);
            this.efosLetrero5.TabIndex = 16;
            this.efosLetrero5.Text = "Codigo";
            this.efosLetrero5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero6
            // 
            this.efosLetrero6.AutoSize = true;
            this.efosLetrero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero6.Location = new System.Drawing.Point(199, 143);
            this.efosLetrero6.Name = "efosLetrero6";
            this.efosLetrero6.Size = new System.Drawing.Size(83, 15);
            this.efosLetrero6.TabIndex = 17;
            this.efosLetrero6.Text = "Descripcion";
            this.efosLetrero6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero7
            // 
            this.efosLetrero7.AutoSize = true;
            this.efosLetrero7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero7.Location = new System.Drawing.Point(453, 142);
            this.efosLetrero7.Name = "efosLetrero7";
            this.efosLetrero7.Size = new System.Drawing.Size(48, 15);
            this.efosLetrero7.TabIndex = 18;
            this.efosLetrero7.Text = "Precio";
            this.efosLetrero7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoCantidad
            // 
            this.campoCantidad.CampoBD = null;
            this.campoCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCantidad.Limpiar = true;
            this.campoCantidad.Location = new System.Drawing.Point(354, 160);
            this.campoCantidad.Name = "campoCantidad";
            this.campoCantidad.Size = new System.Drawing.Size(70, 21);
            this.campoCantidad.SoloLectura = false;
            this.campoCantidad.TabIndex = 11;
            this.campoCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoCantidad_KeyPress);
            this.campoCantidad.Validated += new System.EventHandler(this.campoCantidad_Validated);
            // 
            // campoCodigo
            // 
            this.campoCodigo.CampoBD = null;
            this.campoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodigo.Limpiar = true;
            this.campoCodigo.Location = new System.Drawing.Point(23, 160);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(61, 21);
            this.campoCodigo.SoloLectura = false;
            this.campoCodigo.TabIndex = 9;
            this.campoCodigo.Validated += new System.EventHandler(this.campoCodigo_Validated);
            // 
            // campoDescripcion
            // 
            this.campoDescripcion.CampoBD = "descprod";
            this.campoDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.campoDescripcion.Enabled = false;
            this.campoDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescripcion.Limpiar = true;
            this.campoDescripcion.Location = new System.Drawing.Point(131, 160);
            this.campoDescripcion.Name = "campoDescripcion";
            this.campoDescripcion.Size = new System.Drawing.Size(219, 21);
            this.campoDescripcion.SoloLectura = true;
            this.campoDescripcion.TabIndex = 10;
            // 
            // campoPrecio
            // 
            this.campoPrecio.CampoBD = "coprprod";
            this.campoPrecio.Enabled = false;
            this.campoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPrecio.Limpiar = true;
            this.campoPrecio.Location = new System.Drawing.Point(427, 160);
            this.campoPrecio.Name = "campoPrecio";
            this.campoPrecio.Size = new System.Drawing.Size(100, 21);
            this.campoPrecio.SoloLectura = true;
            this.campoPrecio.TabIndex = 12;
            // 
            // campoSubTotal
            // 
            this.campoSubTotal.CampoBD = null;
            this.campoSubTotal.Enabled = false;
            this.campoSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoSubTotal.Limpiar = true;
            this.campoSubTotal.Location = new System.Drawing.Point(533, 160);
            this.campoSubTotal.Name = "campoSubTotal";
            this.campoSubTotal.Size = new System.Drawing.Size(94, 21);
            this.campoSubTotal.SoloLectura = true;
            this.campoSubTotal.TabIndex = 13;
            // 
            // efosLetrero8
            // 
            this.efosLetrero8.AutoSize = true;
            this.efosLetrero8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero8.Location = new System.Drawing.Point(546, 142);
            this.efosLetrero8.Name = "efosLetrero8";
            this.efosLetrero8.Size = new System.Drawing.Size(69, 15);
            this.efosLetrero8.TabIndex = 24;
            this.efosLetrero8.Text = "Sub-Total";
            this.efosLetrero8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lupaProducto
            // 
            this.lupaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lupaProducto.Image = ((System.Drawing.Image)(resources.GetObject("lupaProducto.Image")));
            this.lupaProducto.Location = new System.Drawing.Point(90, 155);
            this.lupaProducto.Name = "lupaProducto";
            this.lupaProducto.Size = new System.Drawing.Size(35, 30);
            this.lupaProducto.TabIndex = 25;
            this.lupaProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lupaProducto.UseVisualStyleBackColor = true;
            // 
            // efosGroupBox1
            // 
            this.efosGroupBox1.Controls.Add(this.botonAgregar);
            this.efosGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox1.Location = new System.Drawing.Point(10, 121);
            this.efosGroupBox1.Name = "efosGroupBox1";
            this.efosGroupBox1.Size = new System.Drawing.Size(677, 75);
            this.efosGroupBox1.TabIndex = 26;
            this.efosGroupBox1.TabStop = false;
            this.efosGroupBox1.Text = "Producto para Facturar";
            // 
            // botonAgregar
            // 
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Image = global::Efos.Properties.Resources.download;
            this.botonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonAgregar.Location = new System.Drawing.Point(619, 34);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(35, 30);
            this.botonAgregar.TabIndex = 0;
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // dataGridFactura
            // 
            this.dataGridFactura.AllowUserToAddRows = false;
            this.dataGridFactura.AllowUserToResizeColumns = false;
            this.dataGridFactura.AllowUserToResizeRows = false;
            this.dataGridFactura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridFactura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigoProducto,
            this.columnaDescripcionProducto,
            this.columnaCantidad,
            this.columnaPrecioProducto,
            this.columnaSubTotal,
            this.columnaBotonEliminar});
            this.dataGridFactura.Location = new System.Drawing.Point(16, 208);
            this.dataGridFactura.Name = "dataGridFactura";
            this.dataGridFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridFactura.Size = new System.Drawing.Size(668, 150);
            this.dataGridFactura.StandardTab = true;
            this.dataGridFactura.TabIndex = 14;
            this.dataGridFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFactura_CellClick);
            this.dataGridFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.efosDataGridView1_CellValueChanged);
            // 
            // columnaCodigoProducto
            // 
            this.columnaCodigoProducto.HeaderText = "Codigo";
            this.columnaCodigoProducto.Name = "columnaCodigoProducto";
            this.columnaCodigoProducto.Width = 70;
            // 
            // columnaDescripcionProducto
            // 
            this.columnaDescripcionProducto.HeaderText = "Descripcion Producto";
            this.columnaDescripcionProducto.Name = "columnaDescripcionProducto";
            this.columnaDescripcionProducto.Width = 250;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.HeaderText = "Cantidad";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.Width = 80;
            // 
            // columnaPrecioProducto
            // 
            this.columnaPrecioProducto.HeaderText = "Precio";
            this.columnaPrecioProducto.Name = "columnaPrecioProducto";
            this.columnaPrecioProducto.Width = 80;
            // 
            // columnaSubTotal
            // 
            this.columnaSubTotal.HeaderText = "Sub-Total";
            this.columnaSubTotal.Name = "columnaSubTotal";
            this.columnaSubTotal.Width = 90;
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
            // efosGroupBox2
            // 
            this.efosGroupBox2.Controls.Add(this.campoTotal);
            this.efosGroupBox2.Controls.Add(this.efosLetrero9);
            this.efosGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox2.Location = new System.Drawing.Point(10, 368);
            this.efosGroupBox2.Name = "efosGroupBox2";
            this.efosGroupBox2.Size = new System.Drawing.Size(677, 40);
            this.efosGroupBox2.TabIndex = 28;
            this.efosGroupBox2.TabStop = false;
            // 
            // campoTotal
            // 
            this.campoTotal.CampoBD = null;
            this.campoTotal.Enabled = false;
            this.campoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTotal.Limpiar = true;
            this.campoTotal.Location = new System.Drawing.Point(523, 11);
            this.campoTotal.Name = "campoTotal";
            this.campoTotal.Size = new System.Drawing.Size(96, 21);
            this.campoTotal.SoloLectura = true;
            this.campoTotal.TabIndex = 0;
            // 
            // efosLetrero9
            // 
            this.efosLetrero9.AutoSize = true;
            this.efosLetrero9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero9.Location = new System.Drawing.Point(474, 14);
            this.efosLetrero9.Name = "efosLetrero9";
            this.efosLetrero9.Size = new System.Drawing.Size(43, 15);
            this.efosLetrero9.TabIndex = 0;
            this.efosLetrero9.Text = "Total:";
            this.efosLetrero9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero10
            // 
            this.efosLetrero10.AutoSize = true;
            this.efosLetrero10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero10.Location = new System.Drawing.Point(399, 7);
            this.efosLetrero10.Name = "efosLetrero10";
            this.efosLetrero10.Size = new System.Drawing.Size(34, 15);
            this.efosLetrero10.TabIndex = 2;
            this.efosLetrero10.Text = "NCF";
            this.efosLetrero10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosGroupBox3
            // 
            this.efosGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox3.Location = new System.Drawing.Point(10, 192);
            this.efosGroupBox3.Name = "efosGroupBox3";
            this.efosGroupBox3.Size = new System.Drawing.Size(679, 175);
            this.efosGroupBox3.TabIndex = 29;
            this.efosGroupBox3.TabStop = false;
            // 
            // FormProcesoFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 475);
            this.Controls.Add(this.efosLetrero10);
            this.Controls.Add(this.efosGroupBox2);
            this.Controls.Add(this.dataGridFactura);
            this.Controls.Add(this.lupaProducto);
            this.Controls.Add(this.efosLetrero8);
            this.Controls.Add(this.campoSubTotal);
            this.Controls.Add(this.campoPrecio);
            this.Controls.Add(this.campoDescripcion);
            this.Controls.Add(this.campoCodigo);
            this.Controls.Add(this.campoCantidad);
            this.Controls.Add(this.efosLetrero7);
            this.Controls.Add(this.efosLetrero6);
            this.Controls.Add(this.efosLetrero5);
            this.Controls.Add(this.efosLetrero4);
            this.Controls.Add(this.efosGroupBox1);
            this.Controls.Add(this.efosGroupBox3);
            this.Name = "FormProcesoFactura";
            this.Text = "FormProcesoFactura";
            this.Controls.SetChildIndex(this.efosGroupBox3, 0);
            this.Controls.SetChildIndex(this.efosGroupBox1, 0);
            this.Controls.SetChildIndex(this.botonProcesar, 0);
            this.Controls.SetChildIndex(this.botonCancelar, 0);
            this.Controls.SetChildIndex(this.botonBuscar, 0);
            this.Controls.SetChildIndex(this.botonSalir, 0);
            this.Controls.SetChildIndex(this.botonNuevo, 0);
            this.Controls.SetChildIndex(this.efosLetrero4, 0);
            this.Controls.SetChildIndex(this.efosLetrero5, 0);
            this.Controls.SetChildIndex(this.efosLetrero6, 0);
            this.Controls.SetChildIndex(this.efosLetrero7, 0);
            this.Controls.SetChildIndex(this.campoCantidad, 0);
            this.Controls.SetChildIndex(this.campoCodigo, 0);
            this.Controls.SetChildIndex(this.campoDescripcion, 0);
            this.Controls.SetChildIndex(this.campoPrecio, 0);
            this.Controls.SetChildIndex(this.campoSubTotal, 0);
            this.Controls.SetChildIndex(this.efosLetrero8, 0);
            this.Controls.SetChildIndex(this.lupaProducto, 0);
            this.Controls.SetChildIndex(this.dataGridFactura, 0);
            this.Controls.SetChildIndex(this.efosGroupBox2, 0);
            this.Controls.SetChildIndex(this.efosLetrero10, 0);
            this.efosGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFactura)).EndInit();
            this.efosGroupBox2.ResumeLayout(false);
            this.efosGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero4;
        private ControlesEfos.efosLetrero efosLetrero5;
        private ControlesEfos.efosLetrero efosLetrero6;
        private ControlesEfos.efosLetrero efosLetrero7;
        private ControlesEfos.efosCampo campoCantidad;
        private ControlesEfos.efosCampo campoCodigo;
        private ControlesEfos.efosCampo campoDescripcion;
        private ControlesEfos.efosCampo campoPrecio;
        private ControlesEfos.efosCampo campoSubTotal;
        private ControlesEfos.efosLetrero efosLetrero8;
        private ControlesEfos.efosButtonBuscador lupaProducto;
        private ControlesEfos.efosGroupBox efosGroupBox1;
        private ControlesEfos.efosDataGridView dataGridFactura;
        private ControlesEfos.efosGroupBox efosGroupBox2;
        private ControlesEfos.efosCampo campoTotal;
        private ControlesEfos.efosLetrero efosLetrero9;
        private ControlesEfos.efosLetrero efosLetrero10;
        private ControlesEfos.efosButton botonAgregar;
        private ControlesEfos.efosGroupBox efosGroupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonEliminar;
    }
}