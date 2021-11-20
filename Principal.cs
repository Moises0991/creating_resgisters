using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficheros
{
    public partial class Forma : Form
    {
        public Forma() {

            InitializeComponent();

            Abrir_frm(new Index());
        }

        private void Abrir_frm(Object abrir_frm) {

            if (this.panelPrincipal.Controls.Count > 0) //se pregunta si existe control en el interior del panel
                this.panelPrincipal.Controls.RemoveAt(0);   //si es verdadero se elimina

            Form frmArticulo = abrir_frm as Form;
            frmArticulo.TopLevel = false;   //le decimos que sera un formulario secundario
            frmArticulo.Dock = DockStyle.Fill;  //se adapta a la forma
            this.panelPrincipal.Controls.Add(frmArticulo);//se agrega el formulario al panel
            this.panelPrincipal.Tag = frmArticulo;
            frmArticulo.Show();

        }

        private void MenuItemArticulo_Click(object sender, EventArgs e) {

            //Form articulos = new Articulo();
            //articulos.Show();

            Abrir_frm(new Articulo());
        }

        private void MenuItemCliente_Click(object sender, EventArgs e) {

            Abrir_frm(new Cliente());

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e) {

            Abrir_frm(new Pedido());

        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e) {

            Abrir_frm(new ConsultaArt());

            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Abrir_frm(new ConsultaClient());

        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Abrir_frm(new ConsultaPedidos());

        }

        private void detallesDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Abrir_frm(new ConsDetalles());

        }

        private void IndexToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Abrir_frm(new Index());

        }
    }
}
