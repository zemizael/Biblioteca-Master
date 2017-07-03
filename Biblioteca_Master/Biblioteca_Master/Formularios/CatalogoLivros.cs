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
    public partial class CatalogoLivros : Form
    {
        public CatalogoLivros()
        {
            InitializeComponent();
            AbrirConexao();
        }

        public void Direcoes()
        {
            CatalogoPanel.Left = 500;
            CatalogoPanel.Left = 500;
            CatalogoPanel.Left = 500;
        }

        public static MySqlConnection AbrirConexao()
        {
            return new MySqlConnection("Server=127.0.0.1;database=bmaster;Uid=root;pwd=;Port=3306");
            //  string de conexao para o banco de dados
        }

        private void btninserelivros_Click(object sender, EventArgs e)
        {

            //faz com que o painel que está a direita venha a aparecer na tela como se fosse uma animação
            if (InserirPanel.Left == 500)
            {
                CatalogoPanel.Visible = false;
                CatalogoPanel.Left = 500;

                ExcluirPanel.Visible = false;
                CatalogoPanel.Left = 500;

                CatalogoPanel.Left = 500;
                InserirPanel.Visible = true;
            }
        }

        private void btncatalagoLivro_Click(object sender, EventArgs e)
        {
            //codigo para deixar os campos de digitação desabilitados ate o clique do botao novo
            titlivro.Enabled = false;
            autorlivro.Enabled = false;
            editoralivro.Enabled = false;
            anolivro.Enabled = false;
            generolivro.Enabled = false;

            //faz com que o painel que está a direita venha a aparecer na tela como se fosse uma animação
            if (CatalogoPanel.Left == 500)
            {
                InserirPanel.Visible = false;
                InserirPanel.Left = 500;

                ExcluirPanel.Visible = false;
                ExcluirPanel.Left = 500;

                CatalogoPanel.Left = 180;

                CatalogoPanel.Visible = true;

            }

            CadSave.Enabled = false;
        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            //codigo para deixar os campos de digitação desabilitados ate o clique do botao novo
         
            titlivro.Enabled = false;
            autorlivro.Enabled = false;
            editoralivro.Enabled = false;
            anolivro.Enabled = false;
            generolivro.Enabled = false;

            //faz com que o painel que está a direita venha a aparecer na tela como se fosse uma animação
            if (ExcluirPanel.Left == 500)
            {
                CatalogoPanel.Visible = false;
                CatalogoPanel.Left = 500;

                ExcluirPanel.Visible = true;
                ExcluirPanel.Left = 180;

                InserirPanel.Left = 500;
                InserirPanel.Visible = false;

          

                CadSave.Enabled = false;
            }
        }

        private void CadNovo_Click(object sender, EventArgs e)
        {
            

            CadSave.Enabled = true;
            //colocar o enable true nos campos para serem digitados
           
            titlivro.Enabled = true;
            autorlivro.Enabled = true;
            editoralivro.Enabled = true;
            anolivro.Enabled = true;
            generolivro.Enabled = true;


            //limpar campos e dar um set focus no id
            
            titlivro.Text = "";
            autorlivro.Text = "";
            editoralivro.Text = "";
            anolivro.Text = "";
            generolivro.Text = "";
            titlivro.Focus();
        }

        private void CadSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection();
                //criando comando de insert dentro do banco para a tabela de livros
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into livro (titulo, autor, editora, ano, genero)values ('" + titlivro.Text + "','" + autorlivro.Text + "','" + editoralivro.Text + "','" + anolivro.Text + "','" + generolivro.Text + "')";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro Cadastrado!", "Cadastro de Livros", MessageBoxButtons.OK);
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

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            //botao de pesquisa de livros por nome
            try
            {
                MySqlConnection cn = new MySqlConnection();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn; //where Funcao = aluno
                string query = "SELECT * FROM Livros where titulo=" + txtNomeLivro.Text + "";
                cmd.CommandText = query;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridCatLivro.DataSource = dt;


                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }

        private void ExcluirLivroP3_Click(object sender, EventArgs e)
        {
            try
            {
                //excluir um livro cadastrado no banco de dados
                MySqlConnection cn = new MySqlConnection();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                string query = "delete from livro where Id_livro=" + txtCod.Text + "";
         
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro deletado ", "Excluir", MessageBoxButtons.OK);
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
