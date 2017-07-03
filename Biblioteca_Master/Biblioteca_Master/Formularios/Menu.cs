using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca_Master.Formularios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Inicio();
        }
        private void Inicio()
        {
            //posiciona o painel de menu para que não apareça o nome das opções apenas os icones
            panel1.Width = 54;

            //inializar os paineis de serviços invisiveis
            admin.Visible = false;
            funcionarios.Visible = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadFun_Click(object sender, EventArgs e)
        {
            //chama formulario 
            CadFunc funcionario = new CadFunc();
            funcionario.ShowDialog();
        }

        private void btnExFunc_Click(object sender, EventArgs e)
        {
            //chama formulario 
            ExibirFunc exfunc = new ExibirFunc();
            exfunc.ShowDialog();
        }

        private void btnDemit_Click(object sender, EventArgs e)
        {
            //chama formulario 
            desabilitarfunc delete = new desabilitarfunc();
            delete.ShowDialog();
        }

        private void btnExibirAlunos_Click(object sender, EventArgs e)
        {
            //chama formulario 
            ExibirAluno exaluno = new ExibirAluno();
            exaluno.ShowDialog();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            //chama formulario 
            CadAluno aluno = new CadAluno();
            aluno.ShowDialog();
        }

        private void btnRegEm_Click(object sender, EventArgs e)
        {
            //chama formulario 
            Emprestimo emprest = new Emprestimo();
            emprest.ShowDialog();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            //chama formulario 
            CatalogoLivros livros = new CatalogoLivros();
            livros.ShowDialog();
        }

        private void btnExAluno_Click(object sender, EventArgs e)
        {
            //chama formulario 
            ExibirAluno exaluno = new ExibirAluno();
            exaluno.ShowDialog();
        }

        private void btnRegD_Click(object sender, EventArgs e)
        {
            //chama formulario 
            Devolução devolver = new Devolução();
            devolver.ShowDialog();

        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {
            //chama formulario 
            Situacao situacao = new Situacao();
            situacao.ShowDialog();
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {//Renovar Livro
            Renovar renovar = new Renovar();
            renovar.ShowDialog();

        }

        private void Menubtn_Click(object sender, EventArgs e)
        {
            //faz com que a barra de menu se desloque simulando uma animação
            panel1.Width = 150;
            panel1.Height = 140;    
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            //deixa invisivel as opções do funcionario e torna visivel as do admin
            admin.Visible = true;
            funcionarios.Visible = false;
        }

        private void btnfunc_Click(object sender, EventArgs e)
        {
            //deixa invisivel as opções do admin e torna visivel as do funcioncario
            admin.Visible = false;
            funcionarios.Visible = true;
        }

        private void Menubtn_DoubleClick(object sender, EventArgs e)
        {
            //chama a funcao de Inicio criada
            Inicio();
        }
    }
}
