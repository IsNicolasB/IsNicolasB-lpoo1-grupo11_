namespace Vistas
{
    partial class FrmABMUsuarios
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
            this.ModificarUsuario = new System.Windows.Forms.TabPage();
            this.cmbRolMod = new System.Windows.Forms.ComboBox();
            this.cmbModificarID = new System.Windows.Forms.ComboBox();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.txtApellidoNombreMod = new System.Windows.Forms.TextBox();
            this.txtPasswordMod = new System.Windows.Forms.TextBox();
            this.txtNombreUsuarioMod = new System.Windows.Forms.TextBox();
            this.lblDireccionCli = new System.Windows.Forms.Label();
            this.lblIngresosCli = new System.Windows.Forms.Label();
            this.lblApellidoCli = new System.Windows.Forms.Label();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.EliminarUsuario = new System.Windows.Forms.TabPage();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.cmbEliminarID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarUsuario = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtBuscarApellidoNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarUsuario = new System.Windows.Forms.TabPage();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.txtApellidoNombre = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ModificarUsuario.SuspendLayout();
            this.EliminarUsuario.SuspendLayout();
            this.BuscarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.AgregarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ModificarUsuario);
            this.tabControl1.Controls.Add(this.EliminarUsuario);
            this.tabControl1.Controls.Add(this.BuscarUsuario);
            this.tabControl1.Controls.Add(this.AgregarUsuario);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // ModificarUsuario
            // 
            this.ModificarUsuario.Controls.Add(this.cmbRolMod);
            this.ModificarUsuario.Controls.Add(this.cmbModificarID);
            this.ModificarUsuario.Controls.Add(this.btnModificarUsuario);
            this.ModificarUsuario.Controls.Add(this.id);
            this.ModificarUsuario.Controls.Add(this.txtApellidoNombreMod);
            this.ModificarUsuario.Controls.Add(this.txtPasswordMod);
            this.ModificarUsuario.Controls.Add(this.txtNombreUsuarioMod);
            this.ModificarUsuario.Controls.Add(this.lblDireccionCli);
            this.ModificarUsuario.Controls.Add(this.lblIngresosCli);
            this.ModificarUsuario.Controls.Add(this.lblApellidoCli);
            this.ModificarUsuario.Controls.Add(this.lblNombreCli);
            this.ModificarUsuario.Location = new System.Drawing.Point(4, 22);
            this.ModificarUsuario.Name = "ModificarUsuario";
            this.ModificarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.ModificarUsuario.Size = new System.Drawing.Size(380, 452);
            this.ModificarUsuario.TabIndex = 0;
            this.ModificarUsuario.Text = "ModificarUsuario";
            this.ModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // cmbRolMod
            // 
            this.cmbRolMod.FormattingEnabled = true;
            this.cmbRolMod.Location = new System.Drawing.Point(177, 236);
            this.cmbRolMod.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRolMod.Name = "cmbRolMod";
            this.cmbRolMod.Size = new System.Drawing.Size(78, 21);
            this.cmbRolMod.TabIndex = 41;
            // 
            // cmbModificarID
            // 
            this.cmbModificarID.FormattingEnabled = true;
            this.cmbModificarID.Location = new System.Drawing.Point(177, 23);
            this.cmbModificarID.Name = "cmbModificarID";
            this.cmbModificarID.Size = new System.Drawing.Size(121, 21);
            this.cmbModificarID.TabIndex = 40;
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(281, 398);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnModificarUsuario.TabIndex = 38;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(12, 23);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 13);
            this.id.TabIndex = 30;
            this.id.Text = "ID";
            // 
            // txtApellidoNombreMod
            // 
            this.txtApellidoNombreMod.Location = new System.Drawing.Point(177, 181);
            this.txtApellidoNombreMod.Name = "txtApellidoNombreMod";
            this.txtApellidoNombreMod.Size = new System.Drawing.Size(191, 20);
            this.txtApellidoNombreMod.TabIndex = 27;
            // 
            // txtPasswordMod
            // 
            this.txtPasswordMod.Location = new System.Drawing.Point(177, 121);
            this.txtPasswordMod.Name = "txtPasswordMod";
            this.txtPasswordMod.Size = new System.Drawing.Size(191, 20);
            this.txtPasswordMod.TabIndex = 24;
            // 
            // txtNombreUsuarioMod
            // 
            this.txtNombreUsuarioMod.Location = new System.Drawing.Point(177, 67);
            this.txtNombreUsuarioMod.Name = "txtNombreUsuarioMod";
            this.txtNombreUsuarioMod.Size = new System.Drawing.Size(191, 20);
            this.txtNombreUsuarioMod.TabIndex = 23;
            // 
            // lblDireccionCli
            // 
            this.lblDireccionCli.AutoSize = true;
            this.lblDireccionCli.Location = new System.Drawing.Point(12, 236);
            this.lblDireccionCli.Name = "lblDireccionCli";
            this.lblDireccionCli.Size = new System.Drawing.Size(23, 13);
            this.lblDireccionCli.TabIndex = 36;
            this.lblDireccionCli.Text = "Rol";
            // 
            // lblIngresosCli
            // 
            this.lblIngresosCli.AutoSize = true;
            this.lblIngresosCli.Location = new System.Drawing.Point(12, 184);
            this.lblIngresosCli.Name = "lblIngresosCli";
            this.lblIngresosCli.Size = new System.Drawing.Size(92, 13);
            this.lblIngresosCli.TabIndex = 35;
            this.lblIngresosCli.Text = "Apellido y Nombre";
            // 
            // lblApellidoCli
            // 
            this.lblApellidoCli.AutoSize = true;
            this.lblApellidoCli.Location = new System.Drawing.Point(12, 121);
            this.lblApellidoCli.Name = "lblApellidoCli";
            this.lblApellidoCli.Size = new System.Drawing.Size(61, 13);
            this.lblApellidoCli.TabIndex = 32;
            this.lblApellidoCli.Text = "Contraseña";
            // 
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(12, 67);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(43, 13);
            this.lblNombreCli.TabIndex = 31;
            this.lblNombreCli.Text = "Usuario";
            // 
            // EliminarUsuario
            // 
            this.EliminarUsuario.Controls.Add(this.btnEliminarUsuario);
            this.EliminarUsuario.Controls.Add(this.cmbEliminarID);
            this.EliminarUsuario.Controls.Add(this.label2);
            this.EliminarUsuario.Controls.Add(this.label1);
            this.EliminarUsuario.Location = new System.Drawing.Point(4, 22);
            this.EliminarUsuario.Name = "EliminarUsuario";
            this.EliminarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.EliminarUsuario.Size = new System.Drawing.Size(380, 452);
            this.EliminarUsuario.TabIndex = 1;
            this.EliminarUsuario.Text = "EliminarUsuario";
            this.EliminarUsuario.UseVisualStyleBackColor = true;
            this.EliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(211, 173);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 35;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.EliminarUsuario_Click);
            // 
            // cmbEliminarID
            // 
            this.cmbEliminarID.FormattingEnabled = true;
            this.cmbEliminarID.Location = new System.Drawing.Point(76, 113);
            this.cmbEliminarID.Name = "cmbEliminarID";
            this.cmbEliminarID.Size = new System.Drawing.Size(210, 21);
            this.cmbEliminarID.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Eliminar Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID";
            // 
            // BuscarUsuario
            // 
            this.BuscarUsuario.Controls.Add(this.dgvUsuarios);
            this.BuscarUsuario.Controls.Add(this.btnBuscarUsuario);
            this.BuscarUsuario.Controls.Add(this.txtBuscarApellidoNombre);
            this.BuscarUsuario.Controls.Add(this.label4);
            this.BuscarUsuario.Location = new System.Drawing.Point(4, 22);
            this.BuscarUsuario.Name = "BuscarUsuario";
            this.BuscarUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.BuscarUsuario.Size = new System.Drawing.Size(380, 452);
            this.BuscarUsuario.TabIndex = 2;
            this.BuscarUsuario.Text = "BuscarUsuario";
            this.BuscarUsuario.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(17, 161);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(353, 150);
            this.dgvUsuarios.TabIndex = 38;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(295, 353);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUsuario.TabIndex = 37;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtBuscarApellidoNombre
            // 
            this.txtBuscarApellidoNombre.Location = new System.Drawing.Point(179, 54);
            this.txtBuscarApellidoNombre.Name = "txtBuscarApellidoNombre";
            this.txtBuscarApellidoNombre.Size = new System.Drawing.Size(191, 20);
            this.txtBuscarApellidoNombre.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Apellido y Nombre";
            // 
            // AgregarUsuario
            // 
            this.AgregarUsuario.Controls.Add(this.btnAgregarUsuario);
            this.AgregarUsuario.Controls.Add(this.cmbRol);
            this.AgregarUsuario.Controls.Add(this.txtApellidoNombre);
            this.AgregarUsuario.Controls.Add(this.txtPassword);
            this.AgregarUsuario.Controls.Add(this.txtNombreUsuario);
            this.AgregarUsuario.Controls.Add(this.label8);
            this.AgregarUsuario.Controls.Add(this.label7);
            this.AgregarUsuario.Controls.Add(this.label6);
            this.AgregarUsuario.Controls.Add(this.label5);
            this.AgregarUsuario.Location = new System.Drawing.Point(4, 22);
            this.AgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.AgregarUsuario.Name = "AgregarUsuario";
            this.AgregarUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.AgregarUsuario.Size = new System.Drawing.Size(380, 452);
            this.AgregarUsuario.TabIndex = 3;
            this.AgregarUsuario.Text = "AgregarUsuario";
            this.AgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(265, 273);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(62, 24);
            this.btnAgregarUsuario.TabIndex = 8;
            this.btnAgregarUsuario.Text = "Agregar ";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(179, 142);
            this.cmbRol.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(76, 21);
            this.cmbRol.TabIndex = 7;
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.Location = new System.Drawing.Point(179, 111);
            this.txtApellidoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(76, 20);
            this.txtApellidoNombre.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(179, 83);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(76, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(179, 53);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtNombreUsuario.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Rol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido y Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Usuario";
            // 
            // FrmABMUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmABMUsuarios";
            this.Text = "ABM_Usuarios";
            this.Load += new System.EventHandler(this.FrmABMUsuarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.ModificarUsuario.ResumeLayout(false);
            this.ModificarUsuario.PerformLayout();
            this.EliminarUsuario.ResumeLayout(false);
            this.EliminarUsuario.PerformLayout();
            this.BuscarUsuario.ResumeLayout(false);
            this.BuscarUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.AgregarUsuario.ResumeLayout(false);
            this.AgregarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ModificarUsuario;
        private System.Windows.Forms.TabPage EliminarUsuario;
        private System.Windows.Forms.TabPage BuscarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtApellidoNombreMod;
        private System.Windows.Forms.TextBox txtPasswordMod;
        private System.Windows.Forms.TextBox txtNombreUsuarioMod;
        private System.Windows.Forms.Label lblDireccionCli;
        private System.Windows.Forms.Label lblIngresosCli;
        private System.Windows.Forms.Label lblApellidoCli;
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.ComboBox cmbEliminarID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.ComboBox cmbModificarID;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.TabPage AgregarUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtApellidoNombre;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbRolMod;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtBuscarApellidoNombre;
    }
}