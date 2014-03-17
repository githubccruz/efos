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
            this.efosCampo1 = new ControlesEfos.efosCampo();
            this.efosCampo2 = new ControlesEfos.efosCampo();
            this.efosCampo3 = new ControlesEfos.efosCampo();
            this.efosCampo4 = new ControlesEfos.efosCampo();
            this.efosCampo5 = new ControlesEfos.efosCampo();
            this.efosLetrero8 = new ControlesEfos.efosLetrero();
            this.efosButtonBuscador1 = new ControlesEfos.efosButtonBuscador();
            this.efosGroupBox1 = new ControlesEfos.efosGroupBox();
            this.efosButton1 = new ControlesEfos.efosButton();
            this.efosDataGridView1 = new ControlesEfos.efosDataGridView();
            this.efosGroupBox2 = new ControlesEfos.efosGroupBox();
            this.efosCampo6 = new ControlesEfos.efosCampo();
            this.efosLetrero9 = new ControlesEfos.efosLetrero();
            this.efosLetrero10 = new ControlesEfos.efosLetrero();
            this.columnaCodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efosGroupBox3 = new ControlesEfos.efosGroupBox();
            this.efosGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.efosDataGridView1)).BeginInit();
            this.efosGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonProcesar
            // 
            this.botonProcesar.Location = new System.Drawing.Point(209, 419);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(311, 419);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(419, 419);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(521, 419);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(103, 419);
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
            // efosCampo1
            // 
            this.efosCampo1.CampoBD = null;
            this.efosCampo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo1.Limpiar = true;
            this.efosCampo1.Location = new System.Drawing.Point(354, 160);
            this.efosCampo1.Name = "efosCampo1";
            this.efosCampo1.Size = new System.Drawing.Size(70, 21);
            this.efosCampo1.SoloLectura = false;
            this.efosCampo1.TabIndex = 19;
            // 
            // efosCampo2
            // 
            this.efosCampo2.CampoBD = null;
            this.efosCampo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo2.Limpiar = true;
            this.efosCampo2.Location = new System.Drawing.Point(23, 160);
            this.efosCampo2.Name = "efosCampo2";
            this.efosCampo2.Size = new System.Drawing.Size(61, 21);
            this.efosCampo2.SoloLectura = false;
            this.efosCampo2.TabIndex = 20;
            // 
            // efosCampo3
            // 
            this.efosCampo3.CampoBD = null;
            this.efosCampo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo3.Limpiar = true;
            this.efosCampo3.Location = new System.Drawing.Point(131, 160);
            this.efosCampo3.Name = "efosCampo3";
            this.efosCampo3.Size = new System.Drawing.Size(219, 21);
            this.efosCampo3.SoloLectura = false;
            this.efosCampo3.TabIndex = 21;
            // 
            // efosCampo4
            // 
            this.efosCampo4.CampoBD = null;
            this.efosCampo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo4.Limpiar = true;
            this.efosCampo4.Location = new System.Drawing.Point(427, 160);
            this.efosCampo4.Name = "efosCampo4";
            this.efosCampo4.Size = new System.Drawing.Size(100, 21);
            this.efosCampo4.SoloLectura = false;
            this.efosCampo4.TabIndex = 22;
            // 
            // efosCampo5
            // 
            this.efosCampo5.CampoBD = null;
            this.efosCampo5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo5.Limpiar = true;
            this.efosCampo5.Location = new System.Drawing.Point(533, 160);
            this.efosCampo5.Name = "efosCampo5";
            this.efosCampo5.Size = new System.Drawing.Size(94, 21);
            this.efosCampo5.SoloLectura = true;
            this.efosCampo5.TabIndex = 23;
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
            // efosButtonBuscador1
            // 
            this.efosButtonBuscador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosButtonBuscador1.Image = ((System.Drawing.Image)(resources.GetObject("efosButtonBuscador1.Image")));
            this.efosButtonBuscador1.Location = new System.Drawing.Point(90, 155);
            this.efosButtonBuscador1.Name = "efosButtonBuscador1";
            this.efosButtonBuscador1.Size = new System.Drawing.Size(35, 30);
            this.efosButtonBuscador1.TabIndex = 25;
            this.efosButtonBuscador1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.efosButtonBuscador1.UseVisualStyleBackColor = true;
            // 
            // efosGroupBox1
            // 
            this.efosGroupBox1.Controls.Add(this.efosButton1);
            this.efosGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox1.Location = new System.Drawing.Point(10, 121);
            this.efosGroupBox1.Name = "efosGroupBox1";
            this.efosGroupBox1.Size = new System.Drawing.Size(677, 75);
            this.efosGroupBox1.TabIndex = 26;
            this.efosGroupBox1.TabStop = false;
            this.efosGroupBox1.Text = "Producto para Facturar";
            // 
            // efosButton1
            // 
            this.efosButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosButton1.Image = global::Efos.Properties.Resources.download;
            this.efosButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.efosButton1.Location = new System.Drawing.Point(619, 34);
            this.efosButton1.Name = "efosButton1";
            this.efosButton1.Size = new System.Drawing.Size(35, 30);
            this.efosButton1.TabIndex = 0;
            this.efosButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.efosButton1.UseVisualStyleBackColor = true;
            // 
            // efosDataGridView1
            // 
            this.efosDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.efosDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.efosDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.efosDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigoProducto,
            this.columnaDescripcionProducto,
            this.columnaCantidad,
            this.columnaPrecioProducto,
            this.columnaSubTotal});
            this.efosDataGridView1.Location = new System.Drawing.Point(20, 206);
            this.efosDataGridView1.Name = "efosDataGridView1";
            this.efosDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.efosDataGridView1.Size = new System.Drawing.Size(660, 150);
            this.efosDataGridView1.StandardTab = true;
            this.efosDataGridView1.TabIndex = 27;
            // 
            // efosGroupBox2
            // 
            this.efosGroupBox2.Controls.Add(this.efosCampo6);
            this.efosGroupBox2.Controls.Add(this.efosLetrero9);
            this.efosGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox2.Location = new System.Drawing.Point(10, 368);
            this.efosGroupBox2.Name = "efosGroupBox2";
            this.efosGroupBox2.Size = new System.Drawing.Size(677, 40);
            this.efosGroupBox2.TabIndex = 28;
            this.efosGroupBox2.TabStop = false;
            // 
            // efosCampo6
            // 
            this.efosCampo6.CampoBD = null;
            this.efosCampo6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo6.Limpiar = true;
            this.efosCampo6.Location = new System.Drawing.Point(523, 11);
            this.efosCampo6.Name = "efosCampo6";
            this.efosCampo6.Size = new System.Drawing.Size(96, 21);
            this.efosCampo6.SoloLectura = false;
            this.efosCampo6.TabIndex = 1;
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
            // columnaCodigoProducto
            // 
            this.columnaCodigoProducto.HeaderText = "Codigo";
            this.columnaCodigoProducto.Name = "columnaCodigoProducto";
            this.columnaCodigoProducto.Width = 75;
            // 
            // columnaDescripcionProducto
            // 
            this.columnaDescripcionProducto.HeaderText = "Descripcion Producto";
            this.columnaDescripcionProducto.Name = "columnaDescripcionProducto";
            this.columnaDescripcionProducto.Width = 270;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.HeaderText = "Cantidad";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.Width = 85;
            // 
            // columnaPrecioProducto
            // 
            this.columnaPrecioProducto.HeaderText = "Precio";
            this.columnaPrecioProducto.Name = "columnaPrecioProducto";
            this.columnaPrecioProducto.Width = 85;
            // 
            // columnaSubTotal
            // 
            this.columnaSubTotal.HeaderText = "Sub-Total";
            this.columnaSubTotal.Name = "columnaSubTotal";
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
            this.Controls.Add(this.efosDataGridView1);
            this.Controls.Add(this.efosButtonBuscador1);
            this.Controls.Add(this.efosLetrero8);
            this.Controls.Add(this.efosCampo5);
            this.Controls.Add(this.efosCampo4);
            this.Controls.Add(this.efosCampo3);
            this.Controls.Add(this.efosCampo2);
            this.Controls.Add(this.efosCampo1);
            this.Controls.Add(this.efosLetrero7);
            this.Controls.Add(this.efosLetrero6);
            this.Controls.Add(this.efosLetrero5);
            this.Controls.Add(this.efosLetrero4);
            this.Controls.Add(this.efosGroupBox1);
            this.Controls.Add(this.efosGroupBox3);
            this.Name = "FormProcesoFactura";
            this.Text = "FormProcesoFactura";
            this.Load += new System.EventHandler(this.FormProcesoFactura_Load);
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
            this.Controls.SetChildIndex(this.efosCampo1, 0);
            this.Controls.SetChildIndex(this.efosCampo2, 0);
            this.Controls.SetChildIndex(this.efosCampo3, 0);
            this.Controls.SetChildIndex(this.efosCampo4, 0);
            this.Controls.SetChildIndex(this.efosCampo5, 0);
            this.Controls.SetChildIndex(this.efosLetrero8, 0);
            this.Controls.SetChildIndex(this.efosButtonBuscador1, 0);
            this.Controls.SetChildIndex(this.efosDataGridView1, 0);
            this.Controls.SetChildIndex(this.efosGroupBox2, 0);
            this.Controls.SetChildIndex(this.efosLetrero10, 0);
            this.efosGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.efosDataGridView1)).EndInit();
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
        private ControlesEfos.efosCampo efosCampo1;
        private ControlesEfos.efosCampo efosCampo2;
        private ControlesEfos.efosCampo efosCampo3;
        private ControlesEfos.efosCampo efosCampo4;
        private ControlesEfos.efosCampo efosCampo5;
        private ControlesEfos.efosLetrero efosLetrero8;
        private ControlesEfos.efosButtonBuscador efosButtonBuscador1;
        private ControlesEfos.efosGroupBox efosGroupBox1;
        private ControlesEfos.efosDataGridView efosDataGridView1;
        private ControlesEfos.efosGroupBox efosGroupBox2;
        private ControlesEfos.efosCampo efosCampo6;
        private ControlesEfos.efosLetrero efosLetrero9;
        private ControlesEfos.efosLetrero efosLetrero10;
        private ControlesEfos.efosButton efosButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSubTotal;
        private ControlesEfos.efosGroupBox efosGroupBox3;
    }
}