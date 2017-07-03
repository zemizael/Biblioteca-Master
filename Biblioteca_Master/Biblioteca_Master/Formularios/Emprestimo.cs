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
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
            AbrirConexao();
        }

        public static MySqlConnection AbrirConexao()
        {
            return new MySqlConnection("Server=127.0.0.1;database=bmaster;Uid=root;pwd=;Port=3306");
            //  string de conexao para o banco de dados
        }

        private void Emprestimo_Load(object sender, EventArgs e)
        {   
            // Livros
            
            MySqlConnection cn = AbrirConexao();
            cn.Open();
        
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            string query = "SELECT * FROM livro ";
            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Refresh();
            CGRIDLIVRO.DataSource = dt;

            cn.Close();

            //aluno
            MySqlConnection cn2 = AbrirConexao();
            cn2.Open();
            MySqlCommand cmd2= new MySqlCommand();
            cmd2.Connection = cn2;
            string query2= "SELECT * FROM aluno ";
            cmd2.CommandText= query2;

            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2= new DataTable();
            da2.Fill(dt2);

            Refresh();
            CGRIDALUNO.DataSource = dt2;
            cn.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void livro_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = AbrirConexao();
                cn.Open();
                // Livros
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                string query = "SELECT * FROM livro where Id_livro=  " + idlivro.Text + "";
                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Refresh();
                CGRIDLIVRO.DataSource = dt;

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void Aluno_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = AbrirConexao();
                //Alunos
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                string query = "SELECT * FROM aluno where Id_Aluno=" + idaluno.Text + "";
                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                Refresh();
                CGRIDALUNO.DataSource = dt;
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void btnRegEm_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = AbrirConexao();
                //criando comando de insert dentro do banco para a tabela de livros
                cn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into situacao (Id_Aluno, Id_livro, quantidade,data)values ('" + idaluno.Text + "','" + idlivro.Text + "','" + quantidade.Text +"','"+data.Text+ "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Emprestimo Efetuado!", "Emprestimo", MessageBoxButtons.OK);
                CGRIDALUNO.Refresh();
                CGRIDLIVRO.Refresh();
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
