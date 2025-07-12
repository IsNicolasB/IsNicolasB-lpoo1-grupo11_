namespace Vistas
{
    partial class frmCuotaCliente
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
            this.dgvCuotas = new System.Windows.Forms.DataGridView();
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.txtNroPrestamo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblPagadas = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.lblTotalPendiente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCuotas
            // 
            this.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuotas.Location = new System.Drawing.Point(22, 52);
            this.dgvCuotas.Name = "dgvCuotas";
            this.dgvCuotas.Size = new System.Drawing.Size(444, 189);
            this.dgvCuotas.TabIndex = 0;
            // 
            // cmbClientes
            // 
            this.cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(75, 20);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(118, 21);
            this.cmbClientes.Sorted = true;
            this.cmbClientes.TabIndex = 11;
            // 
            // txtNroPrestamo
            // 
            this.txtNroPrestamo.Location = new System.Drawing.Point(295, 21);
            this.txtNroPrestamo.Name = "txtNroPrestamo";
            this.txtNroPrestamo.Size = new System.Drawing.Size(78, 20);
            this.txtNroPrestamo.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(379, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblPagadas
            // 
            this.lblPagadas.AutoSize = true;
            this.lblPagadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagadas.Location = new System.Drawing.Point(6, 27);
            this.lblPagadas.Name = "lblPagadas";
            this.lblPagadas.Size = new System.Drawing.Size(112, 16);
            this.lblPagadas.TabIndex = 4;
            this.lblPagadas.Text = "Cuotas Pagadas:";
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.Location = new System.Drawing.Point(6, 46);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(124, 16);
            this.lblPendientes.TabIndex = 5;
            this.lblPendientes.Text = "Cuotas Pendientes:";
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagado.Location = new System.Drawing.Point(243, 27);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(108, 16);
            this.lblTotalPagado.TabIndex = 6;
            this.lblTotalPagado.Text = "Importe Pagado:";
            // 
            // lblTotalPendiente
            // 
            this.lblTotalPendiente.AutoSize = true;
            this.lblTotalPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPendiente.Location = new System.Drawing.Point(243, 46);
            this.lblTotalPendiente.Name = "lblTotalPendiente";
            this.lblTotalPendiente.Size = new System.Drawing.Size(120, 16);
            this.lblTotalPendiente.TabIndex = 7;
            this.lblTotalPendiente.Text = "Importe Pendiente:";
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.groupBox1.Controls.Add(this.lblPagadas);
            this.groupBox1.Controls.Add(this.lblTotalPendiente);
            this.groupBox1.Controls.Add(this.lblPendientes);
            this.groupBox1.Controls.Add(this.lblTotalPagado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 249);
            this.groupBox1.MaximumSize = new System.Drawing.Size(500, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen de Cuotas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "NroPrestamo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente:";
            // 
            // frmCuotaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNroPrestamo);
            this.Controls.Add(this.cmbClientes);
            this.Controls.Add(this.dgvCuotas);
            this.Name = "frmCuotaCliente";
            this.Text = "frmCuotaCliente";
            this.Load += new System.EventHandler(this.frmCuotaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuotas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuotas;
        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.TextBox txtNroPrestamo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblPagadas;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblTotalPagado;
        private System.Windows.Forms.Label lblTotalPendiente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}