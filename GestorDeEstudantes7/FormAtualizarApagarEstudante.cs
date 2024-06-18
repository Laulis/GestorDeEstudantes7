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
    public partial class FormAtualizarApagarEstudante : Form
    {
        public FormAtualizarApagarEstudante()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|(*.jpg; *.png; *.jpeg; *.gif";

            if (procurarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(procurarFoto.FileName);
            }
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            //Referência a Id do aluno.
            int idDoAluno = Convert.ToInt32(textBoxId.Text);

            //Mostra uma caixa de diálogo perguntando se o usuário tem certeza de que quer apagar o aluno.
            if(MessageBox.Show("Tem certeza que deseja apagar o studante?", "Apagar estudante", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                 if(Estudante.apagarEstudante(idDoAluno))
                {
                    MessageBox.Show("Aluno apagado!", "Apagar aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
