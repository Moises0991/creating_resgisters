namespace Ficheros
{
    partial class Cliente
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
            this.label4 = new System.Windows.Forms.Label();
            this.direccionTbx = new System.Windows.Forms.TextBox();
            this.nombreTbx = new System.Windows.Forms.TextBox();
            this.idTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descuentoTxb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.capturarClienteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "REGISTRO DE CLIENTE";
            // 
            // direccionTbx
            // 
            this.direccionTbx.Location = new System.Drawing.Point(308, 215);
            this.direccionTbx.Name = "direccionTbx";
            this.direccionTbx.Size = new System.Drawing.Size(156, 20);
            this.direccionTbx.TabIndex = 13;
            // 
            // nombreTbx
            // 
            this.nombreTbx.Location = new System.Drawing.Point(308, 174);
            this.nombreTbx.Name = "nombreTbx";
            this.nombreTbx.Size = new System.Drawing.Size(156, 20);
            this.nombreTbx.TabIndex = 12;
            // 
            // idTbx
            // 
            this.idTbx.Location = new System.Drawing.Point(308, 129);
            this.idTbx.Name = "idTbx";
            this.idTbx.Size = new System.Drawing.Size(156, 20);
            this.idTbx.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // descuentoTxb
            // 
            this.descuentoTxb.Location = new System.Drawing.Point(308, 254);
            this.descuentoTxb.Name = "descuentoTxb";
            this.descuentoTxb.Size = new System.Drawing.Size(156, 20);
            this.descuentoTxb.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Descuento";
            // 
            // capturarClienteBtn
            // 
            this.capturarClienteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(101)))));
            this.capturarClienteBtn.Location = new System.Drawing.Point(337, 292);
            this.capturarClienteBtn.Name = "capturarClienteBtn";
            this.capturarClienteBtn.Size = new System.Drawing.Size(113, 27);
            this.capturarClienteBtn.TabIndex = 18;
            this.capturarClienteBtn.Text = "Capturar";
            this.capturarClienteBtn.UseVisualStyleBackColor = false;
            this.capturarClienteBtn.Click += new System.EventHandler(this.capturarClienteBtn_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.capturarClienteBtn);
            this.Controls.Add(this.descuentoTxb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.direccionTbx);
            this.Controls.Add(this.nombreTbx);
            this.Controls.Add(this.idTbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox direccionTbx;
        private System.Windows.Forms.TextBox nombreTbx;
        private System.Windows.Forms.TextBox idTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descuentoTxb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button capturarClienteBtn;
    }
}