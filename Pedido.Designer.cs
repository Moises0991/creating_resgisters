namespace Ficheros
{
    partial class Pedido
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
            this.numPedidoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numPedidolbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clienteCbx = new System.Windows.Forms.ComboBox();
            this.articuloCbx = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.capturarBtn = new System.Windows.Forms.Button();
            this.cantidadBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 30);
            this.label4.TabIndex = 21;
            this.label4.Text = "REGISTRO DE PEDIDO";
            // 
            // numPedidoBox
            // 
            this.numPedidoBox.Location = new System.Drawing.Point(128, 187);
            this.numPedidoBox.Name = "numPedidoBox";
            this.numPedidoBox.Size = new System.Drawing.Size(156, 20);
            this.numPedidoBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cliente";
            // 
            // numPedidolbl
            // 
            this.numPedidolbl.AutoSize = true;
            this.numPedidolbl.Location = new System.Drawing.Point(48, 190);
            this.numPedidolbl.Name = "numPedidolbl";
            this.numPedidolbl.Size = new System.Drawing.Size(65, 13);
            this.numPedidolbl.TabIndex = 16;
            this.numPedidolbl.Text = "Num Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Articulo";
            // 
            // clienteCbx
            // 
            this.clienteCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteCbx.FormattingEnabled = true;
            this.clienteCbx.Location = new System.Drawing.Point(128, 108);
            this.clienteCbx.Name = "clienteCbx";
            this.clienteCbx.Size = new System.Drawing.Size(156, 21);
            this.clienteCbx.TabIndex = 23;
            // 
            // articuloCbx
            // 
            this.articuloCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articuloCbx.FormattingEnabled = true;
            this.articuloCbx.Location = new System.Drawing.Point(128, 149);
            this.articuloCbx.Name = "articuloCbx";
            this.articuloCbx.Size = new System.Drawing.Size(156, 21);
            this.articuloCbx.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.capturarBtn);
            this.panel1.Controls.Add(this.cantidadBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.articuloCbx);
            this.panel1.Controls.Add(this.clienteCbx);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numPedidoBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numPedidolbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(198, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 360);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // capturarBtn
            // 
            this.capturarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(223)))), ((int)(((byte)(101)))));
            this.capturarBtn.Location = new System.Drawing.Point(148, 251);
            this.capturarBtn.Name = "capturarBtn";
            this.capturarBtn.Size = new System.Drawing.Size(113, 27);
            this.capturarBtn.TabIndex = 31;
            this.capturarBtn.Text = "Capturar";
            this.capturarBtn.UseVisualStyleBackColor = false;
            this.capturarBtn.Click += new System.EventHandler(this.capturarBtn_Click);
            // 
            // cantidadBox
            // 
            this.cantidadBox.Location = new System.Drawing.Point(128, 225);
            this.cantidadBox.Name = "cantidadBox";
            this.cantidadBox.Size = new System.Drawing.Size(156, 20);
            this.cantidadBox.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cantidad";
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(106)))));
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numPedidoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numPedidolbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox clienteCbx;
        private System.Windows.Forms.ComboBox articuloCbx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox cantidadBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button capturarBtn;
    }
}