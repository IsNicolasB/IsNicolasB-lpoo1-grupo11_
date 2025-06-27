namespace Vistas
{
    partial class FrmAltaPrestamo
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.btnCrearPrestamo = new System.Windows.Forms.Button();
            this.Importe = new System.Windows.Forms.Label();
            this.lblCuotas = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtCantidadCuotas = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(53, 33);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(98, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Seleccionar Cliente";
            this.lblCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(56, 49);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(222, 21);
            this.cmbCliente.TabIndex = 1;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(56, 106);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(222, 21);
            this.cmbDestino.TabIndex = 2;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(56, 165);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(222, 21);
            this.cmbPeriodo.TabIndex = 3;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(53, 90);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(102, 13);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "Seleccionar Destino";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(53, 149);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(145, 13);
            this.lblPeriodo.TabIndex = 5;
            this.lblPeriodo.Text = "Seleccionar Periodo de Pago";
            // 
            // btnCrearPrestamo
            // 
            this.btnCrearPrestamo.Location = new System.Drawing.Point(292, 228);
            this.btnCrearPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearPrestamo.Name = "btnCrearPrestamo";
            this.btnCrearPrestamo.Size = new System.Drawing.Size(113, 29);
            this.btnCrearPrestamo.TabIndex = 7;
            this.btnCrearPrestamo.Text = "Registrar Pretamo";
            this.btnCrearPrestamo.UseVisualStyleBackColor = true;
            this.btnCrearPrestamo.Click += new System.EventHandler(this.btnCrearPrestamo_Click);
            // 
            // Importe
            // 
            this.Importe.AutoSize = true;
            this.Importe.Location = new System.Drawing.Point(302, 30);
            this.Importe.Name = "Importe";
            this.Importe.Size = new System.Drawing.Size(42, 13);
            this.Importe.TabIndex = 8;
            this.Importe.Text = "Importe";
            // 
            // lblCuotas
            // 
            this.lblCuotas.AutoSize = true;
            this.lblCuotas.Location = new System.Drawing.Point(305, 147);
            this.lblCuotas.Name = "lblCuotas";
            this.lblCuotas.Size = new System.Drawing.Size(100, 13);
            this.lblCuotas.TabIndex = 9;
            this.lblCuotas.Text = "Cantidad de Cuotas";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(305, 49);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 20);
            this.txtImporte.TabIndex = 10;
            // 
            // txtCantidadCuotas
            // 
            this.txtCantidadCuotas.Location = new System.Drawing.Point(305, 166);
            this.txtCantidadCuotas.Name = "txtCantidadCuotas";
            this.txtCantidadCuotas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadCuotas.TabIndex = 11;
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(305, 106);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(100, 20);
            this.txtInteres.TabIndex = 13;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(305, 87);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(81, 13);
            this.lblInteres.TabIndex = 12;
            this.lblInteres.Text = "Tasa de Interés";
            // 
            // FrmAltaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 283);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.txtCantidadCuotas);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblCuotas);
            this.Controls.Add(this.Importe);
            this.Controls.Add(this.btnCrearPrestamo);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Name = "FrmAltaPrestamo";
            this.Text = "FrmAltaPrestamo";
            this.Load += new System.EventHandler(this.FrmAltaPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Button btnCrearPrestamo;
        private System.Windows.Forms.Label Importe;
        private System.Windows.Forms.Label lblCuotas;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtCantidadCuotas;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label lblInteres;
    }
}