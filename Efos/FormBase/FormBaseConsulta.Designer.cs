namespace Efos
{
    partial class FormBaseConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseConsulta));
            this.efosButtonBuscador1 = new ControlesEfos.efosButtonBuscador();
            this.txtTitulo = new ControlesEfos.efosLetrero();
            this.DataGrid = new ControlesEfos.efosDataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonCancelar = new ControlesEfos.efosButtonCancelar();
            this.botonSeleccionar = new ControlesEfos.efosButtonSeleccionar();
            this.txtDescripcion = new ControlesEfos.efosCampo();
            this.efosLetrero1 = new ControlesEfos.efosLetrero();
            this.efosGroupBox1 = new ControlesEfos.efosGroupBox();
            this.radioDescripcion = new ControlesEfos.efosRadioButton();
            this.radioCodigo = new ControlesEfos.efosRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.efosGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // efosButtonBuscador1
            // 
            this.efosButtonBuscador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosButtonBuscador1.Image = ((System.Drawing.Image)(resources.GetObject("efosButtonBuscador1.Image")));
            this.efosButtonBuscador1.Location = new System.Drawing.Point(465, 120);
            this.efosButtonBuscador1.Name = "efosButtonBuscador1";
            this.efosButtonBuscador1.Size = new System.Drawing.Size(30, 30);
            this.efosButtonBuscador1.TabIndex = 9;
            this.efosButtonBuscador1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.efosButtonBuscador1.UseVisualStyleBackColor = true;
            this.efosButtonBuscador1.Click += new System.EventHandler(this.efosButtonBuscador1_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTitulo.Location = new System.Drawing.Point(15, 14);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(509, 46);
            this.txtTitulo.TabIndex = 7;
            this.txtTitulo.Text = "efosLetrero2";
            this.txtTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTitulo.TextChanged += new System.EventHandler(this.txtTitulo_TextChanged);
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.estado});
            this.DataGrid.Location = new System.Drawing.Point(12, 160);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataGrid.Size = new System.Drawing.Size(509, 265);
            this.DataGrid.StandardTab = true;
            this.DataGrid.TabIndex = 5;
            this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
            this.DataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 90;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 275;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // botonCancelar
            // 
            this.botonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botonCancelar.Image")));
            this.botonCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonCancelar.Location = new System.Drawing.Point(312, 429);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(97, 59);
            this.botonCancelar.TabIndex = 4;
            this.botonCancelar.Text = "&Cancelar";
            this.botonCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonSeleccionar
            // 
            this.botonSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.botonSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("botonSeleccionar.Image")));
            this.botonSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botonSeleccionar.Location = new System.Drawing.Point(133, 429);
            this.botonSeleccionar.Name = "botonSeleccionar";
            this.botonSeleccionar.Size = new System.Drawing.Size(97, 59);
            this.botonSeleccionar.TabIndex = 3;
            this.botonSeleccionar.Text = "&Seleccionar";
            this.botonSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botonSeleccionar.UseVisualStyleBackColor = true;
            this.botonSeleccionar.Click += new System.EventHandler(this.botonSeleccionar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CampoBD = null;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Limpiar = true;
            this.txtDescripcion.Location = new System.Drawing.Point(122, 125);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(337, 21);
            this.txtDescripcion.SoloLectura = false;
            this.txtDescripcion.TabIndex = 1;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            this.txtDescripcion.Validated += new System.EventHandler(this.txtDescripcion_Validated);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.AutoSize = true;
            this.efosLetrero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero1.Location = new System.Drawing.Point(28, 128);
            this.efosLetrero1.Name = "efosLetrero1";
            this.efosLetrero1.Size = new System.Drawing.Size(55, 15);
            this.efosLetrero1.TabIndex = 0;
            this.efosLetrero1.Text = "Buscar:";
            this.efosLetrero1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosGroupBox1
            // 
            this.efosGroupBox1.Controls.Add(this.radioDescripcion);
            this.efosGroupBox1.Controls.Add(this.radioCodigo);
            this.efosGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox1.Location = new System.Drawing.Point(12, 64);
            this.efosGroupBox1.Name = "efosGroupBox1";
            this.efosGroupBox1.Size = new System.Drawing.Size(483, 48);
            this.efosGroupBox1.TabIndex = 10;
            this.efosGroupBox1.TabStop = false;
            this.efosGroupBox1.Text = "Opciones de Busqueda";
            // 
            // radioDescripcion
            // 
            this.radioDescripcion.AutoSize = true;
            this.radioDescripcion.Location = new System.Drawing.Point(197, 19);
            this.radioDescripcion.Name = "radioDescripcion";
            this.radioDescripcion.Size = new System.Drawing.Size(101, 19);
            this.radioDescripcion.TabIndex = 1;
            this.radioDescripcion.TabStop = true;
            this.radioDescripcion.Text = "Descripcion";
            this.radioDescripcion.UseVisualStyleBackColor = true;
            this.radioDescripcion.Click += new System.EventHandler(this.radioDescripcion_Click);
            // 
            // radioCodigo
            // 
            this.radioCodigo.AutoSize = true;
            this.radioCodigo.Location = new System.Drawing.Point(88, 19);
            this.radioCodigo.Name = "radioCodigo";
            this.radioCodigo.Size = new System.Drawing.Size(70, 19);
            this.radioCodigo.TabIndex = 0;
            this.radioCodigo.TabStop = true;
            this.radioCodigo.Text = "Codigo";
            this.radioCodigo.UseVisualStyleBackColor = true;
            this.radioCodigo.Visible = false;
            this.radioCodigo.Click += new System.EventHandler(this.radioCodigo_Click);
            // 
            // FormBaseConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(536, 493);
            this.Controls.Add(this.efosGroupBox1);
            this.Controls.Add(this.efosButtonBuscador1);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.botonSeleccionar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.efosLetrero1);
            this.Name = "FormBaseConsulta";
            this.Text = "FormBaseConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.efosGroupBox1.ResumeLayout(false);
            this.efosGroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero1;
        private ControlesEfos.efosCampo txtDescripcion;
        private ControlesEfos.efosButtonSeleccionar botonSeleccionar;
        private ControlesEfos.efosButtonCancelar botonCancelar;
        private ControlesEfos.efosDataGridView DataGrid;
        private ControlesEfos.efosLetrero txtTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private ControlesEfos.efosButtonBuscador efosButtonBuscador1;
        private ControlesEfos.efosGroupBox efosGroupBox1;
        private ControlesEfos.efosRadioButton radioDescripcion;
        private ControlesEfos.efosRadioButton radioCodigo;
    }
}