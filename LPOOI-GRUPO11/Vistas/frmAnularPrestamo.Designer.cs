namespace Vistas
{
    partial class frmAnularPrestamo
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
            this.labelAnular = new System.Windows.Forms.Label();
            this.txtBoxAnularPrestamo = new System.Windows.Forms.TextBox();
            this.buttonAnularPrestamo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAnular
            // 
            this.labelAnular.AutoSize = true;
            this.labelAnular.Location = new System.Drawing.Point(29, 39);
            this.labelAnular.Name = "labelAnular";
            this.labelAnular.Size = new System.Drawing.Size(145, 17);
            this.labelAnular.TabIndex = 3;
            this.labelAnular.Text = "ANULAR PRESTAMO";
            this.labelAnular.Click += new System.EventHandler(this.labelAnular_Click);
            // 
            // txtBoxAnularPrestamo
            // 
            this.txtBoxAnularPrestamo.Location = new System.Drawing.Point(48, 98);
            this.txtBoxAnularPrestamo.Name = "txtBoxAnularPrestamo";
            this.txtBoxAnularPrestamo.Size = new System.Drawing.Size(217, 22);
            this.txtBoxAnularPrestamo.TabIndex = 4;
            this.txtBoxAnularPrestamo.TextChanged += new System.EventHandler(this.txtBoxAnularPrestamo_TextChanged);
            // 
            // buttonAnularPrestamo
            // 
            this.buttonAnularPrestamo.Location = new System.Drawing.Point(12, 195);
            this.buttonAnularPrestamo.Name = "buttonAnularPrestamo";
            this.buttonAnularPrestamo.Size = new System.Drawing.Size(83, 40);
            this.buttonAnularPrestamo.TabIndex = 5;
            this.buttonAnularPrestamo.Text = "Confirmar";
            this.buttonAnularPrestamo.UseVisualStyleBackColor = true;
            this.buttonAnularPrestamo.Click += new System.EventHandler(this.buttonAnularPrestamo_Click);
            // 
            // frmAnularPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 281);
            this.Controls.Add(this.buttonAnularPrestamo);
            this.Controls.Add(this.txtBoxAnularPrestamo);
            this.Controls.Add(this.labelAnular);
            this.Name = "frmAnularPrestamo";
            this.Text = "frmAnularPrestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnular;
        private System.Windows.Forms.TextBox txtBoxAnularPrestamo;
        private System.Windows.Forms.Button buttonAnularPrestamo;
    }
}