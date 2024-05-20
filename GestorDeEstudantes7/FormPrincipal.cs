using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes7
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void listaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void novoEstudanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInserirEstudantes formInserirEstudantes = new FormInserirEstudantes();
            formInserirEstudantes.Show(this);
        }
    }
}
