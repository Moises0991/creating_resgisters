namespace Ficheros
{
    partial class ConsultaArt
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
            this.articulosRichText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "LISTADO  DE ARTICULOS";
            // 
            // articulosRichText
            // 
            this.articulosRichText.Location = new System.Drawing.Point(152, 71);
            this.articulosRichText.Name = "articulosRichText";
            this.articulosRichText.Size = new System.Drawing.Size(421, 301);
            this.articulosRichText.TabIndex = 16;
            this.articulosRichText.Text = "";
            // 
            // ConsultaArt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(189)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.articulosRichText);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultaArt";
            this.Text = "ConsultaArt";
            this.Load += new System.EventHandler(this.ConsultaArt_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox articulosRichText;
    }
}