namespace Vistas
{
    partial class FrmListadoPrestamo
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
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPrestamos
            // 
            this.grdPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrestamos.Location = new System.Drawing.Point(12, 26);
            this.grdPrestamos.Name = "grdPrestamos";
            this.grdPrestamos.Size = new System.Drawing.Size(646, 223);
            this.grdPrestamos.TabIndex = 0;
            // 
            // FrmListadoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 261);
            this.Controls.Add(this.grdPrestamos);
            this.Name = "FrmListadoPrestamo";
            this.Text = "FrmListadoPrestamo";
            this.Load += new System.EventHandler(this.FrmListadoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdPrestamos;


    }
}