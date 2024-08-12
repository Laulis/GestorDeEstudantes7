using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

         private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotal.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            labelTotal.ForeColor = corPainelTotal;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Ao tirar o mouse do texto, altera a cor do PAINEL para a cor original
            // do PAINEL e a cor do texto para a cor preta.
            panelTotal.BackColor = corPainelTotal;
            labelTotal.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Ao tirar o mouse do texto, altera a cor do PAINEL para a cor original
            // do PAINEL e a cor do texto para a cor preta.
            panelTotal.BackColor = corPainelTotal;
            labelTotal.ForeColor = Color.Black;
        }
    }
}
