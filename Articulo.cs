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
    public partial class Articulo : Form
    {
        public Articulo()
        {
            InitializeComponent();
        }

        private void Articulos_Load(object sender, EventArgs e)
        {

        }

        private void CapturarBtn_Click(object sender, EventArgs e)
        {


            try
            {

                StreamWriter articuloArch = new StreamWriter("Articulos.txt", true);

                articuloArch.WriteLine("ID:               \t" + idTbx.Text);
                articuloArch.WriteLine("NOMBRE:   \t" + nombreTbx.Text);
                articuloArch.WriteLine("PRECIO:     \t" + precioTbx.Text);
                articuloArch.WriteLine("");

                articuloArch.Close();
            }
            catch
            {

                MessageBox.Show("AUN NO SE CUENTA CON ARTICULOS REGISTRADOSxd");
            }

            
        }
    }
}
