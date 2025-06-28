namespace Vistas
{
    partial class FrmEliminarDestino
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestinoDes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinoCod = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mostrar Destino";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(12, 29);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(250, 24);
            this.cmbDestino.TabIndex = 5;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDestinoDes
            // 
            this.txtDestinoDes.Location = new System.Drawing.Point(13, 85);
            this.txtDestinoDes.Name = "txtDestinoDes";
            this.txtDestinoDes.Size = new System.Drawing.Size(249, 22);
            this.txtDestinoDes.TabIndex = 7;
            this.txtDestinoDes.TextChanged += new System.EventHandler(this.txtDestinoDes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDestinoCod
            // 
            this.txtDestinoCod.Location = new System.Drawing.Point(15, 153);
            this.txtDestinoCod.Name = "txtDestinoCod";
            this.txtDestinoCod.Size = new System.Drawing.Size(248, 22);
            this.txtDestinoCod.TabIndex = 9;
            this.txtDestinoCod.TextChanged += new System.EventHandler(this.txtDestinoCod_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(99, 214);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 27);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmEliminarDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtDestinoCod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDestinoDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDestino);
            this.Controls.Add(this.label1);
            this.Name = "FrmEliminarDestino";
            this.Text = "FrmEliminarDestino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestinoDes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestinoCod;
        private System.Windows.Forms.Button btnEliminar;
    }
}