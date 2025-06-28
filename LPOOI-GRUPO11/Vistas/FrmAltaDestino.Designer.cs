namespace Vistas
{
    partial class FrmAltaDestino
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestinoDes = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDestinoDes
            // 
            this.txtDestinoDes.Location = new System.Drawing.Point(8, 79);
            this.txtDestinoDes.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestinoDes.Name = "txtDestinoDes";
            this.txtDestinoDes.Size = new System.Drawing.Size(188, 20);
            this.txtDestinoDes.TabIndex = 3;
            this.txtDestinoDes.TextChanged += new System.EventHandler(this.txtDestinoDes_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(71, 174);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 22);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmAltaDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDestinoDes);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAltaDestino";
            this.Text = "FrmDestino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestinoDes;
        private System.Windows.Forms.Button btnAgregar;

    }
}