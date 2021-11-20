namespace Ficheros
{
    partial class Forma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.darDeAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemArticulo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separador1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.detallesDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separador2 = new System.Windows.Forms.ToolStripSeparator();
            this.IndexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(52)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darDeAltaToolStripMenuItem,
            this.separador1,
            this.consultasToolStripMenuItem,
            this.separador2,
            this.IndexToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // darDeAltaToolStripMenuItem
            // 
            this.darDeAltaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemArticulo,
            this.toolStripSeparator1,
            this.MenuItemCliente,
            this.toolStripSeparator2,
            this.pedidoToolStripMenuItem});
            this.darDeAltaToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darDeAltaToolStripMenuItem.Name = "darDeAltaToolStripMenuItem";
            this.darDeAltaToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.darDeAltaToolStripMenuItem.Text = "Registrar";
            // 
            // MenuItemArticulo
            // 
            this.MenuItemArticulo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.MenuItemArticulo.Name = "MenuItemArticulo";
            this.MenuItemArticulo.Size = new System.Drawing.Size(122, 22);
            this.MenuItemArticulo.Text = "Articulo";
            this.MenuItemArticulo.Click += new System.EventHandler(this.MenuItemArticulo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // MenuItemCliente
            // 
            this.MenuItemCliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.MenuItemCliente.Name = "MenuItemCliente";
            this.MenuItemCliente.Size = new System.Drawing.Size(122, 22);
            this.MenuItemCliente.Text = "Cliente";
            this.MenuItemCliente.Click += new System.EventHandler(this.MenuItemCliente_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            this.pedidoToolStripMenuItem.Click += new System.EventHandler(this.pedidoToolStripMenuItem_Click);
            // 
            // separador1
            // 
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(6, 23);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.toolStripSeparator3,
            this.clientesToolStripMenuItem,
            this.toolStripSeparator4,
            this.pedidosToolStripMenuItem,
            this.toolStripSeparator5,
            this.detallesDePedidosToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(176, 6);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(176, 6);
            // 
            // detallesDePedidosToolStripMenuItem
            // 
            this.detallesDePedidosToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.detallesDePedidosToolStripMenuItem.Name = "detallesDePedidosToolStripMenuItem";
            this.detallesDePedidosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.detallesDePedidosToolStripMenuItem.Text = "Detalles de pedidos";
            this.detallesDePedidosToolStripMenuItem.Click += new System.EventHandler(this.detallesDePedidosToolStripMenuItem_Click);
            // 
            // separador2
            // 
            this.separador2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(6, 23);
            // 
            // IndexToolStripMenuItem
            // 
            this.IndexToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem";
            this.IndexToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.IndexToolStripMenuItem.Text = "Home";
            this.IndexToolStripMenuItem.Click += new System.EventHandler(this.IndexToolStripMenuItem_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(0, 28);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(696, 425);
            this.panelPrincipal.TabIndex = 1;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // Forma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(697, 450);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Forma";
            this.Text = "Archivos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IndexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darDeAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separador1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator separador2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemArticulo;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}

