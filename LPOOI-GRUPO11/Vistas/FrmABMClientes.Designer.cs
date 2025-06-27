namespace Vistas
{
    partial class FrmABMClientes
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbModificarDNI = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.cmbSexoCli = new System.Windows.Forms.ComboBox();
            this.lblDNICli = new System.Windows.Forms.Label();
            this.dtpFechaNacimientoMod = new System.Windows.Forms.DateTimePicker();
            this.txtTelefonoMod = new System.Windows.Forms.TextBox();
            this.txtDireccionMod = new System.Windows.Forms.TextBox();
            this.txtIngresosMod = new System.Windows.Forms.TextBox();
            this.txtApellidoMod = new System.Windows.Forms.TextBox();
            this.txtNombreMod = new System.Windows.Forms.TextBox();
            this.lblTelefonoCli = new System.Windows.Forms.Label();
            this.lblDireccionCli = new System.Windows.Forms.Label();
            this.lblIngresosCli = new System.Windows.Forms.Label();
            this.lblFechNacCli = new System.Windows.Forms.Label();
            this.lblSexoCli = new System.Windows.Forms.Label();
            this.lblApellidoCli = new System.Windows.Forms.Label();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.cmbEliminarDNI = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarCliente = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBuscarApellido = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MostrarClientes = new System.Windows.Forms.TabPage();
            this.dvgClientesOrdenados = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.BuscarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.MostrarClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientesOrdenados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.BuscarCliente);
            this.tabControl1.Controls.Add(this.MostrarClientes);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbModificarDNI);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnModificarCliente);
            this.tabPage1.Controls.Add(this.cmbSexoCli);
            this.tabPage1.Controls.Add(this.lblDNICli);
            this.tabPage1.Controls.Add(this.dtpFechaNacimientoMod);
            this.tabPage1.Controls.Add(this.txtTelefonoMod);
            this.tabPage1.Controls.Add(this.txtDireccionMod);
            this.tabPage1.Controls.Add(this.txtIngresosMod);
            this.tabPage1.Controls.Add(this.txtApellidoMod);
            this.tabPage1.Controls.Add(this.txtNombreMod);
            this.tabPage1.Controls.Add(this.lblTelefonoCli);
            this.tabPage1.Controls.Add(this.lblDireccionCli);
            this.tabPage1.Controls.Add(this.lblIngresosCli);
            this.tabPage1.Controls.Add(this.lblFechNacCli);
            this.tabPage1.Controls.Add(this.lblSexoCli);
            this.tabPage1.Controls.Add(this.lblApellidoCli);
            this.tabPage1.Controls.Add(this.lblNombreCli);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(380, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificar Cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbModificarDNI
            // 
            this.cmbModificarDNI.FormattingEnabled = true;
            this.cmbModificarDNI.Location = new System.Drawing.Point(177, 23);
            this.cmbModificarDNI.Name = "cmbModificarDNI";
            this.cmbModificarDNI.Size = new System.Drawing.Size(121, 21);
            this.cmbModificarDNI.TabIndex = 40;
            this.cmbModificarDNI.SelectedIndexChanged += new System.EventHandler(this.cmbModificarDNI_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(285, 423);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(204, 423);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCliente.TabIndex = 38;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // cmbSexoCli
            // 
            this.cmbSexoCli.FormattingEnabled = true;
            this.cmbSexoCli.Location = new System.Drawing.Point(177, 174);
            this.cmbSexoCli.Name = "cmbSexoCli";
            this.cmbSexoCli.Size = new System.Drawing.Size(121, 21);
            this.cmbSexoCli.TabIndex = 25;
            // 
            // lblDNICli
            // 
            this.lblDNICli.AutoSize = true;
            this.lblDNICli.Location = new System.Drawing.Point(12, 23);
            this.lblDNICli.Name = "lblDNICli";
            this.lblDNICli.Size = new System.Drawing.Size(26, 13);
            this.lblDNICli.TabIndex = 30;
            this.lblDNICli.Text = "DNI";
            // 
            // dtpFechaNacimientoMod
            // 
            this.dtpFechaNacimientoMod.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaNacimientoMod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimientoMod.Location = new System.Drawing.Point(177, 227);
            this.dtpFechaNacimientoMod.MaxDate = new System.DateTime(2025, 5, 15, 21, 35, 36, 0);
            this.dtpFechaNacimientoMod.Name = "dtpFechaNacimientoMod";
            this.dtpFechaNacimientoMod.Size = new System.Drawing.Size(191, 20);
            this.dtpFechaNacimientoMod.TabIndex = 26;
            this.dtpFechaNacimientoMod.Value = new System.DateTime(2025, 5, 15, 0, 0, 0, 0);
            // 
            // txtTelefonoMod
            // 
            this.txtTelefonoMod.Location = new System.Drawing.Point(177, 386);
            this.txtTelefonoMod.Name = "txtTelefonoMod";
            this.txtTelefonoMod.Size = new System.Drawing.Size(191, 20);
            this.txtTelefonoMod.TabIndex = 29;
            // 
            // txtDireccionMod
            // 
            this.txtDireccionMod.Location = new System.Drawing.Point(177, 337);
            this.txtDireccionMod.Name = "txtDireccionMod";
            this.txtDireccionMod.Size = new System.Drawing.Size(191, 20);
            this.txtDireccionMod.TabIndex = 28;
            // 
            // txtIngresosMod
            // 
            this.txtIngresosMod.Location = new System.Drawing.Point(177, 282);
            this.txtIngresosMod.Name = "txtIngresosMod";
            this.txtIngresosMod.Size = new System.Drawing.Size(191, 20);
            this.txtIngresosMod.TabIndex = 27;
            // 
            // txtApellidoMod
            // 
            this.txtApellidoMod.Location = new System.Drawing.Point(177, 121);
            this.txtApellidoMod.Name = "txtApellidoMod";
            this.txtApellidoMod.Size = new System.Drawing.Size(191, 20);
            this.txtApellidoMod.TabIndex = 24;
            // 
            // txtNombreMod
            // 
            this.txtNombreMod.Location = new System.Drawing.Point(177, 67);
            this.txtNombreMod.Name = "txtNombreMod";
            this.txtNombreMod.Size = new System.Drawing.Size(191, 20);
            this.txtNombreMod.TabIndex = 23;
            // 
            // lblTelefonoCli
            // 
            this.lblTelefonoCli.AutoSize = true;
            this.lblTelefonoCli.Location = new System.Drawing.Point(12, 386);
            this.lblTelefonoCli.Name = "lblTelefonoCli";
            this.lblTelefonoCli.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoCli.TabIndex = 37;
            this.lblTelefonoCli.Text = "Telefono";
            // 
            // lblDireccionCli
            // 
            this.lblDireccionCli.AutoSize = true;
            this.lblDireccionCli.Location = new System.Drawing.Point(12, 337);
            this.lblDireccionCli.Name = "lblDireccionCli";
            this.lblDireccionCli.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionCli.TabIndex = 36;
            this.lblDireccionCli.Text = "Direccion";
            // 
            // lblIngresosCli
            // 
            this.lblIngresosCli.AutoSize = true;
            this.lblIngresosCli.Location = new System.Drawing.Point(12, 282);
            this.lblIngresosCli.Name = "lblIngresosCli";
            this.lblIngresosCli.Size = new System.Drawing.Size(47, 13);
            this.lblIngresosCli.TabIndex = 35;
            this.lblIngresosCli.Text = "Ingresos";
            // 
            // lblFechNacCli
            // 
            this.lblFechNacCli.AutoSize = true;
            this.lblFechNacCli.Location = new System.Drawing.Point(12, 227);
            this.lblFechNacCli.Name = "lblFechNacCli";
            this.lblFechNacCli.Size = new System.Drawing.Size(108, 13);
            this.lblFechNacCli.TabIndex = 34;
            this.lblFechNacCli.Text = "Fecha de Nacimiento";
            // 
            // lblSexoCli
            // 
            this.lblSexoCli.AutoSize = true;
            this.lblSexoCli.Location = new System.Drawing.Point(12, 174);
            this.lblSexoCli.Name = "lblSexoCli";
            this.lblSexoCli.Size = new System.Drawing.Size(31, 13);
            this.lblSexoCli.TabIndex = 33;
            this.lblSexoCli.Text = "Sexo";
            // 
            // lblApellidoCli
            // 
            this.lblApellidoCli.AutoSize = true;
            this.lblApellidoCli.Location = new System.Drawing.Point(12, 121);
            this.lblApellidoCli.Name = "lblApellidoCli";
            this.lblApellidoCli.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoCli.TabIndex = 32;
            this.lblApellidoCli.Text = "Apeliido";
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(12, 67);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCli.TabIndex = 31;
            this.lblNombreCli.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEliminarCliente);
            this.tabPage2.Controls.Add(this.cmbEliminarDNI);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(380, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(295, 176);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCliente.TabIndex = 35;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // cmbEliminarDNI
            // 
            this.cmbEliminarDNI.FormattingEnabled = true;
            this.cmbEliminarDNI.Location = new System.Drawing.Point(176, 103);
            this.cmbEliminarDNI.Name = "cmbEliminarDNI";
            this.cmbEliminarDNI.Size = new System.Drawing.Size(121, 21);
            this.cmbEliminarDNI.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Seleccione el DNI del cliente a eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "DNI";
            // 
            // BuscarCliente
            // 
            this.BuscarCliente.Controls.Add(this.dgvClientes);
            this.BuscarCliente.Controls.Add(this.btnBuscarCliente);
            this.BuscarCliente.Controls.Add(this.txtBuscarApellido);
            this.BuscarCliente.Controls.Add(this.txtBuscarNombre);
            this.BuscarCliente.Controls.Add(this.label3);
            this.BuscarCliente.Controls.Add(this.label4);
            this.BuscarCliente.Location = new System.Drawing.Point(4, 22);
            this.BuscarCliente.Name = "BuscarCliente";
            this.BuscarCliente.Padding = new System.Windows.Forms.Padding(3);
            this.BuscarCliente.Size = new System.Drawing.Size(380, 452);
            this.BuscarCliente.TabIndex = 2;
            this.BuscarCliente.Text = "BuscarCliente";
            this.BuscarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(17, 161);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(353, 150);
            this.dgvClientes.TabIndex = 38;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(295, 353);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 37;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarApellido
            // 
            this.txtBuscarApellido.Location = new System.Drawing.Point(179, 108);
            this.txtBuscarApellido.Name = "txtBuscarApellido";
            this.txtBuscarApellido.Size = new System.Drawing.Size(191, 20);
            this.txtBuscarApellido.TabIndex = 34;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(179, 54);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(191, 20);
            this.txtBuscarNombre.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Apeliido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nombre";
            // 
            // MostrarClientes
            // 
            this.MostrarClientes.Controls.Add(this.dvgClientesOrdenados);
            this.MostrarClientes.Controls.Add(this.button2);
            this.MostrarClientes.Controls.Add(this.btnMostrarClientes);
            this.MostrarClientes.Location = new System.Drawing.Point(4, 22);
            this.MostrarClientes.Name = "MostrarClientes";
            this.MostrarClientes.Padding = new System.Windows.Forms.Padding(3);
            this.MostrarClientes.Size = new System.Drawing.Size(380, 452);
            this.MostrarClientes.TabIndex = 3;
            this.MostrarClientes.Text = "Ver Clientes";
            this.MostrarClientes.UseVisualStyleBackColor = true;
            // 
            // dvgClientesOrdenados
            // 
            this.dvgClientesOrdenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClientesOrdenados.Location = new System.Drawing.Point(0, 0);
            this.dvgClientesOrdenados.Name = "dvgClientesOrdenados";
            this.dvgClientesOrdenados.Size = new System.Drawing.Size(380, 410);
            this.dvgClientesOrdenados.TabIndex = 41;
            this.dvgClientesOrdenados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClientesOrdenados_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Location = new System.Drawing.Point(209, 416);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarClientes.TabIndex = 0;
            this.btnMostrarClientes.Text = "Buscar";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // FrmABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmABMClientes";
            this.Text = "ABM_Clientes";
            this.Load += new System.EventHandler(this.ABM_Clientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.BuscarCliente.ResumeLayout(false);
            this.BuscarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.MostrarClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientesOrdenados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage BuscarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.ComboBox cmbSexoCli;
        private System.Windows.Forms.Label lblDNICli;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimientoMod;
        private System.Windows.Forms.TextBox txtTelefonoMod;
        private System.Windows.Forms.TextBox txtDireccionMod;
        private System.Windows.Forms.TextBox txtIngresosMod;
        private System.Windows.Forms.TextBox txtApellidoMod;
        private System.Windows.Forms.TextBox txtNombreMod;
        private System.Windows.Forms.Label lblTelefonoCli;
        private System.Windows.Forms.Label lblDireccionCli;
        private System.Windows.Forms.Label lblIngresosCli;
        private System.Windows.Forms.Label lblFechNacCli;
        private System.Windows.Forms.Label lblSexoCli;
        private System.Windows.Forms.Label lblApellidoCli;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.ComboBox cmbEliminarDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarApellido;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.ComboBox cmbModificarDNI;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage MostrarClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.DataGridView dvgClientesOrdenados;
    }
}