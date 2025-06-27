namespace Vistas
{
    partial class FrmGestionPagos
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
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbPrestamos = new System.Windows.Forms.ComboBox();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.dgvCuotasPendientes = new System.Windows.Forms.DataGridView();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCuota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotasPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(23, 62);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(184, 20);
            this.dtpFechaPago.TabIndex = 0;
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Location = new System.Drawing.Point(20, 46);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(144, 13);
            this.lblFechaPago.TabIndex = 1;
            this.lblFechaPago.Text = "Seleccione la fecha de Pago";
            this.lblFechaPago.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(20, 96);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(105, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Seleccione el cliente";
            this.lblCliente.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(23, 112);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(184, 21);
            this.cmbClientes.TabIndex = 3;
            this.cmbClientes.SelectedIndexChanged += new System.EventHandler(this.cmbClientes_SelectedIndexChanged);
            // 
            // cmbPrestamos
            // 
            this.cmbPrestamos.FormattingEnabled = true;
            this.cmbPrestamos.Location = new System.Drawing.Point(23, 164);
            this.cmbPrestamos.Name = "cmbPrestamos";
            this.cmbPrestamos.Size = new System.Drawing.Size(184, 21);
            this.cmbPrestamos.TabIndex = 5;
            this.cmbPrestamos.SelectedIndexChanged += new System.EventHandler(this.cmbPrestamos_SelectedIndexChanged);
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.Location = new System.Drawing.Point(20, 148);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(117, 13);
            this.lblPrestamos.TabIndex = 4;
            this.lblPrestamos.Text = "Seleccione el prestamo";
            // 
            // dgvCuotasPendientes
            // 
            this.dgvCuotasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotasPendientes.Location = new System.Drawing.Point(13, 62);
            this.dgvCuotasPendientes.Name = "dgvCuotasPendientes";
            this.dgvCuotasPendientes.Size = new System.Drawing.Size(525, 167);
            this.dgvCuotasPendientes.TabIndex = 6;
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(23, 206);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(184, 23);
            this.btnRegistrarPago.TabIndex = 7;
            this.btnRegistrarPago.Text = "Confirmar Pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-2, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaPago);
            this.splitContainer1.Panel1.Controls.Add(this.btnRegistrarPago);
            this.splitContainer1.Panel1.Controls.Add(this.lblFechaPago);
            this.splitContainer1.Panel1.Controls.Add(this.lblCliente);
            this.splitContainer1.Panel1.Controls.Add(this.cmbPrestamos);
            this.splitContainer1.Panel1.Controls.Add(this.cmbClientes);
            this.splitContainer1.Panel1.Controls.Add(this.lblPrestamos);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCuota);
            this.splitContainer1.Panel2.Controls.Add(this.dgvCuotasPendientes);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(782, 347);
            this.splitContainer1.SplitterDistance = 228;
            this.splitContainer1.TabIndex = 9;
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(10, 46);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(101, 13);
            this.lblCuota.TabIndex = 8;
            this.lblCuota.Text = "Seleccione la cuota";
            // 
            // FrmGestionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 340);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmGestionPagos";
            this.Text = "FrmGestionPagos";
            this.Load += new System.EventHandler(this.FrmGestionPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotasPendientes)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbPrestamos;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.DataGridView dgvCuotasPendientes;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblCuota;
    }
}