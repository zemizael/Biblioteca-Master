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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //foca para iniciar na textbox do usuario
            usuario.Focus();
            AbrirConexao();
        }

        public static MySqlConnection AbrirConexao()
        {
            return new MySqlConnection("Server=127.0.0.1;database=bmaster;Uid=root;pwd=;Port=3306");
            //  string de conexao para o banco de dados
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = AbrirConexao();
            cn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select *from usuarios where login= '" + usuario.Text + "' and senha= '" + senha.Text + "'";

            MySqlDataReader reader = cmd.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }
            if (count == 1)
            {
                Formularios.Menu menu = new Formularios.Menu();
                menu.ShowDialog();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos!");
            }

            cn.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
