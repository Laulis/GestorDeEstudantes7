﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace GestorDeEstudantes7
{
    internal class meuBancoDeDados
    {
        // A conexão com o Banco de Dados.
       private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sga_estudantes_bd_t7");
    
        // Acessor da variável conexão
        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        }

        // Função para ABRIR a conxão com o Banco de Dados
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        //Função para FECHAR a conexão com o Banco de Dados
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }   
        
    }
}
