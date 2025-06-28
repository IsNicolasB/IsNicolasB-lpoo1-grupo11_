namespace Vistas
{
    partial class FrmDestinoModificar
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
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestinoDes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinoCod = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(12, 26);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(250, 24);
            this.cmbDestino.TabIndex = 2;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mostrar Destino";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDestinoDes
            // 
            this.txtDestinoDes.Location = new System.Drawing.Point(13, 83);
            this.txtDestinoDes.Name = "txtDestinoDes";
            this.txtDestinoDes.Size = new System.Drawing.Size(249, 22);
            this.txtDestinoDes.TabIndex = 5;
            this.txtDestinoDes.TextChanged += new System.EventHandler(this.txtDestinoDes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Codigo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDestinoCod
            // 
            this.txtDestinoCod.Location = new System.Drawing.Point(12, 138);
            this.txtDestinoCod.Name = "txtDestinoCod";
            this.txtDestinoCod.Size = new System.Drawing.Size(248, 22);
            this.txtDestinoCod.TabIndex = 7;
            this.txtDestinoCod.TextChanged += new System.EventHandler(this.txtDestinoCod_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(88, 200);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 26);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // FrmDestinoModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDestinoCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestinoDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDestino);
            this.Name = "FrmDestinoModificar";
            this.Text = "FrmDestinoModificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestinoDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestinoCod;
        private System.Windows.Forms.Button btnModificar;
    }
}