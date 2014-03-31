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
            this.botonAgregar = new ControlesEfos.efosButtonBuscador();
            this.efosGroupBox1 = new ControlesEfos.efosGroupBox();
            this.efosLetrero13 = new ControlesEfos.efosLetrero();
            this.efosLetrero12 = new ControlesEfos.efosLetrero();
            this.lupaDoctor = new ControlesEfos.efosButtonBuscador();
            this.campoDescripcionDoctor = new ControlesEfos.efosCampo();
            this.campoCodigoDoctor = new ControlesEfos.efosCampo();
            this.dataGridServicios = new ControlesEfos.efosDataGridView();
            this.columnaCodigoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDescripcionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCodigoTipoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTipoPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecioServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCodigoDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombreDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBotonEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboTipoNCF = new ControlesEfos.efosCombo();
            this.efosLetrero7 = new ControlesEfos.efosLetrero();
            this.letreroNCF = new ControlesEfos.efosLetrero();
            this.efosGroupBox2 = new ControlesEfos.efosGroupBox();
            this.efosLetrero11 = new ControlesEfos.efosLetrero();
            this.efosCampo1 = new ControlesEfos.efosCampo();
            this.efosGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).BeginInit();
            this.efosGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonProcesar
            // 
            this.botonProcesar.Location = new System.Drawing.Point(448, 442);
            this.botonProcesar.Click += new System.EventHandler(this.botonProcesar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(550, 442);
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(658, 442);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(760, 442);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(342, 442);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.Location = new System.Drawing.Point(22, 48);
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.Location = new System.Drawing.Point(942, 48);
            // 
            // txtFechaAsunto
            // 
            this.txtFechaAsunto.Location = new System.Drawing.Point(1066, 45);
            // 
            // txtNumeroAsunto
            // 
            this.txtNumeroAsunto.Location = new System.Drawing.Point(189, 45);
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Location = new System.Drawing.Point(189, 88);
            this.txtCodigoPaciente.Validated += new System.EventHandler(this.txtCodigoPaciente_Validated);
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.Location = new System.Drawing.Point(22, 91);
            // 
            // lupaPaciente
            // 
            this.lupaPaciente.Location = new System.Drawing.Point(153, 83);
            this.lupaPaciente.Click += new System.EventHandler(this.lupaPaciente_Click);
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
            this.efosGroupBoxPadre.Size = new System.Drawing.Size(1168, 100);
            // 
            // campoCodigo
            // 
            this.campoCodigo.CampoBD = "codiserv";
            this.campoCodigo.Enabled = false;
            this.campoCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodigo.Limpiar = true;
            this.campoCodigo.Location = new System.Drawing.Point(37, 174);
            this.campoCodigo.Name = "campoCodigo";
            this.campoCodigo.Size = new System.Drawing.Size(71, 21);
            this.campoCodigo.SoloLectura = false;
            this.campoCodigo.TabIndex = 16;
            this.campoCodigo.Validated += new System.EventHandler(this.campoCodigo_Validated);
            // 
            // lupaServicio
            // 
            this.lupaServicio.Enabled = false;
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
            this.campoDescripcioServicio.CampoBD = "descserv";
            this.campoDescripcioServicio.Enabled = false;
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
            this.comboTipoPrecio.DisplayMember = "coditips";
            this.comboTipoPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPrecio.Enabled = false;
            this.comboTipoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoPrecio.FormattingEnabled = true;
            this.comboTipoPrecio.Location = new System.Drawing.Point(392, 173);
            this.comboTipoPrecio.Name = "comboTipoPrecio";
            this.comboTipoPrecio.Size = new System.Drawing.Size(121, 23);
            this.comboTipoPrecio.Sorted = true;
            this.comboTipoPrecio.TabIndex = 20;
            this.comboTipoPrecio.ValueMember = "coditips";
            this.comboTipoPrecio.SelectedIndexChanged += new System.EventHandler(this.comboTipoPrecio_SelectedIndexChanged);
            // 
            // campoPrecio
            // 
            this.campoPrecio.CampoBD = "precserv";
            this.campoPrecio.Enabled = false;
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
            this.campoCantidad.Enabled = false;
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
            // botonAgregar
            // 
            this.botonAgregar.Enabled = false;
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.Image = global::Efos.Properties.Resources.download;
            this.botonAgregar.Location = new System.Drawing.Point(1124, 36);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(35, 30);
            this.botonAgregar.TabIndex = 30;
            this.botonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.efosButtonBuscador2_Click);
            // 
            // efosGroupBox1
            // 
            this.efosGroupBox1.Controls.Add(this.efosLetrero13);
            this.efosGroupBox1.Controls.Add(this.efosLetrero12);
            this.efosGroupBox1.Controls.Add(this.lupaDoctor);
            this.efosGroupBox1.Controls.Add(this.campoDescripcionDoctor);
            this.efosGroupBox1.Controls.Add(this.campoCodigoDoctor);
            this.efosGroupBox1.Controls.Add(this.dataGridServicios);
            this.efosGroupBox1.Controls.Add(this.botonAgregar);
            this.efosGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox1.Location = new System.Drawing.Point(12, 134);
            this.efosGroupBox1.Name = "efosGroupBox1";
            this.efosGroupBox1.Size = new System.Drawing.Size(1168, 292);
            this.efosGroupBox1.TabIndex = 31;
            this.efosGroupBox1.TabStop = false;
            this.efosGroupBox1.Text = "Servicios";
            // 
            // efosLetrero13
            // 
            this.efosLetrero13.AutoSize = true;
            this.efosLetrero13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero13.Location = new System.Drawing.Point(934, 23);
            this.efosLetrero13.Name = "efosLetrero13";
            this.efosLetrero13.Size = new System.Drawing.Size(128, 15);
            this.efosLetrero13.TabIndex = 38;
            this.efosLetrero13.Text = "Nombre del Doctor";
            this.efosLetrero13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero12
            // 
            this.efosLetrero12.AutoSize = true;
            this.efosLetrero12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero12.Location = new System.Drawing.Point(719, 21);
            this.efosLetrero12.Name = "efosLetrero12";
            this.efosLetrero12.Size = new System.Drawing.Size(82, 15);
            this.efosLetrero12.TabIndex = 36;
            this.efosLetrero12.Text = "Cod. Doctor";
            this.efosLetrero12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lupaDoctor
            // 
            this.lupaDoctor.Enabled = false;
            this.lupaDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lupaDoctor.Image = ((System.Drawing.Image)(resources.GetObject("lupaDoctor.Image")));
            this.lupaDoctor.Location = new System.Drawing.Point(804, 36);
            this.lupaDoctor.Name = "lupaDoctor";
            this.lupaDoctor.Size = new System.Drawing.Size(35, 30);
            this.lupaDoctor.TabIndex = 36;
            this.lupaDoctor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lupaDoctor.UseVisualStyleBackColor = true;
            // 
            // campoDescripcionDoctor
            // 
            this.campoDescripcionDoctor.CampoBD = "precserv";
            this.campoDescripcionDoctor.Enabled = false;
            this.campoDescripcionDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDescripcionDoctor.Limpiar = true;
            this.campoDescripcionDoctor.Location = new System.Drawing.Point(846, 41);
            this.campoDescripcionDoctor.Name = "campoDescripcionDoctor";
            this.campoDescripcionDoctor.Size = new System.Drawing.Size(274, 21);
            this.campoDescripcionDoctor.SoloLectura = false;
            this.campoDescripcionDoctor.TabIndex = 37;
            // 
            // campoCodigoDoctor
            // 
            this.campoCodigoDoctor.CampoBD = "precserv";
            this.campoCodigoDoctor.Enabled = false;
            this.campoCodigoDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoCodigoDoctor.Limpiar = true;
            this.campoCodigoDoctor.Location = new System.Drawing.Point(714, 40);
            this.campoCodigoDoctor.Name = "campoCodigoDoctor";
            this.campoCodigoDoctor.Size = new System.Drawing.Size(87, 21);
            this.campoCodigoDoctor.SoloLectura = false;
            this.campoCodigoDoctor.TabIndex = 36;
            this.campoCodigoDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoCodigoDoctor_KeyPress);
            this.campoCodigoDoctor.Validated += new System.EventHandler(this.campoCodigoDoctor_Validated);
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
            this.columnaCodigoTipoPrecio,
            this.columnaTipoPrecio,
            this.columnaCantidad,
            this.columnaPrecioServicio,
            this.columnaSubTotal,
            this.columnaCodigoDoctor,
            this.columnaNombreDoctor,
            this.columnaBotonEliminar});
            this.dataGridServicios.Enabled = false;
            this.dataGridServicios.Location = new System.Drawing.Point(12, 68);
            this.dataGridServicios.Name = "dataGridServicios";
            this.dataGridServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridServicios.Size = new System.Drawing.Size(1150, 204);
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
            // columnaCodigoTipoPrecio
            // 
            this.columnaCodigoTipoPrecio.HeaderText = "Column1";
            this.columnaCodigoTipoPrecio.Name = "columnaCodigoTipoPrecio";
            this.columnaCodigoTipoPrecio.Visible = false;
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
            this.columnaSubTotal.Width = 110;
            // 
            // columnaCodigoDoctor
            // 
            this.columnaCodigoDoctor.HeaderText = "codigoDoctor";
            this.columnaCodigoDoctor.Name = "columnaCodigoDoctor";
            this.columnaCodigoDoctor.Visible = false;
            // 
            // columnaNombreDoctor
            // 
            this.columnaNombreDoctor.HeaderText = "Doctor";
            this.columnaNombreDoctor.Name = "columnaNombreDoctor";
            this.columnaNombreDoctor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnaNombreDoctor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnaNombreDoctor.Width = 400;
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
            // efosGroupBox2
            // 
            this.efosGroupBox2.Controls.Add(this.efosLetrero11);
            this.efosGroupBox2.Controls.Add(this.efosCampo1);
            this.efosGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox2.Location = new System.Drawing.Point(945, 439);
            this.efosGroupBox2.Name = "efosGroupBox2";
            this.efosGroupBox2.Size = new System.Drawing.Size(235, 47);
            this.efosGroupBox2.TabIndex = 35;
            this.efosGroupBox2.TabStop = false;
            // 
            // efosLetrero11
            // 
            this.efosLetrero11.AutoSize = true;
            this.efosLetrero11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero11.Location = new System.Drawing.Point(24, 20);
            this.efosLetrero11.Name = "efosLetrero11";
            this.efosLetrero11.Size = new System.Drawing.Size(43, 15);
            this.efosLetrero11.TabIndex = 1;
            this.efosLetrero11.Text = "Total:";
            this.efosLetrero11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosCampo1
            // 
            this.efosCampo1.CampoBD = null;
            this.efosCampo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo1.Limpiar = true;
            this.efosCampo1.Location = new System.Drawing.Point(86, 17);
            this.efosCampo1.Name = "efosCampo1";
            this.efosCampo1.Size = new System.Drawing.Size(140, 21);
            this.efosCampo1.SoloLectura = false;
            this.efosCampo1.TabIndex = 0;
            // 
            // FormProcesoOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 500);
            this.Controls.Add(this.efosGroupBox2);
            this.Controls.Add(this.letreroNCF);
            this.Controls.Add(this.efosLetrero7);
            this.Controls.Add(this.comboTipoNCF);
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
            this.Controls.SetChildIndex(this.comboTipoNCF, 0);
            this.Controls.SetChildIndex(this.efosLetrero7, 0);
            this.Controls.SetChildIndex(this.letreroNCF, 0);
            this.Controls.SetChildIndex(this.efosGroupBox2, 0);
            this.efosGroupBox1.ResumeLayout(false);
            this.efosGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicios)).EndInit();
            this.efosGroupBox2.ResumeLayout(false);
            this.efosGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private ControlesEfos.efosButtonBuscador botonAgregar;
        private ControlesEfos.efosGroupBox efosGroupBox1;
        private ControlesEfos.efosDataGridView dataGridServicios;
        private ControlesEfos.efosCombo comboTipoNCF;
        private ControlesEfos.efosLetrero efosLetrero7;
        private ControlesEfos.efosLetrero letreroNCF;
        private ControlesEfos.efosLetrero efosLetrero13;
        private ControlesEfos.efosLetrero efosLetrero12;
        private ControlesEfos.efosButtonBuscador lupaDoctor;
        private ControlesEfos.efosCampo campoDescripcionDoctor;
        private ControlesEfos.efosCampo campoCodigoDoctor;
        private ControlesEfos.efosGroupBox efosGroupBox2;
        private ControlesEfos.efosLetrero efosLetrero11;
        private ControlesEfos.efosCampo efosCampo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDescripcionServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigoTipoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTipoPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecioServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigoDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombreDoctor;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonEliminar;

    }
}