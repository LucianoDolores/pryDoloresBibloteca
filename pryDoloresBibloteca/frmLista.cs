using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryDoloresBibloteca
{
    public partial class frmLista : Form
    {
        public string[] vLibro = new string[27];

        public int i = 0;

        public frmLista()
        {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            StreamReader leerLibro = new StreamReader("./LIBRO.txt");

            int indice = 0;

            while (!leerLibro.EndOfStream)
            {

                vLibro[indice] = leerLibro.ReadLine();


                indice++;
            }


        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            


            if (i <= 21)
            {
                lstLibros.Items.Add(vLibro[i].ToString());

                i++;
                if (i == 21)
                {
                    btnAdelante.Enabled = false;
                }
            }
            else
            {
                btnAdelante.Enabled=true;
            }


        }

        private void btnAtras_Click(object sender, EventArgs e)
        {

            i--;
            if (i >= 0)
            {
                lstLibros.Items.Add(vLibro[i]);

                if (i == 0)
                {
                    btnAtras.Enabled = false;
                }
            }

        }
    }
}
