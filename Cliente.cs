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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void capturarClienteBtn_Click(object sender, EventArgs e)
        {

            StreamWriter clienteArch = new StreamWriter("Clientes.txt", true);

            try
            {
                clienteArch.WriteLine("ID:               \t" + idTbx.Text);
                clienteArch.WriteLine("NOMBRE:   \t" + nombreTbx.Text);
                clienteArch.WriteLine("DIRECCION:     \t" + direccionTbx.Text);
                clienteArch.WriteLine("DESCUENTO:     \t" + descuentoTxb.Text);
                clienteArch.WriteLine("");
            }
            catch
            {

                MessageBox.Show("Error");
            }

            clienteArch.Flush();
            clienteArch.Close();


        }
    }
}
