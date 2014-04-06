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
            this.efosLetrero4 = new ControlesEfos.efosLetrero();
            this.dataGridOrdenTrabajo = new ControlesEfos.efosDataGridView();
            this.columnaNumeroOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaFechaOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTotalOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBalancePedienteOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCantidadAPagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBalanceRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaBotonVerOrdenTrabajo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.efosGroupBox1 = new ControlesEfos.efosGroupBox();
            this.efosLetrero5 = new ControlesEfos.efosLetrero();
            this.efosCampo1 = new ControlesEfos.efosCampo();
            this.botonAplicar = new System.Windows.Forms.Button();
            this.efosGroupBox2 = new ControlesEfos.efosGroupBox();
            this.efosGroupBoxPadre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenTrabajo)).BeginInit();
            this.SuspendLayout();
            // 
            // botonProcesar
            // 
            this.botonProcesar.Location = new System.Drawing.Point(263, 459);
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(365, 459);
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
            // 
            // efosLetrero1
            // 
            this.efosLetrero1.Location = new System.Drawing.Point(30, 101);
            // 
            // efosLetrero2
            // 
            this.efosLetrero2.Location = new System.Drawing.Point(549, 100);
            // 
            // txtFechaAsunto
            // 
            this.txtFechaAsunto.Location = new System.Drawing.Point(673, 97);
            // 
            // txtNumeroAsunto
            // 
            this.txtNumeroAsunto.Location = new System.Drawing.Point(197, 97);
            // 
            // txtCodigoPaciente
            // 
            this.txtCodigoPaciente.Location = new System.Drawing.Point(197, 140);
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
            this.lupaAsunto.Location = new System.Drawing.Point(161, 92);
            // 
            // letreroNombrePaciente
            // 
            this.letreroNombrePaciente.Location = new System.Drawing.Point(303, 110);
            // 
            // efosGroupBoxPadre
            // 
            this.efosGroupBoxPadre.Controls.Add(this.efosLetrero4);
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
            this.comboTipoComprobanteFiscal.Size = new System.Drawing.Size(313, 23);
            this.comboTipoComprobanteFiscal.Sorted = true;
            this.comboTipoComprobanteFiscal.TabIndex = 0;
            // 
            // efosLetrero4
            // 
            this.efosLetrero4.AutoSize = true;
            this.efosLetrero4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosLetrero4.Location = new System.Drawing.Point(261, 17);
            this.efosLetrero4.Name = "efosLetrero4";
            this.efosLetrero4.Size = new System.Drawing.Size(262, 26);
            this.efosLetrero4.TabIndex = 1;
            this.efosLetrero4.Text = "A010010100100000001";
            this.efosLetrero4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridOrdenTrabajo
            // 
            this.dataGridOrdenTrabajo.AllowUserToAddRows = false;
            this.dataGridOrdenTrabajo.AllowUserToDeleteRows = false;
            this.dataGridOrdenTrabajo.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridOrdenTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridOrdenTrabajo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridOrdenTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrdenTrabajo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNumeroOrdenTrabajo,
            this.columnaFechaOrdenTrabajo,
            this.columnaTotalOrdenTrabajo,
            this.columnaBalancePedienteOrdenTrabajo,
            this.columnaCantidadAPagar,
            this.columnaBalanceRestante,
            this.columnaBotonVerOrdenTrabajo});
            this.dataGridOrdenTrabajo.Location = new System.Drawing.Point(33, 250);
            this.dataGridOrdenTrabajo.Name = "dataGridOrdenTrabajo";
            this.dataGridOrdenTrabajo.ReadOnly = true;
            this.dataGridOrdenTrabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridOrdenTrabajo.Size = new System.Drawing.Size(744, 192);
            this.dataGridOrdenTrabajo.StandardTab = true;
            this.dataGridOrdenTrabajo.TabIndex = 16;
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
            // columnaCantidadAPagar
            // 
            this.columnaCantidadAPagar.HeaderText = "Monto a Pagar";
            this.columnaCantidadAPagar.Name = "columnaCantidadAPagar";
            this.columnaCantidadAPagar.ReadOnly = true;
            // 
            // columnaBalanceRestante
            // 
            this.columnaBalanceRestante.HeaderText = "Balance Restante";
            this.columnaBalanceRestante.Name = "columnaBalanceRestante";
            this.columnaBalanceRestante.ReadOnly = true;
            // 
            // columnaBotonVerOrdenTrabajo
            // 
            this.columnaBotonVerOrdenTrabajo.HeaderText = "Ver Orden";
            this.columnaBotonVerOrdenTrabajo.Name = "columnaBotonVerOrdenTrabajo";
            this.columnaBotonVerOrdenTrabajo.ReadOnly = true;
            this.columnaBotonVerOrdenTrabajo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.efosGroupBox1.Size = new System.Drawing.Size(766, 215);
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
            // efosCampo1
            // 
            this.efosCampo1.CampoBD = null;
            this.efosCampo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.efosCampo1.Limpiar = true;
            this.efosCampo1.Location = new System.Drawing.Point(144, 191);
            this.efosCampo1.Name = "efosCampo1";
            this.efosCampo1.Size = new System.Drawing.Size(100, 21);
            this.efosCampo1.SoloLectura = false;
            this.efosCampo1.TabIndex = 19;
            // 
            // botonAplicar
            // 
            this.botonAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAplicar.Location = new System.Drawing.Point(248, 192);
            this.botonAplicar.Name = "botonAplicar";
            this.botonAplicar.Size = new System.Drawing.Size(107, 23);
            this.botonAplicar.TabIndex = 20;
            this.botonAplicar.Text = "&Aplicar Pago";
            this.botonAplicar.UseVisualStyleBackColor = true;
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
            // FormProcesoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 518);
            this.Controls.Add(this.botonAplicar);
            this.Controls.Add(this.efosCampo1);
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
            this.Controls.SetChildIndex(this.efosCampo1, 0);
            this.Controls.SetChildIndex(this.botonAplicar, 0);
            this.efosGroupBoxPadre.ResumeLayout(false);
            this.efosGroupBoxPadre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrdenTrabajo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlesEfos.efosLetrero efosLetrero4;
        private ControlesEfos.efosCombo comboTipoComprobanteFiscal;
        private ControlesEfos.efosDataGridView dataGridOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNumeroOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaFechaOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTotalOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaBalancePedienteOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCantidadAPagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaBalanceRestante;
        private System.Windows.Forms.DataGridViewButtonColumn columnaBotonVerOrdenTrabajo;
        private ControlesEfos.efosGroupBox efosGroupBox1;
        private ControlesEfos.efosLetrero efosLetrero5;
        private ControlesEfos.efosCampo efosCampo1;
        private System.Windows.Forms.Button botonAplicar;
        private ControlesEfos.efosGroupBox efosGroupBox2;
    }
}