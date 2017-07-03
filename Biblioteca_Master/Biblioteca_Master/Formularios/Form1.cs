using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca_Master
{
    public partial class Form1 : Form
    {
        private int ticks;
        public Form1()
        {
            InitializeComponent();
            timer_stretch.Start();
        }

        int dir =1;

        private void timer_stretch_Tick(object sender, EventArgs e)
        {
            ticks++;

            if (ticks < 250)
            {
                if (PCBarr.Value == 100)
                {
                    dir = -1;//reduzir
                    PCBarr.animationIterval = 4;
                }
                else if (PCBarr.Value == 30)
                {
                    dir = +1;//expandir
                    PCBarr.animationIterval = 1;
                }
                PCBarr.Value += dir;
            }
            else
            {

                btn_login.Visible = true;
                texto.Text = "Obrigado por esperar!";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Formularios.Login entrar = new Formularios.Login();
            entrar.ShowDialog();
            this.Visible = false;
            
        }
    }
}
