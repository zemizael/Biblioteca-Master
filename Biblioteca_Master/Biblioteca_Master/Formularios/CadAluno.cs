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
    public partial class CadAluno : Form
    {
        public CadAluno()
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
          //botao que desabilita o aluno do sistema
            desabilitaraluno desaluno = new desabilitaraluno();
            desaluno.ShowDialog();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            nomeal.Focus();

            nomeal.Text = "";
            telal.Text = "";
            emailal.Text = "";
            genal.Text = "";
            cidal.Text = "";
            endal.Text = "";
            funcal.Text = "";
            ccurso.Text = "";
            cper.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = AbrirConexao();
                //criando comando de insert dentro do banco para a tabela de alunos
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into aluno (nome, curso, periodo,telefone,endereco, email, genero, cidade, funcao) values ('" + nomeal.Text + "','" + ccurso.Text + "','" + cper.Text + "','" + telal.Text + "','" + endal.Text + "','" + emailal.Text + "','" + genal.Text + "','" + cidal.Text + "','" + funcal.Text + "')";
                cmd.ExecuteNonQuery();
                //                                                                                                                    
                MessageBox.Show("Aluno Cadastrado!", "Cadastro de Alunos", MessageBoxButtons.OK);
                //fecha conexão
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);

            }
        }
    }
}
