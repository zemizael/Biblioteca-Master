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
    public partial class desabilitarfunc : Form
    {
        public desabilitarfunc()
        {
            InitializeComponent();
           
        }
        public static MySqlConnection AbrirConexao()
        {
            return new MySqlConnection("Server=127.0.0.1;database=bmaster;Uid=root;pwd=;Port=3306");
            //  string de conexao para o banco de dados
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection cn = AbrirConexao();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                string query = "delete from usuarios where Id=" + IDFunc.Text + "";
                // MessageBox.Show(query);
                cmd.CommandText = query;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario Desabilitado ", "Desabilitar Funcionario", MessageBoxButtons.OK);
                cn.Close();

                this.Close();
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
