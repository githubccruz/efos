namespace Efos
{
    partial class FormBaseConsultaPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseConsultaPersona));
            this.efosLetrero1 = new ControlesEfos.efosLetrero();
            this.efosGroupBox1 = new ControlesEfos.efosGroupBox();
            this.radioFechaNacimiento = new ControlesEfos.efosRadioButton();
            this.radioNombre = new ControlesEfos.efosRadioButton();
            this.DataGrid = new ControlesEfos.efosDataGridView();
            this.columnaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efosButtonSeleccionar1 = new ControlesEfos.efosButtonSeleccionar();
            this.efosButtonCancelar1 = new ControlesEfos.efosButtonCancelar();
            this.efosLetrero2 = new ControlesEfos.efosLetrero();
            this.efosButtonBuscador1 = new ControlesEfos.efosButtonBuscador();
            this.campoBusqueda = new ControlesEfos.efosCampo();
            this.textoFormato = new ControlesEfos.efosLetrero();
            this.efosGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.efosLetrero1.Location = new System.Drawing.Point(12, 20);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(810, 23);
            this.efosLetrero1.TabIndex = 0;
            this.efosLetrero1.Text = "efosLetrero1";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // efosGroupBox1
            // 
            this.efosGroupBox1.Controls.Add(this.radioFechaNacimiento);
            this.efosGroupBox1.Controls.Add(this.radioNombre);
            this.efosGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox1.Location = new System.Drawing.Point(112, 58);
            this.efosGroupBox1.Name = "efosGroupBox1";
            this.efosGroupBox1.Size = new System.Drawing.Size(610, 60);
            this.efosGroupBox1.TabIndex = 1;
            this.efosGroupBox1.TabStop = false;
            this.efosGroupBox1.Text = "Opciones de Busqueda";
            this.efosGroupBox1.Enter += new System.EventHandler(this.efosGroupBox1_Enter);
            // 
            // radioFechaNacimiento
            // 
            this.radioFechaNacimiento.AutoSize = true;
            this.radioFechaNacimiento.Location = new System.Drawing.Point(325, 24);
            this.radioFechaNacimiento.Name = "radioFechaNacimiento";
            this.radioFechaNacimiento.Size = new System.Drawing.Size(155, 21);
            this.radioFechaNacimiento.TabIndex = 1;
            this.radioFechaNacimiento.TabStop = true;
            this.radioFechaNacimiento.Text = "Fecha Nacimiento";
            this.radioFechaNacimiento.UseVisualStyleBackColor = true;
            this.radioFechaNacimiento.Click += new System.EventHandler(this.radioFechaNacimiento_Click);
            // 
            // radioNombre
            // 
            this.radioNombre.AutoSize = true;
            this.radioNombre.Location = new System.Drawing.Point(131, 24);
            this.radioNombre.Name = "radioNombre";
            this.radioNombre.Size = new System.Drawing.Size(171, 21);
            this.radioNombre.TabIndex = 0;
            this.radioNombre.TabStop = true;
            this.radioNombre.Text = "Nombres / Apellidos";
            this.radioNombre.UseVisualStyleBackColor = true;
            this.radioNombre.Click += new System.EventHandler(this.radioNombre_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaCodigo,
            this.columnaNombre,
            this.columnaNacionalidad,
            this.columnaSexo,
            this.columnaFechaNacimiento,
            this.columnaEstado});
            this.DataGrid.Location = new System.Drawing.Point(9, 156);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGrid.Size = new System.Drawing.Size(825, 223);
            this.DataGrid.StandardTab = true;
            this.DataGrid.TabIndex = 2;
            // 
            // columnaCodigo
            // 
            this.columnaCodigo.HeaderText = "Codigo";
            this.columnaCodigo.Name = "columnaCodigo";
            this.columnaCodigo.Width = 50;
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.Width = 350;
            // 
            // columnaNacionalidad
            // 
            this.columnaNacionalidad.HeaderText = "Nacionalidad";
            this.columnaNacionalidad.Name = "columnaNacionalidad";
            // 
            // columnaSexo
            // 
            this.columnaSexo.HeaderText = "Sexo";
            this.columnaSexo.Name = "columnaSexo";
            // 
            // columnaFechaNacimiento
            // 
            this.columnaFechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.columnaFechaNacimiento.Name = "columnaFechaNacimiento";
            // 
            // columnaEstado
            // 
            this.columnaEstado.HeaderText = "Estado";
            this.columnaEstado.Name = "columnaEstado";
            this.columnaEstado.Width = 80;
            // 
            // efosButtonSeleccionar1
            // 
            this.efosButtonSeleccionar1.BackColor = System.Drawing.Color.Transparent;
            this.efosButtonSeleccionar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosButtonSeleccionar1.Image = ((System.Drawing.Image)(resources.GetObject("efosButtonSeleccionar1.Image")));
            this.efosButtonSeleccionar1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.efosButtonSeleccionar1.Location = new System.Drawing.Point(269, 439);
            this.efosButtonSeleccionar1.Name = "efosButtonSeleccionar1";
            this.efosButtonSeleccionar1.Size = new System.Drawing.Size(122, 58);
            this.efosButtonSeleccionar1.TabIndex = 3;
            this.efosButtonSeleccionar1.Text = "&Seleccionar";
            this.efosButtonSeleccionar1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.efosButtonSeleccionar1.UseVisualStyleBackColor = false;
            this.efosButtonSeleccionar1.Click += new System.EventHandler(this.efosButtonSeleccionar1_Click);
            // 
            // efosButtonCancelar1
            // 
            this.efosButtonCancelar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosButtonCancelar1.Image = ((System.Drawing.Image)(resources.GetObject("efosButtonCancelar1.Image")));
            this.efosButtonCancelar1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.efosButtonCancelar1.Location = new System.Drawing.Point(437, 439);
            this.efosButtonCancelar1.Name = "efosButtonCancelar1";
            this.efosButtonCancelar1.Size = new System.Drawing.Size(122, 58);
            this.efosButtonCancelar1.TabIndex = 4;
            this.efosButtonCancelar1.Text = "&Cancelar";
            this.efosButtonCancelar1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.efosButtonCancelar1.UseVisualStyleBackColor = true;
            this.efosButtonCancelar1.Click += new System.EventHandler(this.efosButtonCancelar1_Click);
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.AutoSize = true;
            this.efosLetrero2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero2.Location = new System.Drawing.Point(184, 132);
            this.efosLetrero2.Name = "efosLetrero2";
            this.efosLetrero2.Size = new System.Drawing.Size(55, 15);
            this.efosLetrero2.TabIndex = 5;
            this.efosLetrero2.Text = "Buscar:";
            this.efosLetrero2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosButtonBuscador1
            // 
            this.efosButtonBuscador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosButtonBuscador1.Image = ((System.Drawing.Image)(resources.GetObject("efosButtonBuscador1.Image")));
            this.efosButtonBuscador1.Location = new System.Drawing.Point(624, 124);
            this.efosButtonBuscador1.Name = "efosButtonBuscador1";
            this.efosButtonBuscador1.Size = new System.Drawing.Size(35, 30);
            this.efosButtonBuscador1.TabIndex = 6;
            this.efosButtonBuscador1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.efosButtonBuscador1.UseVisualStyleBackColor = true;
            this.efosButtonBuscador1.Click += new System.EventHandler(this.efosButtonBuscador1_Click);
            // 
            // campoBusqueda
            // 
            this.campoBusqueda.CampoBD = null;
            this.campoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoBusqueda.Limpiar = true;
            this.campoBusqueda.Location = new System.Drawing.Point(259, 129);
            this.campoBusqueda.Name = "campoBusqueda";
            this.campoBusqueda.Size = new System.Drawing.Size(359, 21);
            this.campoBusqueda.SoloLectura = false;
            this.campoBusqueda.TabIndex = 7;
            this.campoBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.efosCampo1_KeyDown);
            this.campoBusqueda.Validated += new System.EventHandler(this.campoBusqueda_Validated);
            // 
            // textoFormato
            // 
            this.textoFormato.AutoSize = true;
            this.textoFormato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoFormato.ForeColor = System.Drawing.Color.Maroon;
            this.textoFormato.Location = new System.Drawing.Point(663, 132);
            this.textoFormato.Name = "textoFormato";
            this.textoFormato.Size = new System.Drawing.Size(147, 15);
            this.textoFormato.TabIndex = 8;
            this.textoFormato.Text = "Formato: año/mes/dia";
            this.textoFormato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.textoFormato.Visible = false;
            // 
            // FormBaseConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(845, 509);
            this.Controls.Add(this.textoFormato);
            this.Controls.Add(this.campoBusqueda);
            this.Controls.Add(this.efosButtonBuscador1);
            this.Controls.Add(this.efosLetrero2);
            this.Controls.Add(this.efosButtonCancelar1);
            this.Controls.Add(this.efosButtonSeleccionar1);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.efosGroupBox1);
            this.Controls.Add(this.efosLetrero1);
            this.Name = "FormBaseConsultaPersona";
            this.Text = "FormBaseConsultaPersona";
            this.efosGroupBox1.ResumeLayout(false);
            this.efosGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosGroupBox efosGroupBox1;
        private ControlesEfos.efosRadioButton radioFechaNacimiento;
        private ControlesEfos.efosRadioButton radioNombre;
        private ControlesEfos.efosDataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNacionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaEstado;
        private ControlesEfos.efosButtonSeleccionar efosButtonSeleccionar1;
        private ControlesEfos.efosButtonCancelar efosButtonCancelar1;
        private ControlesEfos.efosLetrero efosLetrero2;
        private ControlesEfos.efosButtonBuscador efosButtonBuscador1;
        private ControlesEfos.efosCampo campoBusqueda;
        private ControlesEfos.efosLetrero textoFormato;
    }
}