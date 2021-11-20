using System;
using System.IO;
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
    public partial class ConsultaPedidos : Form
    {
        public ConsultaPedidos()
        {
            InitializeComponent();
        }

        private void ConsultaPedidos_Load(object sender, EventArgs e)
        {
            try
            {

                StreamReader pedidosLeer = new StreamReader("Pedidos.txt");

                string texto;


                texto = pedidosLeer.ReadLine();

                while (texto != null)
                {

                    clientesRichText.AppendText(texto + "\n");
                    texto = pedidosLeer.ReadLine();
                }
            }
            catch
            {

                MessageBox.Show("AUN NO SE CUENTA CON PEDIDOS REGISTRADOS");

            }
        }
    }
}
