﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantes7
{
    public partial class FormInserirEstudantes : Form
    {
        public FormInserirEstudantes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnviarFoto_Click(object sender, EventArgs e)
        {
            // Pesquisa a imagem no computador
            OpenFileDialog procurarFoto = new OpenFileDialog();

            procurarFoto.Filter = "Selecione a foto (*.jpg;*.png;*.jpeg;*.gif)|(*.jpg; *.png; *.jpeg; *.gif";

            if(procurarFoto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(procurarFoto.FileName);
            }
        }

        bool Verificar()
        {
            if((textBoxNome.Text.Trim() == "") ||
               (textBoxSobrenome.Text.Trim() == "") ||
               (textBoxTelefone.Text.Trim() == "") ||
               (textBoxEndereco.Text.Trim() == "") ||
               (pictureBoxFoto.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();

            string nome = textBoxNome.Text;
            string sobrenome = textBoxSobrenome.Text;
            DateTime nascimento = dateTimeDataDeNascimento.Value;
            string  telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;
            string genero = "Feminino";

            if (radioButtonMasc.Checked == true)
            {
                genero = "Masculino";
            }
            
            MemoryStream foto = new MemoryStream();

            //Verificar se o aluno tem entre 10 e 100 anos.
            int anoDeNascimento = dateTimeDataDeNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;

            if ((anoAtual - anoDeNascimento) < 10 ||  (anoAtual - anoDeNascimento ) > 100)
            {
                MessageBox.Show("O aluno precisa ter entre 10 e 100 anos.", "Ano de Nascimento inválido.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(Verificar())
            {
                pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                if(estudante.inserirEstudante(nome, sobrenome, nascimento, telefone, genero,endereco, foto))
                {
                    MessageBox.Show("Novo aluno cadastrado!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Aluno não cadastrado!", "Erro!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Existem camposnão preenchidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormInserirEstudantes_Load(object sender, EventArgs e)
        {

        }
    }
}
