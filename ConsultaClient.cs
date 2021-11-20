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
    public partial class ConsultaClient : Form
    {
        public ConsultaClient()
        {
            InitializeComponent();
        }

        private void ConsultaClient_Load(object sender, EventArgs e)
        {

            try
            {

                StreamReader clientLeer = new StreamReader("Clientes.txt");

                string texto;


                texto = clientLeer.ReadLine();

                while (texto != null)
                {

                    clientesRichText.AppendText(texto + "\n");
                    texto = clientLeer.ReadLine();
                }
            }
            catch
            {

                MessageBox.Show("AUN NO SE CUENTA CON CLIENTES REGISTRADOS");

            }
        }
    }
}
