using MySql.Data.MySqlClient;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Criar um objeto de classe "meuBancoDeDados".
            meuBancoDeDados meuBancoDeDados = new meuBancoDeDados();

            MySqlDataAdapter meuAdaptadorSql = new MySqlDataAdapter();
            DataTable tabelaDeDados = new DataTable();
            MySqlCommand comandoSql = new MySqlCommand("SELECT * FROM `usuarios` WHERE `nome_de_usuario`= @usuario AND `senha`= @senha", meuBancoDeDados.getConexao);

            //Incluindo o "@usuario" e "@senha".
            comandoSql.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = TextBoxUsuário.Text;
            comandoSql.Parameters.Add("@senha", MySqlDbType.VarChar).Value = textBoxSenha.Text;

            meuAdaptadorSql.SelectCommand = comandoSql;

            meuAdaptadorSql.Fill(tabelaDeDados);

            if (tabelaDeDados.Rows.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                MessageBox.Show("Não");
            }
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
