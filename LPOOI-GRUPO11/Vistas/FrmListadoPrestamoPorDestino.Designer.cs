namespace Vistas
{
    partial class FrmListadoPrestamoPorDestino
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
            this.grdPrestamos = new System.Windows.Forms.DataGridView();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamos)).BeginInit();
            this.SuspendLayout();
            this.lblAnulados = new System.Windows.Forms.Label();
            this.lblCancelados = new System.Windows.Forms.Label();
            this.lblOtorgados = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            // 
            // grdPrestamos
            // 
            this.grdPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamos.Location = new System.Drawing.Point(12, 39);
            this.grdPrestamos.Name = "grdPrestamos";
            this.grdPrestamos.Size = new System.Drawing.Size(646, 210);
            this.grdPrestamos.TabIndex = 0;
            this.grdPrestamos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPrestamos_CellContentClick);
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(12, 12);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(140, 21);
            this.cmbDestinos.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(158, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmListadoPrestamoPorDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 307);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbDestinos);
            this.Controls.Add(this.grdPrestamos);
            this.Name = "FrmListadoPrestamoPorDestino";
            this.Text = "FrmListadoPrestamo";
            this.Load += new System.EventHandler(this.FrmListadoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamos)).EndInit();
            this.ResumeLayout(false);
            //
            // lblOtorgados
            //
            this.lblOtorgados.AutoSize = true;
            this.lblOtorgados.Location = new System.Drawing.Point(20, 330);
            this.lblOtorgados.Name = "lblOtorgados";
            this.lblOtorgados.Size = new System.Drawing.Size(70, 13);
            this.lblOtorgados.Text = "Otorgados: 0";
            //
            // lblPendientes
            //
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Location = new System.Drawing.Point(20, 350);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(75, 13);
            this.lblPendientes.Text = "Pendientes : 0";
            //
            // lblCancelados
            //
            this.lblCancelados.AutoSize = true;
            this.lblCancelados.Location = new System.Drawing.Point(20, 370);
            this.lblCancelados.Name = "lblCancelados";
            this.lblCancelados.Size = new System.Drawing.Size(79, 13);
            this.lblCancelados.Text = "Cancelados : 0";
            //
            // lblAnulados
            //
            this.lblAnulados.AutoSize = true;
            this.lblAnulados.Location = new System.Drawing.Point(20, 390);
            this.lblAnulados.Name = "lblAnulados";
            this.lblAnulados.Size = new System.Drawing.Size(67, 13);
            this.lblAnulados.Text = "Anulados: 0";
            //
            this.Controls.Add(this.lblOtorgados);
            this.Controls.Add(this.lblPendientes);
            this.Controls.Add(this.lblCancelados);
            this.Controls.Add(this.lblAnulados);
        }

        #endregion

        private System.Windows.Forms.DataGridView grdPrestamos;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblOtorgados;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label lblCancelados;
        private System.Windows.Forms.Label lblAnulados;

     
    }
}