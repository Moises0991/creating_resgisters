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
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

namespace Ficheros
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();

            string cadena;
            string[] campos = new String[2];
            char[] separador = { ':' };

            try
            {

                StreamReader clienteArch = File.OpenText("Clientes.txt");

                while (clienteArch.EndOfStream == false)
                {
                    cadena = clienteArch.ReadLine();

                    campos = cadena.Split(separador);

                    if (campos[0].Trim().Equals("NOMBRE"))
                    {
                        clienteCbx.Items.Add(campos[1].Trim());
                    }
                }

            }
            catch
            {
                MessageBox.Show("NO SE ENCONTRO ARCHIVO CLIENTES");
            }


            string cadena2;
            string[] campos2 = new String[2];
            char[] separador2 = { ':' };

            try
            {

                StreamReader articulosArch = File.OpenText("Articulos.txt");

                while (articulosArch.EndOfStream == false)
                {
                    cadena2 = articulosArch.ReadLine();

                    campos2 = cadena2.Split(separador);

                    if (campos2[0].Trim().Equals("NOMBRE"))
                    {
                        articuloCbx.Items.Add(campos2[1].Trim());
                    }
                }

            }
            catch
            {
                MessageBox.Show("NO SE ENCONTRO ARCHIVO ARTICULOS");
            }
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void capturarBtn_Click(object sender, EventArgs e)
        {

            StreamWriter pedidoArch = new StreamWriter("Pedidos.txt", true);

            StreamWriter detallesArch = new StreamWriter("Detalles_Pedidos.txt", true);


            //GUARDA DATOS POSTERIOR A LECTURA DE DOCT
            try
            {

                pedidoArch.WriteLine("Cliente:          " + clienteCbx.Text);
                pedidoArch.WriteLine("Num Pedido:  " + numPedidoBox.Text);
                detallesArch.WriteLine("Num Pedido:  " + numPedidoBox.Text);
                detallesArch.WriteLine("Articulo:  " + articuloCbx.Text);
                detallesArch.WriteLine("Cantidad:  " + cantidadBox.Text);

                string cadena3;
                string[] campos3 = new String[2];
                char[] separador3 = { ':' };

                try
                {

                    StreamReader consultaPrecio = File.OpenText("Articulos.txt");

                    int encontrado = 0;
                    int precio;

                    while (consultaPrecio.EndOfStream == false)
                    {

                        cadena3 = consultaPrecio.ReadLine();

                        campos3 = cadena3.Split(separador3);

                        if (encontrado==1)
                        {
                            detallesArch.WriteLine("Precio:  "+ campos3[1].Trim());

                            precio = int.Parse(campos3[1].Trim());

                            detallesArch.WriteLine("");
                            pedidoArch.WriteLine("Monto Total:  " + int.Parse(cantidadBox.Text.Trim()) * (precio));
                            pedidoArch.WriteLine("");
                            encontrado++;
                        }

                        if (campos3[0].Trim().Equals("NOMBRE") && campos3[1].Trim().Equals(""+articuloCbx.Text))
                        {
                            encontrado = 1;
                        }
                    }

                    consultaPrecio.Close();

                }
                catch
                {
                    MessageBox.Show("NO SE ENCONTRO ARCHIVO ARTICULOS");
                }
    
                 


            }
            catch
            {

                MessageBox.Show("Error");

            }

           // pedidoArch.Flush();
            pedidoArch.Close();
            detallesArch.Close();
        }
    }
}
