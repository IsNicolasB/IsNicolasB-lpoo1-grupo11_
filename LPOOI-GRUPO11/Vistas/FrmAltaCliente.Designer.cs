namespace Vistas
{
    partial class FrmAltaCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clientes = new System.Windows.Forms.TabPage();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.lblApellidoCli = new System.Windows.Forms.Label();
            this.lblSexoCli = new System.Windows.Forms.Label();
            this.lblFechNacCli = new System.Windows.Forms.Label();
            this.lblIngresosCli = new System.Windows.Forms.Label();
            this.lblDireccionCli = new System.Windows.Forms.Label();
            this.lblTelefonoCli = new System.Windows.Forms.Label();
            this.txtNombreCli = new System.Windows.Forms.TextBox();
            this.txtApellidoCli = new System.Windows.Forms.TextBox();
            this.txtIngresosCli = new System.Windows.Forms.TextBox();
            this.txtDireccionCli = new System.Windows.Forms.TextBox();
            this.txtTelefonoCli = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimientoCli = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDNICli = new System.Windows.Forms.Label();
            this.txtDNICli = new System.Windows.Forms.TextBox();
            this.cmbSexoCli = new System.Windows.Forms.ComboBox();
            this.tabAltas = new System.Windows.Forms.TabControl();
            this.Clientes.SuspendLayout();
            this.tabAltas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.cmbSexoCli);
            this.Clientes.Controls.Add(this.txtDNICli);
            this.Clientes.Controls.Add(this.txtTelefonoCli);
            this.Clientes.Controls.Add(this.txtDireccionCli);
            this.Clientes.Controls.Add(this.txtIngresosCli);
            this.Clientes.Controls.Add(this.txtApellidoCli);
            this.Clientes.Controls.Add(this.txtNombreCli);
            this.Clientes.Controls.Add(this.lblDNICli);
            this.Clientes.Controls.Add(this.btnCancelar);
            this.Clientes.Controls.Add(this.dtpFechaNacimientoCli);
            this.Clientes.Controls.Add(this.lblTelefonoCli);
            this.Clientes.Controls.Add(this.lblDireccionCli);
            this.Clientes.Controls.Add(this.lblIngresosCli);
            this.Clientes.Controls.Add(this.lblFechNacCli);
            this.Clientes.Controls.Add(this.lblSexoCli);
            this.Clientes.Controls.Add(this.lblApellidoCli);
            this.Clientes.Controls.Add(this.lblNombreCli);
            this.Clientes.Controls.Add(this.btnCrearCliente);
            this.Clientes.Location = new System.Drawing.Point(4, 22);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(458, 547);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Location = new System.Drawing.Point(274, 500);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(84, 25);
            this.btnCrearCliente.TabIndex = 12;
            this.btnCrearCliente.Text = "Crear ";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click_1);
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(72, 107);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCli.TabIndex = 15;
            this.lblNombreCli.Text = "Nombre";
            this.lblNombreCli.Click += new System.EventHandler(this.lblNombreCli_Click);
            // 
            // lblApellidoCli
            // 
            this.lblApellidoCli.AutoSize = true;
            this.lblApellidoCli.Location = new System.Drawing.Point(72, 161);
            this.lblApellidoCli.Name = "lblApellidoCli";
            this.lblApellidoCli.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoCli.TabIndex = 16;
            this.lblApellidoCli.Text = "Apeliido";
            this.lblApellidoCli.Click += new System.EventHandler(this.lblApellidoCli_Click);
            // 
            // lblSexoCli
            // 
            this.lblSexoCli.AutoSize = true;
            this.lblSexoCli.Location = new System.Drawing.Point(72, 214);
            this.lblSexoCli.Name = "lblSexoCli";
            this.lblSexoCli.Size = new System.Drawing.Size(31, 13);
            this.lblSexoCli.TabIndex = 17;
            this.lblSexoCli.Text = "Sexo";
            this.lblSexoCli.Click += new System.EventHandler(this.lblSexoCli_Click);
            // 
            // lblFechNacCli
            // 
            this.lblFechNacCli.AutoSize = true;
            this.lblFechNacCli.Location = new System.Drawing.Point(72, 267);
            this.lblFechNacCli.Name = "lblFechNacCli";
            this.lblFechNacCli.Size = new System.Drawing.Size(108, 13);
            this.lblFechNacCli.TabIndex = 18;
            this.lblFechNacCli.Text = "Fecha de Nacimiento";
            // 
            // lblIngresosCli
            // 
            this.lblIngresosCli.AutoSize = true;
            this.lblIngresosCli.Location = new System.Drawing.Point(72, 322);
            this.lblIngresosCli.Name = "lblIngresosCli";
            this.lblIngresosCli.Size = new System.Drawing.Size(47, 13);
            this.lblIngresosCli.TabIndex = 19;
            this.lblIngresosCli.Text = "Ingresos";
            // 
            // lblDireccionCli
            // 
            this.lblDireccionCli.AutoSize = true;
            this.lblDireccionCli.Location = new System.Drawing.Point(72, 377);
            this.lblDireccionCli.Name = "lblDireccionCli";
            this.lblDireccionCli.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionCli.TabIndex = 20;
            this.lblDireccionCli.Text = "Direccion";
            // 
            // lblTelefonoCli
            // 
            this.lblTelefonoCli.AutoSize = true;
            this.lblTelefonoCli.Location = new System.Drawing.Point(72, 426);
            this.lblTelefonoCli.Name = "lblTelefonoCli";
            this.lblTelefonoCli.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoCli.TabIndex = 21;
            this.lblTelefonoCli.Text = "Telefono";
            // 
            // txtNombreCli
            // 
            this.txtNombreCli.Location = new System.Drawing.Point(237, 107);
            this.txtNombreCli.Name = "txtNombreCli";
            this.txtNombreCli.Size = new System.Drawing.Size(191, 20);
            this.txtNombreCli.TabIndex = 5;
            // 
            // txtApellidoCli
            // 
            this.txtApellidoCli.Location = new System.Drawing.Point(237, 161);
            this.txtApellidoCli.Name = "txtApellidoCli";
            this.txtApellidoCli.Size = new System.Drawing.Size(191, 20);
            this.txtApellidoCli.TabIndex = 6;
            this.txtApellidoCli.TextChanged += new System.EventHandler(this.txtApellidoCli_TextChanged);
            // 
            // txtIngresosCli
            // 
            this.txtIngresosCli.Location = new System.Drawing.Point(237, 322);
            this.txtIngresosCli.Name = "txtIngresosCli";
            this.txtIngresosCli.Size = new System.Drawing.Size(191, 20);
            this.txtIngresosCli.TabIndex = 9;
            // 
            // txtDireccionCli
            // 
            this.txtDireccionCli.Location = new System.Drawing.Point(237, 377);
            this.txtDireccionCli.Name = "txtDireccionCli";
            this.txtDireccionCli.Size = new System.Drawing.Size(191, 20);
            this.txtDireccionCli.TabIndex = 10;
            // 
            // txtTelefonoCli
            // 
            this.txtTelefonoCli.Location = new System.Drawing.Point(237, 426);
            this.txtTelefonoCli.Name = "txtTelefonoCli";
            this.txtTelefonoCli.Size = new System.Drawing.Size(191, 20);
            this.txtTelefonoCli.TabIndex = 11;
            // 
            // dtpFechaNacimientoCli
            // 
            this.dtpFechaNacimientoCli.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimientoCli.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimientoCli.Location = new System.Drawing.Point(237, 267);
            this.dtpFechaNacimientoCli.MaxDate = new System.DateTime(2025, 5, 15, 21, 35, 36, 0);
            this.dtpFechaNacimientoCli.Name = "dtpFechaNacimientoCli";
            this.dtpFechaNacimientoCli.Size = new System.Drawing.Size(191, 20);
            this.dtpFechaNacimientoCli.TabIndex = 8;
            this.dtpFechaNacimientoCli.Value = new System.DateTime(2025, 5, 15, 0, 0, 0, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(373, 501);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // lblDNICli
            // 
            this.lblDNICli.AutoSize = true;
            this.lblDNICli.Location = new System.Drawing.Point(72, 63);
            this.lblDNICli.Name = "lblDNICli";
            this.lblDNICli.Size = new System.Drawing.Size(26, 13);
            this.lblDNICli.TabIndex = 14;
            this.lblDNICli.Text = "DNI";
            this.lblDNICli.Click += new System.EventHandler(this.lblDNICli_Click);
            // 
            // txtDNICli
            // 
            this.txtDNICli.Location = new System.Drawing.Point(237, 56);
            this.txtDNICli.Name = "txtDNICli";
            this.txtDNICli.Size = new System.Drawing.Size(191, 20);
            this.txtDNICli.TabIndex = 4;
            this.txtDNICli.TextChanged += new System.EventHandler(this.txtDNICli_TextChanged);
            // 
            // cmbSexoCli
            // 
            this.cmbSexoCli.FormattingEnabled = true;
            this.cmbSexoCli.Location = new System.Drawing.Point(237, 214);
            this.cmbSexoCli.Name = "cmbSexoCli";
            this.cmbSexoCli.Size = new System.Drawing.Size(121, 21);
            this.cmbSexoCli.TabIndex = 7;
            // 
            // tabAltas
            // 
            this.tabAltas.Controls.Add(this.Clientes);
            this.tabAltas.Location = new System.Drawing.Point(12, 2);
            this.tabAltas.Name = "tabAltas";
            this.tabAltas.SelectedIndex = 0;
            this.tabAltas.Size = new System.Drawing.Size(466, 573);
            this.tabAltas.TabIndex = 1;
            // 
            // FrmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 571);
            this.Controls.Add(this.tabAltas);
            this.Name = "FrmAlta";
            this.Text = "Formulario de Alta";
            this.Load += new System.EventHandler(this.FrmAlta_Load);
            this.Clientes.ResumeLayout(false);
            this.Clientes.PerformLayout();
            this.tabAltas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.ComboBox cmbSexoCli;
        private System.Windows.Forms.TextBox txtDNICli;
        private System.Windows.Forms.TextBox txtTelefonoCli;
        private System.Windows.Forms.TextBox txtDireccionCli;
        private System.Windows.Forms.TextBox txtIngresosCli;
        private System.Windows.Forms.TextBox txtApellidoCli;
        private System.Windows.Forms.TextBox txtNombreCli;
        private System.Windows.Forms.Label lblDNICli;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoCli;
        private System.Windows.Forms.Label lblTelefonoCli;
        private System.Windows.Forms.Label lblDireccionCli;
        private System.Windows.Forms.Label lblIngresosCli;
        private System.Windows.Forms.Label lblFechNacCli;
        private System.Windows.Forms.Label lblSexoCli;
        private System.Windows.Forms.Label lblApellidoCli;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.TabControl tabAltas;

    }
}