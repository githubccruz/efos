namespace Efos
{
    partial class FormBaseMantenimientoPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseMantenimientoPersona));
            this.cmpFechaCreacion = new ControlesEfos.efosCampo();
            this.efosLetrero3 = new ControlesEfos.efosLetrero();
            this.tabPanel = new ControlesEfos.efosTabControl();
            this.tabDatosPersonales = new System.Windows.Forms.TabPage();
            this.cmbNacionalidad = new ControlesEfos.efosCombo();
            this.efosLetrero10 = new ControlesEfos.efosLetrero();
            this.cmpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbNivelAcademico = new ControlesEfos.efosCombo();
            this.efosLetrero9 = new ControlesEfos.efosLetrero();
            this.cmbEstadoCivil = new ControlesEfos.efosCombo();
            this.cmbSexo = new ControlesEfos.efosCombo();
            this.cmpApellido2 = new ControlesEfos.efosCampo();
            this.cmpApellido1 = new ControlesEfos.efosCampo();
            this.cmpNombre2 = new ControlesEfos.efosCampo();
            this.cmpNombre1 = new ControlesEfos.efosCampo();
            this.efosLetrero8 = new ControlesEfos.efosLetrero();
            this.efosLetrero7 = new ControlesEfos.efosLetrero();
            this.efosLetrero6 = new ControlesEfos.efosLetrero();
            this.efosLetrero5 = new ControlesEfos.efosLetrero();
            this.efosLetrero4 = new ControlesEfos.efosLetrero();
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.efosLetrero1 = new ControlesEfos.efosLetrero();
            this.tabIdentificacion = new System.Windows.Forms.TabPage();
            this.gridIdentificacion = new ControlesEfos.efosDataGridView();
            this.columnTipoIdentificacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnReferenciaIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonEliminarIdentificacion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabDireccion = new System.Windows.Forms.TabPage();
            this.gridDireccion = new ControlesEfos.efosDataGridView();
            this.columnCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSector = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.botonEliminarDireccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabTelefonos = new System.Windows.Forms.TabPage();
            this.gridTelefono = new ControlesEfos.efosDataGridView();
            this.columnTipoTelefono = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.columnNumeroTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonEliminarTelefono = new System.Windows.Forms.DataGridViewButtonColumn();
            this.efosPanel1 = new ControlesEfos.efosPanel();
            this.efosPanel2 = new ControlesEfos.efosPanel();
            this.imagePerson = new ControlesEfos.efosImage();
            this.tabPanel.SuspendLayout();
            this.tabDatosPersonales.SuspendLayout();
            this.tabIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIdentificacion)).BeginInit();
            this.tabDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDireccion)).BeginInit();
            this.tabTelefonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePerson)).BeginInit();
            this.SuspendLayout();
            // 
            // textTitulo
            // 
            this.textTitulo.Location = new System.Drawing.Point(18, 9);
            this.textTitulo.Size = new System.Drawing.Size(730, 48);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(155, 118);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Validated += new System.EventHandler(this.txtCodigo_Validated);
            // 
            // botonBuscarLupa
            // 
            this.botonBuscarLupa.Location = new System.Drawing.Point(261, 113);
            this.botonBuscarLupa.Click += new System.EventHandler(this.botonBuscarLupa_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.Location = new System.Drawing.Point(37, 121);
            // 
            // checkEstado
            // 
            this.checkEstado.Location = new System.Drawing.Point(152, 436);
            this.checkEstado.TabIndex = 2;
            this.checkEstado.Click += new System.EventHandler(this.checkEstado_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.Location = new System.Drawing.Point(41, 442);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(384, 472);
            this.botonCancelar.TabIndex = 6;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(574, 472);
            this.botonSalir.TabIndex = 8;
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(196, 472);
            this.botonGuardar.TabIndex = 4;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(289, 472);
            this.botonEditar.TabIndex = 5;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(97, 472);
            this.botonNuevo.TabIndex = 3;
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(478, 472);
            this.botonBuscar.TabIndex = 7;
            // 
            // cmpFechaCreacion
            // 
            this.cmpFechaCreacion.CampoBD = null;
            this.cmpFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpFechaCreacion.Limpiar = true;
            this.cmpFechaCreacion.Location = new System.Drawing.Point(489, 118);
            this.cmpFechaCreacion.Name = "cmpFechaCreacion";
            this.cmpFechaCreacion.Size = new System.Drawing.Size(100, 21);
            this.cmpFechaCreacion.SoloLectura = false;
            this.cmpFechaCreacion.TabIndex = 1;
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.AutoSize = true;
            this.efosLetrero3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero3.Location = new System.Drawing.Point(360, 121);
            this.efosLetrero3.Name = "efosLetrero3";
            this.efosLetrero3.Size = new System.Drawing.Size(111, 15);
            this.efosLetrero3.TabIndex = 18;
            this.efosLetrero3.Text = "Fecha Creacion:";
            this.efosLetrero3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabDatosPersonales);
            this.tabPanel.Controls.Add(this.tabIdentificacion);
            this.tabPanel.Controls.Add(this.tabDireccion);
            this.tabPanel.Controls.Add(this.tabTelefonos);
            this.tabPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPanel.Location = new System.Drawing.Point(18, 205);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(730, 223);
            this.tabPanel.TabIndex = 6;
            // 
            // tabDatosPersonales
            // 
            this.tabDatosPersonales.Controls.Add(this.cmbNacionalidad);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero10);
            this.tabDatosPersonales.Controls.Add(this.cmpFechaNacimiento);
            this.tabDatosPersonales.Controls.Add(this.cmbNivelAcademico);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero9);
            this.tabDatosPersonales.Controls.Add(this.cmbEstadoCivil);
            this.tabDatosPersonales.Controls.Add(this.cmbSexo);
            this.tabDatosPersonales.Controls.Add(this.cmpApellido2);
            this.tabDatosPersonales.Controls.Add(this.cmpApellido1);
            this.tabDatosPersonales.Controls.Add(this.cmpNombre2);
            this.tabDatosPersonales.Controls.Add(this.cmpNombre1);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero8);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero7);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero6);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero5);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero4);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero2);
            this.tabDatosPersonales.Controls.Add(this.efosLetrero1);
            this.tabDatosPersonales.Location = new System.Drawing.Point(4, 25);
            this.tabDatosPersonales.Name = "tabDatosPersonales";
            this.tabDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosPersonales.Size = new System.Drawing.Size(722, 194);
            this.tabDatosPersonales.TabIndex = 0;
            this.tabDatosPersonales.Text = "Datos Personales";
            this.tabDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // cmbNacionalidad
            // 
            this.cmbNacionalidad.CampoBD = null;
            this.cmbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNacionalidad.FormattingEnabled = true;
            this.cmbNacionalidad.Location = new System.Drawing.Point(130, 133);
            this.cmbNacionalidad.Name = "cmbNacionalidad";
            this.cmbNacionalidad.Size = new System.Drawing.Size(199, 23);
            this.cmbNacionalidad.Sorted = true;
            this.cmbNacionalidad.TabIndex = 6;
            // 
            // efosLetrero10
            // 
            this.efosLetrero10.AutoSize = true;
            this.efosLetrero10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero10.Location = new System.Drawing.Point(18, 137);
            this.efosLetrero10.Name = "efosLetrero10";
            this.efosLetrero10.Size = new System.Drawing.Size(96, 15);
            this.efosLetrero10.TabIndex = 8;
            this.efosLetrero10.Text = "Nacionalidad:";
            this.efosLetrero10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmpFechaNacimiento
            // 
            this.cmpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmpFechaNacimiento.Location = new System.Drawing.Point(132, 165);
            this.cmpFechaNacimiento.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.cmpFechaNacimiento.Name = "cmpFechaNacimiento";
            this.cmpFechaNacimiento.Size = new System.Drawing.Size(197, 23);
            this.cmpFechaNacimiento.TabIndex = 8;
            this.cmpFechaNacimiento.Value = new System.DateTime(1980, 2, 27, 0, 0, 0, 0);
            // 
            // cmbNivelAcademico
            // 
            this.cmbNivelAcademico.CampoBD = null;
            this.cmbNivelAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelAcademico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNivelAcademico.FormattingEnabled = true;
            this.cmbNivelAcademico.Location = new System.Drawing.Point(467, 133);
            this.cmbNivelAcademico.Name = "cmbNivelAcademico";
            this.cmbNivelAcademico.Size = new System.Drawing.Size(199, 23);
            this.cmbNivelAcademico.Sorted = true;
            this.cmbNivelAcademico.TabIndex = 7;
            // 
            // efosLetrero9
            // 
            this.efosLetrero9.AutoSize = true;
            this.efosLetrero9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero9.Location = new System.Drawing.Point(341, 137);
            this.efosLetrero9.Name = "efosLetrero9";
            this.efosLetrero9.Size = new System.Drawing.Size(117, 15);
            this.efosLetrero9.TabIndex = 7;
            this.efosLetrero9.Text = "Nivel Academico:";
            this.efosLetrero9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.CampoBD = null;
            this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(132, 98);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(199, 23);
            this.cmbEstadoCivil.Sorted = true;
            this.cmbEstadoCivil.TabIndex = 4;
            // 
            // cmbSexo
            // 
            this.cmbSexo.CampoBD = null;
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(467, 98);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(199, 23);
            this.cmbSexo.Sorted = true;
            this.cmbSexo.TabIndex = 5;
            // 
            // cmpApellido2
            // 
            this.cmpApellido2.CampoBD = null;
            this.cmpApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpApellido2.Limpiar = true;
            this.cmpApellido2.Location = new System.Drawing.Point(467, 61);
            this.cmpApellido2.Name = "cmpApellido2";
            this.cmpApellido2.Size = new System.Drawing.Size(199, 21);
            this.cmpApellido2.SoloLectura = false;
            this.cmpApellido2.TabIndex = 3;
            // 
            // cmpApellido1
            // 
            this.cmpApellido1.CampoBD = null;
            this.cmpApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpApellido1.Limpiar = true;
            this.cmpApellido1.Location = new System.Drawing.Point(132, 61);
            this.cmpApellido1.Name = "cmpApellido1";
            this.cmpApellido1.Size = new System.Drawing.Size(199, 21);
            this.cmpApellido1.SoloLectura = false;
            this.cmpApellido1.TabIndex = 2;
            // 
            // cmpNombre2
            // 
            this.cmpNombre2.CampoBD = null;
            this.cmpNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpNombre2.Limpiar = true;
            this.cmpNombre2.Location = new System.Drawing.Point(467, 24);
            this.cmpNombre2.Name = "cmpNombre2";
            this.cmpNombre2.Size = new System.Drawing.Size(199, 21);
            this.cmpNombre2.SoloLectura = false;
            this.cmpNombre2.TabIndex = 1;
            // 
            // cmpNombre1
            // 
            this.cmpNombre1.CampoBD = null;
            this.cmpNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpNombre1.Limpiar = true;
            this.cmpNombre1.Location = new System.Drawing.Point(133, 24);
            this.cmpNombre1.Name = "cmpNombre1";
            this.cmpNombre1.Size = new System.Drawing.Size(199, 21);
            this.cmpNombre1.SoloLectura = false;
            this.cmpNombre1.TabIndex = 0;
            // 
            // efosLetrero8
            // 
            this.efosLetrero8.AutoSize = true;
            this.efosLetrero8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero8.Location = new System.Drawing.Point(18, 64);
            this.efosLetrero8.Name = "efosLetrero8";
            this.efosLetrero8.Size = new System.Drawing.Size(110, 15);
            this.efosLetrero8.TabIndex = 7;
            this.efosLetrero8.Text = "Primer Apellido:";
            this.efosLetrero8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero7
            // 
            this.efosLetrero7.AutoSize = true;
            this.efosLetrero7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero7.Location = new System.Drawing.Point(341, 27);
            this.efosLetrero7.Name = "efosLetrero7";
            this.efosLetrero7.Size = new System.Drawing.Size(123, 15);
            this.efosLetrero7.TabIndex = 6;
            this.efosLetrero7.Text = "Segundo Nombre:";
            this.efosLetrero7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero6
            // 
            this.efosLetrero6.AutoSize = true;
            this.efosLetrero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero6.Location = new System.Drawing.Point(341, 64);
            this.efosLetrero6.Name = "efosLetrero6";
            this.efosLetrero6.Size = new System.Drawing.Size(124, 15);
            this.efosLetrero6.TabIndex = 5;
            this.efosLetrero6.Text = "Segundo Apellido:";
            this.efosLetrero6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero5
            // 
            this.efosLetrero5.AutoSize = true;
            this.efosLetrero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero5.Location = new System.Drawing.Point(17, 169);
            this.efosLetrero5.Name = "efosLetrero5";
            this.efosLetrero5.Size = new System.Drawing.Size(83, 15);
            this.efosLetrero5.TabIndex = 4;
            this.efosLetrero5.Text = "Fecha Nac.:";
            this.efosLetrero5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero4
            // 
            this.efosLetrero4.AutoSize = true;
            this.efosLetrero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero4.Location = new System.Drawing.Point(341, 102);
            this.efosLetrero4.Name = "efosLetrero4";
            this.efosLetrero4.Size = new System.Drawing.Size(43, 15);
            this.efosLetrero4.TabIndex = 3;
            this.efosLetrero4.Text = "Sexo:";
            this.efosLetrero4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(18, 102);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(86, 15);
            this.efosLetrero2.TabIndex = 1;
            this.efosLetrero2.Text = "Estado Civil:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(18, 27);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(109, 15);
            this.efosLetrero1.TabIndex = 0;
            this.efosLetrero1.Text = "Primer Nombre:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabIdentificacion
            // 
            this.tabIdentificacion.Controls.Add(this.gridIdentificacion);
            this.tabIdentificacion.Location = new System.Drawing.Point(4, 25);
            this.tabIdentificacion.Name = "tabIdentificacion";
            this.tabIdentificacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabIdentificacion.Size = new System.Drawing.Size(722, 194);
            this.tabIdentificacion.TabIndex = 3;
            this.tabIdentificacion.Text = "Identificacion";
            this.tabIdentificacion.UseVisualStyleBackColor = true;
            // 
            // gridIdentificacion
            // 
            this.gridIdentificacion.AllowUserToResizeRows = false;
            this.gridIdentificacion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridIdentificacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridIdentificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIdentificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTipoIdentificacion,
            this.columnReferenciaIdentificacion,
            this.botonEliminarIdentificacion});
            this.gridIdentificacion.GridColor = System.Drawing.SystemColors.Control;
            this.gridIdentificacion.Location = new System.Drawing.Point(79, 6);
            this.gridIdentificacion.Name = "gridIdentificacion";
            this.gridIdentificacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridIdentificacion.Size = new System.Drawing.Size(573, 182);
            this.gridIdentificacion.StandardTab = true;
            this.gridIdentificacion.TabIndex = 0;
            this.gridIdentificacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridIdentificacion_CellClick);
            // 
            // columnTipoIdentificacion
            // 
            this.columnTipoIdentificacion.FillWeight = 10.25483F;
            this.columnTipoIdentificacion.HeaderText = "Tipo Identificacion";
            this.columnTipoIdentificacion.Name = "columnTipoIdentificacion";
            this.columnTipoIdentificacion.Width = 250;
            // 
            // columnReferenciaIdentificacion
            // 
            this.columnReferenciaIdentificacion.FillWeight = 284.7716F;
            this.columnReferenciaIdentificacion.HeaderText = "Referencia";
            this.columnReferenciaIdentificacion.Name = "columnReferenciaIdentificacion";
            this.columnReferenciaIdentificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnReferenciaIdentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnReferenciaIdentificacion.Width = 200;
            // 
            // botonEliminarIdentificacion
            // 
            this.botonEliminarIdentificacion.FillWeight = 4.973593F;
            this.botonEliminarIdentificacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.botonEliminarIdentificacion.HeaderText = "Eliminar";
            this.botonEliminarIdentificacion.Name = "botonEliminarIdentificacion";
            this.botonEliminarIdentificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.botonEliminarIdentificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.botonEliminarIdentificacion.Text = "Eliminar";
            this.botonEliminarIdentificacion.ToolTipText = "Click para Eliminar la Fila";
            this.botonEliminarIdentificacion.UseColumnTextForButtonValue = true;
            this.botonEliminarIdentificacion.Width = 80;
            // 
            // tabDireccion
            // 
            this.tabDireccion.Controls.Add(this.gridDireccion);
            this.tabDireccion.Location = new System.Drawing.Point(4, 25);
            this.tabDireccion.Name = "tabDireccion";
            this.tabDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDireccion.Size = new System.Drawing.Size(722, 194);
            this.tabDireccion.TabIndex = 1;
            this.tabDireccion.Text = "Direccion";
            this.tabDireccion.UseVisualStyleBackColor = true;
            // 
            // gridDireccion
            // 
            this.gridDireccion.AllowUserToResizeRows = false;
            this.gridDireccion.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridDireccion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridDireccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDireccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCalle,
            this.columnaCasa,
            this.columnHabitacion,
            this.columnNivel,
            this.columnSector,
            this.botonEliminarDireccion});
            this.gridDireccion.GridColor = System.Drawing.SystemColors.Control;
            this.gridDireccion.Location = new System.Drawing.Point(14, 6);
            this.gridDireccion.Name = "gridDireccion";
            this.gridDireccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridDireccion.Size = new System.Drawing.Size(695, 182);
            this.gridDireccion.StandardTab = true;
            this.gridDireccion.TabIndex = 0;
            this.gridDireccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDireccion_CellContentClick);
            // 
            // columnCalle
            // 
            this.columnCalle.FillWeight = 74.23858F;
            this.columnCalle.HeaderText = "Calle";
            this.columnCalle.Name = "columnCalle";
            this.columnCalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnCalle.Width = 150;
            // 
            // columnaCasa
            // 
            this.columnaCasa.HeaderText = "Casa";
            this.columnaCasa.Name = "columnaCasa";
            this.columnaCasa.Width = 50;
            // 
            // columnHabitacion
            // 
            this.columnHabitacion.FillWeight = 74.23858F;
            this.columnHabitacion.HeaderText = "Habitacion";
            this.columnHabitacion.Name = "columnHabitacion";
            this.columnHabitacion.Width = 90;
            // 
            // columnNivel
            // 
            this.columnNivel.FillWeight = 74.23858F;
            this.columnNivel.HeaderText = "Nivel";
            this.columnNivel.Name = "columnNivel";
            this.columnNivel.Width = 50;
            // 
            // columnSector
            // 
            this.columnSector.FillWeight = 74.23858F;
            this.columnSector.HeaderText = "Sector";
            this.columnSector.Name = "columnSector";
            this.columnSector.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnSector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnSector.Width = 230;
            // 
            // botonEliminarDireccion
            // 
            this.botonEliminarDireccion.FillWeight = 203.0457F;
            this.botonEliminarDireccion.HeaderText = "Eliminar";
            this.botonEliminarDireccion.Name = "botonEliminarDireccion";
            this.botonEliminarDireccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.botonEliminarDireccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.botonEliminarDireccion.Text = "Eliminar";
            this.botonEliminarDireccion.ToolTipText = "Click para Eliminar la Fila";
            this.botonEliminarDireccion.UseColumnTextForButtonValue = true;
            this.botonEliminarDireccion.Width = 80;
            // 
            // tabTelefonos
            // 
            this.tabTelefonos.Controls.Add(this.gridTelefono);
            this.tabTelefonos.Location = new System.Drawing.Point(4, 25);
            this.tabTelefonos.Name = "tabTelefonos";
            this.tabTelefonos.Padding = new System.Windows.Forms.Padding(3);
            this.tabTelefonos.Size = new System.Drawing.Size(722, 194);
            this.tabTelefonos.TabIndex = 2;
            this.tabTelefonos.Text = "Telefonos";
            this.tabTelefonos.UseVisualStyleBackColor = true;
            // 
            // gridTelefono
            // 
            this.gridTelefono.AllowUserToResizeRows = false;
            this.gridTelefono.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridTelefono.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.gridTelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTelefono.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnTipoTelefono,
            this.columnNumeroTelefono,
            this.botonEliminarTelefono});
            this.gridTelefono.Location = new System.Drawing.Point(161, 6);
            this.gridTelefono.Name = "gridTelefono";
            this.gridTelefono.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridTelefono.Size = new System.Drawing.Size(423, 181);
            this.gridTelefono.StandardTab = true;
            this.gridTelefono.TabIndex = 0;
            this.gridTelefono.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTelefono_CellContentClick);
            // 
            // columnTipoTelefono
            // 
            this.columnTipoTelefono.FillWeight = 89.0863F;
            this.columnTipoTelefono.HeaderText = "Tipo Telefono";
            this.columnTipoTelefono.Name = "columnTipoTelefono";
            this.columnTipoTelefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.columnTipoTelefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnTipoTelefono.Width = 150;
            // 
            // columnNumeroTelefono
            // 
            this.columnNumeroTelefono.FillWeight = 89.0863F;
            this.columnNumeroTelefono.HeaderText = "Numero";
            this.columnNumeroTelefono.Name = "columnNumeroTelefono";
            this.columnNumeroTelefono.Width = 150;
            // 
            // botonEliminarTelefono
            // 
            this.botonEliminarTelefono.FillWeight = 121.8274F;
            this.botonEliminarTelefono.HeaderText = "Eliminar";
            this.botonEliminarTelefono.Name = "botonEliminarTelefono";
            this.botonEliminarTelefono.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.botonEliminarTelefono.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.botonEliminarTelefono.Text = "Eliminar";
            this.botonEliminarTelefono.ToolTipText = "Click para Eliminar la Fila";
            this.botonEliminarTelefono.UseColumnTextForButtonValue = true;
            this.botonEliminarTelefono.Width = 80;
            // 
            // efosPanel1
            // 
            this.efosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel1.Location = new System.Drawing.Point(20, 87);
            this.efosPanel1.Name = "efosPanel1";
            this.efosPanel1.Size = new System.Drawing.Size(577, 85);
            this.efosPanel1.TabIndex = 20;
            // 
            // efosPanel2
            // 
            this.efosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.efosPanel2.Location = new System.Drawing.Point(19, 432);
            this.efosPanel2.Name = "efosPanel2";
            this.efosPanel2.Size = new System.Drawing.Size(274, 36);
            this.efosPanel2.TabIndex = 21;
            // 
            // imagePerson
            // 
            this.imagePerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imagePerson.Enabled = false;
            this.imagePerson.Image = ((System.Drawing.Image)(resources.GetObject("imagePerson.Image")));
            this.imagePerson.InitialImage = ((System.Drawing.Image)(resources.GetObject("imagePerson.InitialImage")));
            this.imagePerson.Location = new System.Drawing.Point(608, 60);
            this.imagePerson.Name = "imagePerson";
            this.imagePerson.RutaImagen = null;
            this.imagePerson.Size = new System.Drawing.Size(133, 137);
            this.imagePerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePerson.TabIndex = 22;
            this.imagePerson.TabStop = false;
            this.imagePerson.Click += new System.EventHandler(this.imagePerson_Click);
            // 
            // FormBaseMantenimientoPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 531);
            this.Controls.Add(this.cmpFechaCreacion);
            this.Controls.Add(this.efosLetrero3);
            this.Controls.Add(this.imagePerson);
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.efosPanel2);
            this.Controls.Add(this.efosPanel1);
            this.Name = "FormBaseMantenimientoPersona";
            this.Text = "FormMantenimientoPersona";
            this.Controls.SetChildIndex(this.efosPanel1, 0);
            this.Controls.SetChildIndex(this.efosPanel2, 0);
            this.Controls.SetChildIndex(this.botonNuevo, 0);
            this.Controls.SetChildIndex(this.botonEditar, 0);
            this.Controls.SetChildIndex(this.botonGuardar, 0);
            this.Controls.SetChildIndex(this.botonCancelar, 0);
            this.Controls.SetChildIndex(this.botonBuscar, 0);
            this.Controls.SetChildIndex(this.botonSalir, 0);
            this.Controls.SetChildIndex(this.textTitulo, 0);
            this.Controls.SetChildIndex(this.tabPanel, 0);
            this.Controls.SetChildIndex(this.imagePerson, 0);
            this.Controls.SetChildIndex(this.labelEstado, 0);
            this.Controls.SetChildIndex(this.checkEstado, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.botonBuscarLupa, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.efosLetrero3, 0);
            this.Controls.SetChildIndex(this.cmpFechaCreacion, 0);
            this.tabPanel.ResumeLayout(false);
            this.tabDatosPersonales.ResumeLayout(false);
            this.tabDatosPersonales.PerformLayout();
            this.tabIdentificacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIdentificacion)).EndInit();
            this.tabDireccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDireccion)).EndInit();
            this.tabTelefonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabDireccion;
        private System.Windows.Forms.TabPage tabTelefonos;
        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosLetrero efosLetrero8;
        private ControlesEfos.efosLetrero efosLetrero7;
        private ControlesEfos.efosLetrero efosLetrero6;
        private ControlesEfos.efosLetrero efosLetrero5;
        private ControlesEfos.efosLetrero efosLetrero4;
        private ControlesEfos.efosLetrero efosLetrero2;
        private System.Windows.Forms.TabPage tabIdentificacion;
        private ControlesEfos.efosCampo cmpApellido2;
        private ControlesEfos.efosCampo cmpApellido1;
        private ControlesEfos.efosCampo cmpNombre2;
        private ControlesEfos.efosCampo cmpNombre1;
        private ControlesEfos.efosCombo cmbEstadoCivil;
        private ControlesEfos.efosCombo cmbSexo;
        private ControlesEfos.efosLetrero efosLetrero3;
        private ControlesEfos.efosCampo cmpFechaCreacion;
        private ControlesEfos.efosPanel efosPanel1;
        private ControlesEfos.efosDataGridView gridDireccion;
        private ControlesEfos.efosDataGridView gridIdentificacion;
        private ControlesEfos.efosDataGridView gridTelefono;
        private ControlesEfos.efosCombo cmbNivelAcademico;
        private ControlesEfos.efosLetrero efosLetrero9;
        private ControlesEfos.efosImage imagePerson;
        public ControlesEfos.efosTabControl tabPanel;
        private System.Windows.Forms.DateTimePicker cmpFechaNacimiento;
        private ControlesEfos.efosCombo cmbNacionalidad;
        private ControlesEfos.efosLetrero efosLetrero10;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnTipoIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnReferenciaIdentificacion;
        private System.Windows.Forms.DataGridViewButtonColumn botonEliminarIdentificacion;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnTipoTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNumeroTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn botonEliminarTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNivel;
        private System.Windows.Forms.DataGridViewComboBoxColumn columnSector;
        private System.Windows.Forms.DataGridViewButtonColumn botonEliminarDireccion;
        public System.Windows.Forms.TabPage tabDatosPersonales;
        public ControlesEfos.efosPanel efosPanel2;
    }
}