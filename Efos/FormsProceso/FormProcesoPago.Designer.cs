namespace Efos.FormProceso
{
    partial class FormProcesoPago
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
            this.comboTipoComprobanteFiscal = new ControlesEfos.efosCombo();
            this.letreroNCF = new ControlesEfos.efosLetrero();
            this.dataGridOrdenTrabajo = new ControlesEfos.efosDataGridView();
            this.columnaNumeroOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFechaOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTotalOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBalancePedienteOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaMontoAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBalanceRestanteOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBotonVerOrdenTrabajo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.efosGroupBox1 = new ControlesEfos.efosGroupBox();
            this.efosLetrero5 = new ControlesEfos.efosLetrero();
            this.campoMontoAPagar = new ControlesEfos.efosCampo();
            this.botonAplicar = new System.Windows.Forms.Button();
            this.efosGroupBox2 = new ControlesEfos.efosGroupBox();
            this.efosGroupBox3 = new ControlesEfos.efosGroupBox();
            this.campoBalancePendiente = new ControlesEfos.efosCampo();
            this.efosLetrero9 = new ControlesEfos.efosLetrero();
            this.campoTotal = new ControlesEfos.efosCampo();
            this.efosLetrero7 = new ControlesEfos.efosLetrero();
            this.efosLetrero6 = new ControlesEfos.efosLetrero();
            this.campoDevuelta = new ControlesEfos.efosCampo();
            this.efosGroupBoxPadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenTrabajo)).BeginInit();
            this.efosGroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonProcesar
            // 
            this.botonProcesar.Location = new System.Drawing.Point(263, 459);
            this.botonProcesar.Click += new System.EventHandler(this.botonProcesar_Click);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(365, 459);
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(473, 459);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(575, 459);
            // 
            // botonNuevo
            // 
            this.botonNuevo.Location = new System.Drawing.Point(157, 459);
            this.botonNuevo.Click += new System.EventHandler(this.botonNuevo_Click);
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.Location = new System.Drawing.Point(30, 101);
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.Location = new System.Drawing.Point(549, 101);
            // 
            // txtFechaAsunto
            // 
            this.txtFechaAsunto.Location = new System.Drawing.Point(673, 98);
            // 
            // txtNumeroAsunto
            // 
            this.txtNumeroAsunto.Location = new System.Drawing.Point(197, 98);
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Location = new System.Drawing.Point(197, 140);
            this.txtCodigoPaciente.Validated += new System.EventHandler(this.txtCodigoPaciente_Validated);
            // 
            // efosLetrero3
            // 
            this.efosLetrero3.Location = new System.Drawing.Point(30, 143);
            // 
            // lupaPaciente
            // 
            this.lupaPaciente.Location = new System.Drawing.Point(161, 135);
            // 
            // lupaAsunto
            // 
            this.lupaAsunto.Location = new System.Drawing.Point(161, 93);
            // 
            // letreroNombrePaciente
            // 
            this.letreroNombrePaciente.Location = new System.Drawing.Point(303, 144);
            // 
            // efosGroupBoxPadre
            // 
            this.efosGroupBoxPadre.Controls.Add(this.letreroNCF);
            this.efosGroupBoxPadre.Location = new System.Drawing.Point(20, 46);
            this.efosGroupBoxPadre.Size = new System.Drawing.Size(766, 126);
            // 
            // comboTipoComprobanteFiscal
            // 
            this.comboTipoComprobanteFiscal.CampoBD = null;
            this.comboTipoComprobanteFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoComprobanteFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoComprobanteFiscal.FormattingEnabled = true;
            this.comboTipoComprobanteFiscal.Location = new System.Drawing.Point(20, 18);
            this.comboTipoComprobanteFiscal.Name = "comboTipoComprobanteFiscal";
            this.comboTipoComprobanteFiscal.NoLimpiar = true;
            this.comboTipoComprobanteFiscal.Size = new System.Drawing.Size(313, 23);
            this.comboTipoComprobanteFiscal.Sorted = true;
            this.comboTipoComprobanteFiscal.TabIndex = 0;
            // 
            // letreroNCF
            // 
            this.letreroNCF.AutoSize = true;
            this.letreroNCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letreroNCF.Location = new System.Drawing.Point(261, 17);
            this.letreroNCF.Name = "letreroNCF";
            this.letreroNCF.Size = new System.Drawing.Size(262, 26);
            this.letreroNCF.TabIndex = 1;
            this.letreroNCF.Text = "A010010100100000001";
            this.letreroNCF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridOrdenTrabajo
            // 
            this.dataGridOrdenTrabajo.AllowUserToAddRows = false;
            this.dataGridOrdenTrabajo.AllowUserToDeleteRows = false;
            this.dataGridOrdenTrabajo.AllowUserToResizeColumns = false;
            this.dataGridOrdenTrabajo.AllowUserToResizeRows = false;
            this.dataGridOrdenTrabajo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridOrdenTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridOrdenTrabajo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridOrdenTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdenTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNumeroOrdenTrabajo,
            this.columnaFechaOrdenTrabajo,
            this.columnaTotalOrdenTrabajo,
            this.columnaBalancePedienteOrdenTrabajo,
            this.columnaMontoAPagar,
            this.columnaBalanceRestanteOrdenTrabajo,
            this.columnaBotonVerOrdenTrabajo});
            this.dataGridOrdenTrabajo.Location = new System.Drawing.Point(33, 250);
            this.dataGridOrdenTrabajo.Name = "dataGridOrdenTrabajo";
            this.dataGridOrdenTrabajo.ReadOnly = true;
            this.dataGridOrdenTrabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridOrdenTrabajo.Size = new System.Drawing.Size(744, 136);
            this.dataGridOrdenTrabajo.StandardTab = true;
            this.dataGridOrdenTrabajo.TabIndex = 16;
            this.dataGridOrdenTrabajo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrdenTrabajo_CellClick);
            this.dataGridOrdenTrabajo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrdenTrabajo_CellValueChanged);
            // 
            // columnaNumeroOrdenTrabajo
            // 
            this.columnaNumeroOrdenTrabajo.HeaderText = "Numero";
            this.columnaNumeroOrdenTrabajo.Name = "columnaNumeroOrdenTrabajo";
            this.columnaNumeroOrdenTrabajo.ReadOnly = true;
            // 
            // columnaFechaOrdenTrabajo
            // 
            this.columnaFechaOrdenTrabajo.HeaderText = "Fecha";
            this.columnaFechaOrdenTrabajo.Name = "columnaFechaOrdenTrabajo";
            this.columnaFechaOrdenTrabajo.ReadOnly = true;
            // 
            // columnaTotalOrdenTrabajo
            // 
            this.columnaTotalOrdenTrabajo.HeaderText = "Total";
            this.columnaTotalOrdenTrabajo.Name = "columnaTotalOrdenTrabajo";
            this.columnaTotalOrdenTrabajo.ReadOnly = true;
            // 
            // columnaBalancePedienteOrdenTrabajo
            // 
            this.columnaBalancePedienteOrdenTrabajo.HeaderText = "Balance Pendiente";
            this.columnaBalancePedienteOrdenTrabajo.Name = "columnaBalancePedienteOrdenTrabajo";
            this.columnaBalancePedienteOrdenTrabajo.ReadOnly = true;
            // 
            // columnaMontoAPagar
            // 
            this.columnaMontoAPagar.HeaderText = "Monto a Pagar";
            this.columnaMontoAPagar.Name = "columnaMontoAPagar";
            this.columnaMontoAPagar.ReadOnly = true;
            // 
            // columnaBalanceRestanteOrdenTrabajo
            // 
            this.columnaBalanceRestanteOrdenTrabajo.HeaderText = "Balance Restante";
            this.columnaBalanceRestanteOrdenTrabajo.Name = "columnaBalanceRestanteOrdenTrabajo";
            this.columnaBalanceRestanteOrdenTrabajo.ReadOnly = true;
            // 
            // columnaBotonVerOrdenTrabajo
            // 
            this.columnaBotonVerOrdenTrabajo.HeaderText = "Ver Orden";
            this.columnaBotonVerOrdenTrabajo.Name = "columnaBotonVerOrdenTrabajo";
            this.columnaBotonVerOrdenTrabajo.ReadOnly = true;
            this.columnaBotonVerOrdenTrabajo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaBotonVerOrdenTrabajo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.columnaBotonVerOrdenTrabajo.Text = "Ver Orden";
            this.columnaBotonVerOrdenTrabajo.ToolTipText = "Ver Orden";
            this.columnaBotonVerOrdenTrabajo.UseColumnTextForButtonValue = true;
            // 
            // efosGroupBox1
            // 
            this.efosGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox1.Location = new System.Drawing.Point(20, 233);
            this.efosGroupBox1.Name = "efosGroupBox1";
            this.efosGroupBox1.Size = new System.Drawing.Size(766, 166);
            this.efosGroupBox1.TabIndex = 17;
            this.efosGroupBox1.TabStop = false;
            this.efosGroupBox1.Text = "Ordenes de Trabajo";
            // 
            // efosLetrero5
            // 
            this.efosLetrero5.AutoSize = true;
            this.efosLetrero5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero5.Location = new System.Drawing.Point(33, 194);
            this.efosLetrero5.Name = "efosLetrero5";
            this.efosLetrero5.Size = new System.Drawing.Size(105, 15);
            this.efosLetrero5.TabIndex = 18;
            this.efosLetrero5.Text = "Monto a Pagar:";
            this.efosLetrero5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoMontoAPagar
            // 
            this.campoMontoAPagar.CampoBD = null;
            this.campoMontoAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoMontoAPagar.Limpiar = true;
            this.campoMontoAPagar.Location = new System.Drawing.Point(144, 191);
            this.campoMontoAPagar.Name = "campoMontoAPagar";
            this.campoMontoAPagar.Size = new System.Drawing.Size(100, 21);
            this.campoMontoAPagar.SoloLectura = false;
            this.campoMontoAPagar.TabIndex = 19;
            this.campoMontoAPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campoMontoAPagar_KeyPress);
            // 
            // botonAplicar
            // 
            this.botonAplicar.Enabled = false;
            this.botonAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAplicar.Location = new System.Drawing.Point(248, 190);
            this.botonAplicar.Name = "botonAplicar";
            this.botonAplicar.Size = new System.Drawing.Size(107, 23);
            this.botonAplicar.TabIndex = 20;
            this.botonAplicar.Text = "&Aplicar Pago";
            this.botonAplicar.UseVisualStyleBackColor = true;
            this.botonAplicar.Click += new System.EventHandler(this.botonAplicar_Click);
            // 
            // efosGroupBox2
            // 
            this.efosGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox2.Location = new System.Drawing.Point(20, 171);
            this.efosGroupBox2.Name = "efosGroupBox2";
            this.efosGroupBox2.Size = new System.Drawing.Size(766, 56);
            this.efosGroupBox2.TabIndex = 21;
            this.efosGroupBox2.TabStop = false;
            // 
            // efosGroupBox3
            // 
            this.efosGroupBox3.Controls.Add(this.campoBalancePendiente);
            this.efosGroupBox3.Controls.Add(this.efosLetrero9);
            this.efosGroupBox3.Controls.Add(this.campoTotal);
            this.efosGroupBox3.Controls.Add(this.efosLetrero7);
            this.efosGroupBox3.Controls.Add(this.efosLetrero6);
            this.efosGroupBox3.Controls.Add(this.campoDevuelta);
            this.efosGroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosGroupBox3.Location = new System.Drawing.Point(20, 406);
            this.efosGroupBox3.Name = "efosGroupBox3";
            this.efosGroupBox3.Size = new System.Drawing.Size(766, 47);
            this.efosGroupBox3.TabIndex = 22;
            this.efosGroupBox3.TabStop = false;
            this.efosGroupBox3.Text = "Totales";
            // 
            // campoBalancePendiente
            // 
            this.campoBalancePendiente.CampoBD = null;
            this.campoBalancePendiente.Enabled = false;
            this.campoBalancePendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoBalancePendiente.Limpiar = true;
            this.campoBalancePendiente.Location = new System.Drawing.Point(400, 16);
            this.campoBalancePendiente.Name = "campoBalancePendiente";
            this.campoBalancePendiente.Size = new System.Drawing.Size(100, 21);
            this.campoBalancePendiente.SoloLectura = false;
            this.campoBalancePendiente.TabIndex = 7;
            this.campoBalancePendiente.Text = "0.00";
            // 
            // efosLetrero9
            // 
            this.efosLetrero9.AutoSize = true;
            this.efosLetrero9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero9.Location = new System.Drawing.Point(320, 19);
            this.efosLetrero9.Name = "efosLetrero9";
            this.efosLetrero9.Size = new System.Drawing.Size(76, 15);
            this.efosLetrero9.TabIndex = 6;
            this.efosLetrero9.Text = "Pendiente:";
            this.efosLetrero9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoTotal
            // 
            this.campoTotal.CampoBD = null;
            this.campoTotal.Enabled = false;
            this.campoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoTotal.Limpiar = true;
            this.campoTotal.Location = new System.Drawing.Point(112, 16);
            this.campoTotal.Name = "campoTotal";
            this.campoTotal.Size = new System.Drawing.Size(100, 21);
            this.campoTotal.SoloLectura = false;
            this.campoTotal.TabIndex = 5;
            this.campoTotal.Text = "0.00";
            // 
            // efosLetrero7
            // 
            this.efosLetrero7.AutoSize = true;
            this.efosLetrero7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero7.Location = new System.Drawing.Point(43, 19);
            this.efosLetrero7.Name = "efosLetrero7";
            this.efosLetrero7.Size = new System.Drawing.Size(65, 15);
            this.efosLetrero7.TabIndex = 2;
            this.efosLetrero7.Text = "Ordenes:";
            this.efosLetrero7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // efosLetrero6
            // 
            this.efosLetrero6.AutoSize = true;
            this.efosLetrero6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero6.Location = new System.Drawing.Point(580, 19);
            this.efosLetrero6.Name = "efosLetrero6";
            this.efosLetrero6.Size = new System.Drawing.Size(67, 15);
            this.efosLetrero6.TabIndex = 1;
            this.efosLetrero6.Text = "Devuelta:";
            this.efosLetrero6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // campoDevuelta
            // 
            this.campoDevuelta.CampoBD = null;
            this.campoDevuelta.Enabled = false;
            this.campoDevuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campoDevuelta.Limpiar = true;
            this.campoDevuelta.Location = new System.Drawing.Point(651, 16);
            this.campoDevuelta.Name = "campoDevuelta";
            this.campoDevuelta.Size = new System.Drawing.Size(100, 21);
            this.campoDevuelta.SoloLectura = false;
            this.campoDevuelta.TabIndex = 0;
            this.campoDevuelta.Text = "0.00";
            // 
            // FormProcesoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.efosGroupBox3);
            this.Controls.Add(this.botonAplicar);
            this.Controls.Add(this.campoMontoAPagar);
            this.Controls.Add(this.efosLetrero5);
            this.Controls.Add(this.dataGridOrdenTrabajo);
            this.Controls.Add(this.comboTipoComprobanteFiscal);
            this.Controls.Add(this.efosGroupBox1);
            this.Controls.Add(this.efosGroupBox2);
            this.Name = "FormProcesoPago";
            this.Text = "FormProcesoPago";
            this.Controls.SetChildIndex(this.efosGroupBox2, 0);
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
            this.Controls.SetChildIndex(this.comboTipoComprobanteFiscal, 0);
            this.Controls.SetChildIndex(this.letreroNombrePaciente, 0);
            this.Controls.SetChildIndex(this.dataGridOrdenTrabajo, 0);
            this.Controls.SetChildIndex(this.efosLetrero5, 0);
            this.Controls.SetChildIndex(this.campoMontoAPagar, 0);
            this.Controls.SetChildIndex(this.botonAplicar, 0);
            this.Controls.SetChildIndex(this.efosGroupBox3, 0);
            this.efosGroupBoxPadre.ResumeLayout(false);
            this.efosGroupBoxPadre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenTrabajo)).EndInit();
            this.efosGroupBox3.ResumeLayout(false);
            this.efosGroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero letreroNCF;
        private ControlesEfos.efosCombo comboTipoComprobanteFiscal;
        private ControlesEfos.efosDataGridView dataGridOrdenTrabajo;
        private ControlesEfos.efosGroupBox efosGroupBox1;
        private ControlesEfos.efosLetrero efosLetrero5;
        private ControlesEfos.efosCampo campoMontoAPagar;
        private System.Windows.Forms.Button botonAplicar;
        private ControlesEfos.efosGroupBox efosGroupBox2;
        private ControlesEfos.efosGroupBox efosGroupBox3;
        private ControlesEfos.efosLetrero efosLetrero6;
        private ControlesEfos.efosCampo campoDevuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNumeroOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFechaOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTotalOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaBalancePedienteOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaMontoAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaBalanceRestanteOrdenTrabajo;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonVerOrdenTrabajo;
        private ControlesEfos.efosCampo campoTotal;
        private ControlesEfos.efosLetrero efosLetrero7;
        private ControlesEfos.efosCampo campoBalancePendiente;
        private ControlesEfos.efosLetrero efosLetrero9;
    }
}