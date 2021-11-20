namespace Ficheros
{
    partial class ConsultaPedidos
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
            this.clientesRichText = new System.Windows.Forms.RichTextBox();
            this.listClienteslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clientesRichText
            // 
            this.clientesRichText.Location = new System.Drawing.Point(174, 71);
            this.clientesRichText.Name = "clientesRichText";
            this.clientesRichText.Size = new System.Drawing.Size(421, 301);
            this.clientesRichText.TabIndex = 20;
            this.clientesRichText.Text = "";
            // 
            // listClienteslbl
            // 
            this.listClienteslbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClienteslbl.Location = new System.Drawing.Point(238, 38);
            this.listClienteslbl.Name = "listClienteslbl";
            this.listClienteslbl.Size = new System.Drawing.Size(287, 30);
            this.listClienteslbl.TabIndex = 19;
            this.listClienteslbl.Text = "LISTADO DE PEDIDOS";
            // 
            // ConsultaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.clientesRichText);
            this.Controls.Add(this.listClienteslbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaPedidos";
            this.Text = "ConsultaPedidos";
            this.Load += new System.EventHandler(this.ConsultaPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox clientesRichText;
        private System.Windows.Forms.Label listClienteslbl;
    }
}