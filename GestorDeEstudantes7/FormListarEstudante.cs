using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestorDeEstudantes7;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantes7
{
    public partial class FormListarEstudante : Form
    {
        public FormListarEstudante()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void FormListarEstudante_Load(object sender, EventArgs e)
        {
            //Preenche o dataGridView com as informações dos estudantes.

            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudante`");
            GridViewListaDeAlunos.ReadOnly = true;

            //Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            //Determina uma altura padrão para as linhas da tabelas
            GridViewListaDeAlunos.RowTemplate.Height = 80;
            //Determina a origem da tabela
            GridViewListaDeAlunos.DataSource = estudante.pegarEstudantes(comando);
            //Determinar qual será a coluna com as imagens
            colunaDeFotos = (DataGridViewImageColumn)GridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //Impede o usuário de incluir linhas
            GridViewListaDeAlunos.AllowUserToAddRows = false;

        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            // Atualiza a lista de estudantes.

        }

        private void FormListarEstudante_Load_1(object sender, EventArgs e)
        {
            //Preenche o dataGridView com as informações dos estudantes.

            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes`");
            GridViewListaDeAlunos.ReadOnly = true;

            //Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            //Determina uma altura padrão para as linhas da tabelas
            GridViewListaDeAlunos.RowTemplate.Height = 80;
            //Determina a origem da tabela
            GridViewListaDeAlunos.DataSource = estudante.pegarEstudantes(comando);
            //Determinar qual será a coluna com as imagens
            colunaDeFotos = (DataGridViewImageColumn)GridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //Impede o usuário de incluir linhas
            GridViewListaDeAlunos.AllowUserToAddRows = false;
        }

        private void GridViewListaDeAlunos_DoubleClick(object sender, EventArgs e)
        {
            // Exibir as informações do estudante ao clicar nele duas vezes.

        }
    }
}