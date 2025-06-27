namespace Vistas
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDestinoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDestinoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDestinoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarPagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.aBMUsuarioToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(507, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarPagosToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.lolToolStripMenuItem_Click);
            // 
            // aBMUsuarioToolStripMenuItem
            // 
            this.aBMUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMUsuarioToolStripMenuItem1,
            this.aBMDestinoToolStripMenuItem,
            this.aBMClienteToolStripMenuItem});
            this.aBMUsuarioToolStripMenuItem.Name = "aBMUsuarioToolStripMenuItem";
            this.aBMUsuarioToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMUsuarioToolStripMenuItem.Text = "ABM";
            // 
            // aBMUsuarioToolStripMenuItem1
            // 
            this.aBMUsuarioToolStripMenuItem1.Name = "aBMUsuarioToolStripMenuItem1";
            this.aBMUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.aBMUsuarioToolStripMenuItem1.Text = "ABM Usuario";
            this.aBMUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.aBMUsuarioToolStripMenuItem1_Click);
            // 
            // aBMDestinoToolStripMenuItem
            // 
            this.aBMDestinoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDestinoToolStripMenuItem1,
            this.modificarDestinoToolStripMenuItem1,
            this.eliminarDestinoToolStripMenuItem1});
            this.aBMDestinoToolStripMenuItem.Name = "aBMDestinoToolStripMenuItem";
            this.aBMDestinoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aBMDestinoToolStripMenuItem.Text = "ABM Destino";
            // 
            // altaDestinoToolStripMenuItem1
            // 
            this.altaDestinoToolStripMenuItem1.Name = "altaDestinoToolStripMenuItem1";
            this.altaDestinoToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.altaDestinoToolStripMenuItem1.Text = "Alta Destino";
            this.altaDestinoToolStripMenuItem1.Click += new System.EventHandler(this.altaDestinoToolStripMenuItem1_Click);
            // 
            // modificarDestinoToolStripMenuItem1
            // 
            this.modificarDestinoToolStripMenuItem1.Name = "modificarDestinoToolStripMenuItem1";
            this.modificarDestinoToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.modificarDestinoToolStripMenuItem1.Text = "Modificar Destino";
            this.modificarDestinoToolStripMenuItem1.Click += new System.EventHandler(this.modificarDestinoToolStripMenuItem1_Click);
            // 
            // eliminarDestinoToolStripMenuItem1
            // 
            this.eliminarDestinoToolStripMenuItem1.Name = "eliminarDestinoToolStripMenuItem1";
            this.eliminarDestinoToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.eliminarDestinoToolStripMenuItem1.Text = "Eliminar Destino";
            this.eliminarDestinoToolStripMenuItem1.Click += new System.EventHandler(this.eliminarDestinoToolStripMenuItem1_Click);
            // 
            // aBMClienteToolStripMenuItem
            // 
            this.aBMClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaClienteToolStripMenuItem1,
            this.aBMClienteToolStripMenuItem1});
            this.aBMClienteToolStripMenuItem.Name = "aBMClienteToolStripMenuItem";
            this.aBMClienteToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aBMClienteToolStripMenuItem.Text = "ABM Cliente";
            // 
            // altaClienteToolStripMenuItem1
            // 
            this.altaClienteToolStripMenuItem1.Name = "altaClienteToolStripMenuItem1";
            this.altaClienteToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.altaClienteToolStripMenuItem1.Text = "Alta Cliente";
            this.altaClienteToolStripMenuItem1.Click += new System.EventHandler(this.altaClienteToolStripMenuItem1_Click);
            // 
            // aBMClienteToolStripMenuItem1
            // 
            this.aBMClienteToolStripMenuItem1.Name = "aBMClienteToolStripMenuItem1";
            this.aBMClienteToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.aBMClienteToolStripMenuItem1.Text = "ABM Cliente";
            this.aBMClienteToolStripMenuItem1.Click += new System.EventHandler(this.aBMClienteToolStripMenuItem1_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaPrestamoToolStripMenuItem,
            this.listarPrestamosToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // altaPrestamoToolStripMenuItem
            // 
            this.altaPrestamoToolStripMenuItem.Name = "altaPrestamoToolStripMenuItem";
            this.altaPrestamoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.altaPrestamoToolStripMenuItem.Text = "Alta Prestamo";
            this.altaPrestamoToolStripMenuItem.Click += new System.EventHandler(this.altaPrestamoToolStripMenuItem_Click);
            // 
            // listarPrestamosToolStripMenuItem
            // 
            this.listarPrestamosToolStripMenuItem.Name = "listarPrestamosToolStripMenuItem";
            this.listarPrestamosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.listarPrestamosToolStripMenuItem.Text = "Listar Prestamos";
            this.listarPrestamosToolStripMenuItem.Click += new System.EventHandler(this.listarPrestamosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // gestionarPagosToolStripMenuItem
            // 
            this.gestionarPagosToolStripMenuItem.Name = "gestionarPagosToolStripMenuItem";
            this.gestionarPagosToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.gestionarPagosToolStripMenuItem.Text = "Gestionar Pagos";
            this.gestionarPagosToolStripMenuItem.Click += new System.EventHandler(this.gestionarPagosToolStripMenuItem_Click_1);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 374);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMDestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDestinoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarDestinoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarDestinoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aBMClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionarPagosToolStripMenuItem;
    }
}