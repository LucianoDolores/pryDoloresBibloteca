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
    public partial class frmBibloteca : Form
    {
        public string[] vLibros = new string[27];
        public int[] vCodigo = new int[27];
        public int i = 0;
        char c = Convert.ToChar(",");
        public frmBibloteca()
        {
            InitializeComponent();
        }

        private void frmBibloteca_Load(object sender, EventArgs e)
        {
            StreamReader leerLibro = new StreamReader("./LIBRO.txt");
            StreamReader leerCodigo = new StreamReader("./LIBRO.txt");
            int indice = 0;

            while (!leerLibro.EndOfStream)
            {
                vLibros[indice] = leerLibro.ReadLine();
                indice++;
            }
            while (!leerCodigo.EndOfStream)
            {
                vCodigo[indice] = Convert.ToInt32(leerCodigo.ReadLine().Split(c));
                indice++;
            }
            leerCodigo.Close();
            leerLibro.Close();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            if (i <= 27)
            {
                txtNombreLibro.Text = vLibros[i].ToString();
                txtCodigo.Text = vCodigo[i].ToString();

                i++;
            }
        }
    }
}
