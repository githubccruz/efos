namespace Efos
{
    partial class FormProcesoOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProcesoOrdenTrabajo));
            this.checkEstado = new ControlesEfos.efosCheck();
            this.efosLetrero4 = new ControlesEfos.efosLetrero();
            this.campoCodigo = new ControlesEfos.efosCampo();
            this.lupaServicio = new ControlesEfos.efosButtonBuscador();
            this.campoDescripcioServicio = new ControlesEfos.efosCampo();
            this.comboTipoPrecio = new ControlesEfos.efosCombo();
            this.campoPrecio = new ControlesEfos.efosCampo();
            this.efosLetrero5 = new ControlesEfos.efosLetrero();
            this.efosLetrero6 = new ControlesEfos.efosLetrero();
            this.efosLetrero8 = new ControlesEfos.efosLetrero();
            this.efosLetrero9 = new ControlesEfos.efosLetrero();
            this.campoCantidad = new ControlesEfos.efosCampo();
            this.efosLetrero10 = new ControlesEfos.efosLetrero();
            this.efosButtonBuscador2 = new ControlesEfos.efosButtonBuscador();
            this.efosGroupBox1 = new ControlesEfos.efosGroupBox();
            this.dataGridServicios = new ControlesEfos.efosDataGridView();
            this.columnaCodigoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDescripcionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecioServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBotonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboTipoNCF = new ControlesEfos.efosCombo();
            this.efosLetrero7 = new ControlesEfos.efosLetrero();
            this.letreroNCF = new ControlesEfos.efosLetrero();
            this.efosGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // botonProcesar
            // 
            this.botonProcesar.Location = new System.Drawing.Point(259, 467);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(361, 467);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(469, 467);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(571, 467);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(153, 467);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.Location = new System.Drawing.Point(22, 48);
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.Location = new System.Drawing.Point(538, 48);
            // 
            // txtFechaAsunto
            // 
            this.txtFechaAsunto.Location = new System.Drawing.Point(662, 45);
            // 
            // txtNumeroAsunto
            // 
            this.txtNumeroAsunto.Location = new System.Drawing.Point(189, 45);
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Location = new System.Drawing.Point(189, 88);
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.Location = new System.Drawing.Point(22, 91);
            // 
            // lupaPaciente
            // 
            this.lupaPaciente.Location = new System.Drawing.Point(153, 83);
            // 
            // lupaAsunto
            // 
            this.lupaAsunto.Location = new System.Drawing.Point(153, 40);
            // 
            // letreroNombrePaciente
            // 
            this.letreroNombrePaciente.Location = new System.Drawing.Point(295, 91);
            // 
            // efosGroupBoxPadre
            // 
            this.efosGroupBoxPadre.Location = new System.Drawing.Point(12, 27);
            this.efosGroupBoxPadre.Size = new System.Drawing.Size(765, 100);
            // 
            // checkEstado
            // 
            this.checkEstado.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkEstado.CampoBD = null;
            this.checkEstado.Checked = true;
            this.checkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEstado.ForeColor = System.Drawing.Color.Blue;
            this.checkEstado.Location = new System.Drawing.Point(198, 432);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(100, 26);
            this.checkEstado.TabIndex = 14;
            this.checkEstado.Text = "Activar";
            this.checkEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // efosLetrero4
            // 
            this.efosLetrero4.AutoSize = true;
            this.efosLetrero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero4.Location = new System.Drawing.Point(34, 438);
            this.efosLetrero4.Name = "efosLetrero4";
            this.efosLetrero4.Size = new System.Drawing.Size(55, 15);
            this.efosLetrero4.TabIndex = 13;
            this.efosLetrero4.Text = "Estado:";
            this.efosLetrero4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoCodigo
            // 
            this.campoCodigo.CampoBD = null;
            this.campoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodigo.Limpiar = true;
            this.campoCodigo.Location = new System.Drawing.Point(37, 174);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(69, 21);
            this.campoCodigo.SoloLectura = false;
            this.campoCodigo.TabIndex = 16;
            // 
            // lupaServicio
            // 
            this.lupaServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lupaServicio.Image = ((System.Drawing.Image)(resources.GetObject("lupaServicio.Image")));
            this.lupaServicio.Location = new System.Drawing.Point(112, 169);
            this.lupaServicio.Name = "lupaServicio";
            this.lupaServicio.Size = new System.Drawing.Size(35, 30);
            this.lupaServicio.TabIndex = 17;
            this.lupaServicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lupaServicio.UseVisualStyleBackColor = true;
            // 
            // campoDescripcioServicio
            // 
            this.campoDescripcioServicio.CampoBD = null;
            this.campoDescripcioServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescripcioServicio.Limpiar = true;
            this.campoDescripcioServicio.Location = new System.Drawing.Point(156, 174);
            this.campoDescripcioServicio.Name = "campoDescripcioServicio";
            this.campoDescripcioServicio.Size = new System.Drawing.Size(230, 21);
            this.campoDescripcioServicio.SoloLectura = false;
            this.campoDescripcioServicio.TabIndex = 18;
            // 
            // comboTipoPrecio
            // 
            this.comboTipoPrecio.CampoBD = null;
            this.comboTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoPrecio.FormattingEnabled = true;
            this.comboTipoPrecio.Location = new System.Drawing.Point(392, 173);
            this.comboTipoPrecio.Name = "comboTipoPrecio";
            this.comboTipoPrecio.Size = new System.Drawing.Size(121, 23);
            this.comboTipoPrecio.Sorted = true;
            this.comboTipoPrecio.TabIndex = 20;
            // 
            // campoPrecio
            // 
            this.campoPrecio.CampoBD = null;
            this.campoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoPrecio.Limpiar = true;
            this.campoPrecio.Location = new System.Drawing.Point(610, 174);
            this.campoPrecio.Name = "campoPrecio";
            this.campoPrecio.Size = new System.Drawing.Size(100, 21);
            this.campoPrecio.SoloLectura = false;
            this.campoPrecio.TabIndex = 21;
            // 
            // efosLetrero5
            // 
            this.efosLetrero5.AutoSize = true;
            this.efosLetrero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero5.Location = new System.Drawing.Point(45, 154);
            this.efosLetrero5.Name = "efosLetrero5";
            this.efosLetrero5.Size = new System.Drawing.Size(52, 15);
            this.efosLetrero5.TabIndex = 23;
            this.efosLetrero5.Text = "Codigo";
            this.efosLetrero5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero6
            // 
            this.efosLetrero6.AutoSize = true;
            this.efosLetrero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero6.Location = new System.Drawing.Point(232, 154);
            this.efosLetrero6.Name = "efosLetrero6";
            this.efosLetrero6.Size = new System.Drawing.Size(83, 15);
            this.efosLetrero6.TabIndex = 24;
            this.efosLetrero6.Text = "Descripcion";
            this.efosLetrero6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero8
            // 
            this.efosLetrero8.AutoSize = true;
            this.efosLetrero8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero8.Location = new System.Drawing.Point(412, 154);
            this.efosLetrero8.Name = "efosLetrero8";
            this.efosLetrero8.Size = new System.Drawing.Size(80, 15);
            this.efosLetrero8.TabIndex = 26;
            this.efosLetrero8.Text = "Tipo Precio";
            this.efosLetrero8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero9
            // 
            this.efosLetrero9.AutoSize = true;
            this.efosLetrero9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero9.Location = new System.Drawing.Point(636, 154);
            this.efosLetrero9.Name = "efosLetrero9";
            this.efosLetrero9.Size = new System.Drawing.Size(48, 15);
            this.efosLetrero9.TabIndex = 27;
            this.efosLetrero9.Text = "Precio";
            this.efosLetrero9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoCantidad
            // 
            this.campoCantidad.CampoBD = null;
            this.campoCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCantidad.Limpiar = true;
            this.campoCantidad.Location = new System.Drawing.Point(518, 174);
            this.campoCantidad.Name = "campoCantidad";
            this.campoCantidad.Size = new System.Drawing.Size(88, 21);
            this.campoCantidad.SoloLectura = false;
            this.campoCantidad.TabIndex = 28;
            // 
            // efosLetrero10
            // 
            this.efosLetrero10.AutoSize = true;
            this.efosLetrero10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero10.Location = new System.Drawing.Point(530, 154);
            this.efosLetrero10.Name = "efosLetrero10";
            this.efosLetrero10.Size = new System.Drawing.Size(64, 15);
            this.efosLetrero10.TabIndex = 29;
            this.efosLetrero10.Text = "Cantidad";
            this.efosLetrero10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosButtonBuscador2
            // 
            this.efosButtonBuscador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosButtonBuscador2.Image = global::Efos.Properties.Resources.download;
            this.efosButtonBuscador2.Location = new System.Drawing.Point(717, 169);
            this.efosButtonBuscador2.Name = "efosButtonBuscador2";
            this.efosButtonBuscador2.Size = new System.Drawing.Size(35, 30);
            this.efosButtonBuscador2.TabIndex = 30;
            this.efosButtonBuscador2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.efosButtonBuscador2.UseVisualStyleBackColor = true;
            // 
            // efosGroupBox1
            // 
            this.efosGroupBox1.Controls.Add(this.dataGridServicios);
            this.efosGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox1.Location = new System.Drawing.Point(12, 134);
            this.efosGroupBox1.Name = "efosGroupBox1";
            this.efosGroupBox1.Size = new System.Drawing.Size(765, 292);
            this.efosGroupBox1.TabIndex = 31;
            this.efosGroupBox1.TabStop = false;
            this.efosGroupBox1.Text = "Servicios";
            // 
            // dataGridServicios
            // 
            this.dataGridServicios.AllowUserToAddRows = false;
            this.dataGridServicios.AllowUserToDeleteRows = false;
            this.dataGridServicios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridServicios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigoServicio,
            this.columnaDescripcionServicio,
            this.columnaTipoPrecio,
            this.columnaCantidad,
            this.columnaPrecioServicio,
            this.columnaSubTotal,
            this.columnaBotonEliminar});
            this.dataGridServicios.Location = new System.Drawing.Point(12, 68);
            this.dataGridServicios.Name = "dataGridServicios";
            this.dataGridServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridServicios.Size = new System.Drawing.Size(740, 204);
            this.dataGridServicios.StandardTab = true;
            this.dataGridServicios.TabIndex = 0;
            this.dataGridServicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridServicios_CellClick);
            // 
            // columnaCodigoServicio
            // 
            this.columnaCodigoServicio.HeaderText = "Codigo";
            this.columnaCodigoServicio.Name = "columnaCodigoServicio";
            this.columnaCodigoServicio.Width = 75;
            // 
            // columnaDescripcionServicio
            // 
            this.columnaDescripcionServicio.HeaderText = "Descripcion";
            this.columnaDescripcionServicio.Name = "columnaDescripcionServicio";
            this.columnaDescripcionServicio.Width = 180;
            // 
            // columnaTipoPrecio
            // 
            this.columnaTipoPrecio.HeaderText = "Tipo Precio";
            this.columnaTipoPrecio.Name = "columnaTipoPrecio";
            this.columnaTipoPrecio.Width = 125;
            // 
            // columnaCantidad
            // 
            this.columnaCantidad.HeaderText = "Cantidad";
            this.columnaCantidad.Name = "columnaCantidad";
            this.columnaCantidad.Width = 75;
            // 
            // columnaPrecioServicio
            // 
            this.columnaPrecioServicio.HeaderText = "Precio";
            this.columnaPrecioServicio.Name = "columnaPrecioServicio";
            this.columnaPrecioServicio.Width = 75;
            // 
            // columnaSubTotal
            // 
            this.columnaSubTotal.HeaderText = "Sub-Total";
            this.columnaSubTotal.Name = "columnaSubTotal";
            // 
            // columnaBotonEliminar
            // 
            this.columnaBotonEliminar.HeaderText = "Eliminar";
            this.columnaBotonEliminar.Name = "columnaBotonEliminar";
            this.columnaBotonEliminar.Text = "Eliminar";
            this.columnaBotonEliminar.ToolTipText = "Eliminar";
            this.columnaBotonEliminar.UseColumnTextForButtonValue = true;
            this.columnaBotonEliminar.Width = 65;
            // 
            // comboTipoNCF
            // 
            this.comboTipoNCF.CampoBD = null;
            this.comboTipoNCF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoNCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoNCF.FormattingEnabled = true;
            this.comboTipoNCF.Location = new System.Drawing.Point(20, 7);
            this.comboTipoNCF.Name = "comboTipoNCF";
            this.comboTipoNCF.Size = new System.Drawing.Size(175, 23);
            this.comboTipoNCF.Sorted = true;
            this.comboTipoNCF.TabIndex = 32;
            // 
            // efosLetrero7
            // 
            this.efosLetrero7.AutoSize = true;
            this.efosLetrero7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero7.Location = new System.Drawing.Point(570, 11);
            this.efosLetrero7.Name = "efosLetrero7";
            this.efosLetrero7.Size = new System.Drawing.Size(38, 15);
            this.efosLetrero7.TabIndex = 33;
            this.efosLetrero7.Text = "NCF:";
            this.efosLetrero7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // letreroNCF
            // 
            this.letreroNCF.AutoSize = true;
            this.letreroNCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNCF.Location = new System.Drawing.Point(608, 11);
            this.letreroNCF.Name = "letreroNCF";
            this.letreroNCF.Size = new System.Drawing.Size(159, 15);
            this.letreroNCF.TabIndex = 34;
            this.letreroNCF.Text = "A010010100100000001";
            this.letreroNCF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormProcesoOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 523);
            this.Controls.Add(this.letreroNCF);
            this.Controls.Add(this.efosLetrero7);
            this.Controls.Add(this.comboTipoNCF);
            this.Controls.Add(this.efosButtonBuscador2);
            this.Controls.Add(this.efosLetrero10);
            this.Controls.Add(this.campoCantidad);
            this.Controls.Add(this.efosLetrero9);
            this.Controls.Add(this.efosLetrero8);
            this.Controls.Add(this.efosLetrero6);
            this.Controls.Add(this.efosLetrero5);
            this.Controls.Add(this.campoPrecio);
            this.Controls.Add(this.comboTipoPrecio);
            this.Controls.Add(this.campoDescripcioServicio);
            this.Controls.Add(this.lupaServicio);
            this.Controls.Add(this.campoCodigo);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.efosLetrero4);
            this.Controls.Add(this.efosGroupBox1);
            this.Name = "FormProcesoOrdenTrabajo";
            this.Text = "FormProcesoOrdenTrabajo";
            this.Controls.SetChildIndex(this.efosGroupBox1, 0);
            this.Controls.SetChildIndex(this.efosGroupBoxPadre, 0);
            this.Controls.SetChildIndex(this.botonProcesar, 0);
            this.Controls.SetChildIndex(this.botonCancelar, 0);
            this.Controls.SetChildIndex(this.botonBuscar, 0);
            this.Controls.SetChildIndex(this.botonSalir, 0);
            this.Controls.SetChildIndex(this.efosLetrero1, 0);
            this.Controls.SetChildIndex(this.efosLetrero2, 0);
            this.Controls.SetChildIndex(this.txtFechaAsunto, 0);
            this.Controls.SetChildIndex(this.txtNumeroAsunto, 0);
            this.Controls.SetChildIndex(this.txtCodigoPaciente, 0);
            this.Controls.SetChildIndex(this.efosLetrero3, 0);
            this.Controls.SetChildIndex(this.lupaPaciente, 0);
            this.Controls.SetChildIndex(this.lupaAsunto, 0);
            this.Controls.SetChildIndex(this.botonNuevo, 0);
            this.Controls.SetChildIndex(this.letreroNombrePaciente, 0);
            this.Controls.SetChildIndex(this.efosLetrero4, 0);
            this.Controls.SetChildIndex(this.checkEstado, 0);
            this.Controls.SetChildIndex(this.campoCodigo, 0);
            this.Controls.SetChildIndex(this.lupaServicio, 0);
            this.Controls.SetChildIndex(this.campoDescripcioServicio, 0);
            this.Controls.SetChildIndex(this.comboTipoPrecio, 0);
            this.Controls.SetChildIndex(this.campoPrecio, 0);
            this.Controls.SetChildIndex(this.efosLetrero5, 0);
            this.Controls.SetChildIndex(this.efosLetrero6, 0);
            this.Controls.SetChildIndex(this.efosLetrero8, 0);
            this.Controls.SetChildIndex(this.efosLetrero9, 0);
            this.Controls.SetChildIndex(this.campoCantidad, 0);
            this.Controls.SetChildIndex(this.efosLetrero10, 0);
            this.Controls.SetChildIndex(this.efosButtonBuscador2, 0);
            this.Controls.SetChildIndex(this.comboTipoNCF, 0);
            this.Controls.SetChildIndex(this.efosLetrero7, 0);
            this.Controls.SetChildIndex(this.letreroNCF, 0);
            this.efosGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero4;
        private ControlesEfos.efosCheck checkEstado;
        private ControlesEfos.efosCampo campoCodigo;
        private ControlesEfos.efosButtonBuscador lupaServicio;
        private ControlesEfos.efosCampo campoDescripcioServicio;
        private ControlesEfos.efosCombo comboTipoPrecio;
        private ControlesEfos.efosCampo campoPrecio;
        private ControlesEfos.efosLetrero efosLetrero5;
        private ControlesEfos.efosLetrero efosLetrero6;
        private ControlesEfos.efosLetrero efosLetrero8;
        private ControlesEfos.efosLetrero efosLetrero9;
        private ControlesEfos.efosCampo campoCantidad;
        private ControlesEfos.efosLetrero efosLetrero10;
        private ControlesEfos.efosButtonBuscador efosButtonBuscador2;
        private ControlesEfos.efosGroupBox efosGroupBox1;
        private ControlesEfos.efosDataGridView dataGridServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDescripcionServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecioServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonEliminar;
        private ControlesEfos.efosCombo comboTipoNCF;
        private ControlesEfos.efosLetrero efosLetrero7;
        private ControlesEfos.efosLetrero letreroNCF;

    }
}