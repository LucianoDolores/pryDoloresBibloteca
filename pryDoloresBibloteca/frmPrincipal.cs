using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDoloresBibloteca
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBibloteca bibloteca = new frmBibloteca();
            bibloteca.ShowDialog();
        }

        private void libros2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista Lista = new frmLista();
            Lista.ShowDialog();
        }
    }
}
