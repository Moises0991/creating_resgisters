namespace Ficheros
{
    partial class ConsDetalles
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
            this.detallesRichText = new System.Windows.Forms.RichTextBox();
            this.detallado_pedidoslbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // detallesRichText
            // 
            this.detallesRichText.Location = new System.Drawing.Point(174, 71);
            this.detallesRichText.Name = "detallesRichText";
            this.detallesRichText.Size = new System.Drawing.Size(421, 301);
            this.detallesRichText.TabIndex = 20;
            this.detallesRichText.Text = "";
            // 
            // detallado_pedidoslbl
            // 
            this.detallado_pedidoslbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detallado_pedidoslbl.Location = new System.Drawing.Point(252, 38);
            this.detallado_pedidoslbl.Name = "detallado_pedidoslbl";
            this.detallado_pedidoslbl.Size = new System.Drawing.Size(287, 30);
            this.detallado_pedidoslbl.TabIndex = 19;
            this.detallado_pedidoslbl.Text = "DETALLADO DE PEDIDOS";
            // 
            // ConsDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.detallesRichText);
            this.Controls.Add(this.detallado_pedidoslbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsDetalles";
            this.Text = "ConsDetalles";
            this.Load += new System.EventHandler(this.ConsDetalles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox detallesRichText;
        private System.Windows.Forms.Label detallado_pedidoslbl;
    }
}