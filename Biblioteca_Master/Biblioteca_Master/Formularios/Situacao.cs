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
    public partial class Situacao : Form
    {
        public Situacao()
        {
            InitializeComponent();
            AbrirConexao();
        }

        public static MySqlConnection AbrirConexao()
        {
            return new MySqlConnection("Server=127.0.0.1;database=bmaster;Uid=root;pwd=;Port=3306");
            //  string de conexao para o banco de dados
        }

        private void Aluno_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = AbrirConexao();
            cn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;

            string query = "SELECT Id_Aluno, nome,curso, periodo FROM aluno where Id_Aluno=" + idaluno.Text + "";

            cmd.CommandText = query;

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Refresh();
            griddadosaluno.DataSource = dt;
            cn.Close();
            
//-------------------------------------------------------------------------/
            //livro
            cn.Open();
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.Connection = cn;
            string query2 = "SELECT *from situacao where Id_Aluno=" + idaluno.Text + "";

            cmd2.CommandText = query2;
            MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);

            griddadoslivro.DataSource = dt2;
            griddadoslivro.Refresh();
            cn.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
