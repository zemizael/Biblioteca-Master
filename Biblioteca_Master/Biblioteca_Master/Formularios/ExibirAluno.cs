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
    public partial class ExibirAluno : Form
    {
        public ExibirAluno()
        {
            InitializeComponent();
            AbrirConexao();
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

        private void ExibirAluno_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = AbrirConexao();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                string query = "SELECT * FROM aluno";
                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                GridAluno.DataSource = dt;


                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

       
    }
}
