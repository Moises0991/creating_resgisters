namespace Ficheros
{
    partial class Articulo
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.nombreTbx = new System.Windows.Forms.TextBox();
            this.precioTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CapturarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(317, 128);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(156, 20);
            this.idTbx.TabIndex = 4;
            // 
            // nombreTbx
            // 
            this.nombreTbx.Location = new System.Drawing.Point(317, 173);
            this.nombreTbx.Name = "nombreTbx";
            this.nombreTbx.Size = new System.Drawing.Size(156, 20);
            this.nombreTbx.TabIndex = 5;
            // 
            // precioTbx
            // 
            this.precioTbx.Location = new System.Drawing.Point(317, 214);
            this.precioTbx.Name = "precioTbx";
            this.precioTbx.Size = new System.Drawing.Size(156, 20);
            this.precioTbx.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "REGISTRO DE ARTICULO";
            // 
            // CapturarBtn
            // 
            this.CapturarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(101)))));
            this.CapturarBtn.Location = new System.Drawing.Point(345, 266);
            this.CapturarBtn.Name = "CapturarBtn";
            this.CapturarBtn.Size = new System.Drawing.Size(113, 27);
            this.CapturarBtn.TabIndex = 8;
            this.CapturarBtn.Text = "Capturar";
            this.CapturarBtn.UseVisualStyleBackColor = false;
            this.CapturarBtn.Click += new System.EventHandler(this.CapturarBtn_Click);
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.CapturarBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.precioTbx);
            this.Controls.Add(this.nombreTbx);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Articulo";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.TextBox nombreTbx;
        private System.Windows.Forms.TextBox precioTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CapturarBtn;
    }
}