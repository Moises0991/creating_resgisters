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
    public partial class ConsDetalles : Form
    {
        public ConsDetalles()
        {
            InitializeComponent();
        }

        private void ConsDetalles_Load(object sender, EventArgs e)
        {
            try
            {

                StreamReader LeerDetalles = new StreamReader("Detalles_Pedidos.txt");

                string texto;


                texto = LeerDetalles.ReadLine();

                while (texto != null)
                {

                    detallesRichText.AppendText(texto + "\n");
                    texto = LeerDetalles.ReadLine();
                }
            }
            catch
            {

                MessageBox.Show("AUN NO SE CUENTA CON DETALLADOS DE PEDIDOS");

            }
        }
    }
}
