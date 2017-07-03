namespace Biblioteca_Master
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PCBarr = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer_stretch = new System.Windows.Forms.Timer(this.components);
            this.texto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PCBarr
            // 
            this.PCBarr.animated = true;
            this.PCBarr.animationIterval = 1;
            this.PCBarr.animationSpeed = 1;
            this.PCBarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.PCBarr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PCBarr.BackgroundImage")));
            this.PCBarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.PCBarr.ForeColor = System.Drawing.Color.SeaGreen;
            this.PCBarr.LabelVisible = false;
            this.PCBarr.LineProgressThickness = 8;
            this.PCBarr.LineThickness = 5;
            this.PCBarr.Location = new System.Drawing.Point(116, 71);
            this.PCBarr.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PCBarr.MaxValue = 100;
            this.PCBarr.Name = "PCBarr";
            this.PCBarr.ProgressBackColor = System.Drawing.Color.White;
            this.PCBarr.ProgressColor = System.Drawing.Color.SeaGreen;
            this.PCBarr.Size = new System.Drawing.Size(108, 108);
            this.PCBarr.TabIndex = 0;
            this.PCBarr.Value = 30;
            // 
            // timer_stretch
            // 
            this.timer_stretch.Enabled = true;
            this.timer_stretch.Interval = 1;
            this.timer_stretch.Tick += new System.EventHandler(this.timer_stretch_Tick);
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texto.ForeColor = System.Drawing.Color.White;
            this.texto.Location = new System.Drawing.Point(27, 30);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(102, 16);
            this.texto.TabIndex = 1;
            this.texto.Text = "Carregando...";
            // 
            // btn_login
            // 
            this.btn_login.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.BorderRadius = 0;
            this.btn_login.ButtonText = "Login";
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DisabledColor = System.Drawing.Color.Gray;
            this.btn_login.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_login.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_login.Iconimage")));
            this.btn_login.Iconimage_right = null;
            this.btn_login.Iconimage_right_Selected = null;
            this.btn_login.Iconimage_Selected = null;
            this.btn_login.IconMarginLeft = 0;
            this.btn_login.IconMarginRight = 0;
            this.btn_login.IconRightVisible = true;
            this.btn_login.IconRightZoom = 0D;
            this.btn_login.IconVisible = false;
            this.btn_login.IconZoom = 90D;
            this.btn_login.IsTab = false;
            this.btn_login.Location = new System.Drawing.Point(96, 202);
            this.btn_login.Name = "btn_login";
            this.btn_login.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.selected = false;
            this.btn_login.Size = new System.Drawing.Size(146, 39);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.Textcolor = System.Drawing.Color.White;
            this.btn_login.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Visible = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(332, 261);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.PCBarr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar PCBarr;
        private System.Windows.Forms.Timer timer_stretch;
        private Bunifu.Framework.UI.BunifuCustomLabel texto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_login;

    }
}

