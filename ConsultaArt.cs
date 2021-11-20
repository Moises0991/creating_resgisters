using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficheros
{
    public partial class ConsultaArt : Form
    {
        public ConsultaArt()
        {
            InitializeComponent();
        }

        private void ConsultaArt_Load(object sender, EventArgs e)
        {


            try
            {

                StreamReader artLeer = new StreamReader("Articulos.txt");

                string texto;

                texto = artLeer.ReadLine();

                while (texto != null)
                {

                    articulosRichText.AppendText(texto + "\n");
                    texto = artLeer.ReadLine();
                }
            }
            catch
            {

                MessageBox.Show("AUN NO SE CUENTA CON PEDIDOS REGISTRADOS");

            }
        }
    }
}
