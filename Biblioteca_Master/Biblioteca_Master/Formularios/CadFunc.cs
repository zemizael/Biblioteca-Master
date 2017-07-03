using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Biblioteca_Master.Formularios
{
    public partial class CadFunc : Form
    {
        public CadFunc()
        {
            InitializeComponent();
            AbrirConexao();
            MySqlConnection cn = new MySqlConnection();
            
        }
        public static MySqlConnection AbrirConexao()
        {
            return new MySqlConnection("Server=127.0.0.1;database=bmaster;Uid=root;pwd=;Port=3306");
            //  string de conexao para o banco de dados
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            nomefunc.Focus();

            nomefunc.Text = "";
            telfunc.Text = "";
            emailfunc.Text = "";
            funcgen.Text = "";
            funccidade.Text = "";
            funcend.Text = "";
      
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = AbrirConexao();
                //criando comando de insert dentro do banco para a tabela de livros
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into usuarios (nome, endereco, telefone, email, genero, cidade, funcao)values ('" + nomefunc.Text + "','" + funcend.Text + "','" + telfunc.Text + "','" + emailfunc.Text + "','" + funcgen.Text + "','" + funccidade.Text + "','" + funfunc.Text + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario Cadastrado!", "Cadastro de Funcionarios", MessageBoxButtons.OK);
                //fecha conexão
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);

            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
