namespace Biblioteca_Master.Formularios
{
    partial class Devolução
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Devolução));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CGRIDLIVRO = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Aluno = new Bunifu.Framework.UI.BunifuFlatButton();
            this.livro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegEm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.idaluno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.idlivro = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CGRIDALUNO = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.operacao = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGRIDLIVRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGRIDALUNO)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.ImageActive = null;
            this.btnclose.Location = new System.Drawing.Point(603, 9);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 27);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 5;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(33, 208);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(65, 16);
            this.bunifuCustomLabel6.TabIndex = 97;
            this.bunifuCustomLabel6.Text = "Situação";
            // 
            // CGRIDLIVRO
            // 
            this.CGRIDLIVRO.AllowUserToAddRows = false;
            this.CGRIDLIVRO.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CGRIDLIVRO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.CGRIDLIVRO.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.CGRIDLIVRO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CGRIDLIVRO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CGRIDLIVRO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CGRIDLIVRO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CGRIDLIVRO.DoubleBuffered = true;
            this.CGRIDLIVRO.EnableHeadersVisualStyles = false;
            this.CGRIDLIVRO.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.CGRIDLIVRO.HeaderForeColor = System.Drawing.Color.White;
            this.CGRIDLIVRO.Location = new System.Drawing.Point(33, 227);
            this.CGRIDLIVRO.Name = "CGRIDLIVRO";
            this.CGRIDLIVRO.ReadOnly = true;
            this.CGRIDLIVRO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CGRIDLIVRO.Size = new System.Drawing.Size(598, 111);
            this.CGRIDLIVRO.TabIndex = 95;
            // 
            // Aluno
            // 
            this.Aluno.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Aluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Aluno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Aluno.BorderRadius = 0;
            this.Aluno.ButtonText = "bunifuFlatButton1";
            this.Aluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aluno.DisabledColor = System.Drawing.Color.Gray;
            this.Aluno.Iconcolor = System.Drawing.Color.Transparent;
            this.Aluno.Iconimage = ((System.Drawing.Image)(resources.GetObject("Aluno.Iconimage")));
            this.Aluno.Iconimage_right = null;
            this.Aluno.Iconimage_right_Selected = null;
            this.Aluno.Iconimage_Selected = null;
            this.Aluno.IconMarginLeft = 0;
            this.Aluno.IconMarginRight = 0;
            this.Aluno.IconRightVisible = true;
            this.Aluno.IconRightZoom = 0D;
            this.Aluno.IconVisible = true;
            this.Aluno.IconZoom = 90D;
            this.Aluno.IsTab = false;
            this.Aluno.Location = new System.Drawing.Point(267, 86);
            this.Aluno.Name = "Aluno";
            this.Aluno.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Aluno.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Aluno.OnHoverTextColor = System.Drawing.Color.White;
            this.Aluno.selected = false;
            this.Aluno.Size = new System.Drawing.Size(31, 31);
            this.Aluno.TabIndex = 94;
            this.Aluno.Text = "bunifuFlatButton1";
            this.Aluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aluno.Textcolor = System.Drawing.Color.White;
            this.Aluno.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aluno.Click += new System.EventHandler(this.Aluno_Click);
            // 
            // livro
            // 
            this.livro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.livro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.livro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.livro.BorderRadius = 0;
            this.livro.ButtonText = "bunifuFlatButton1";
            this.livro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.livro.DisabledColor = System.Drawing.Color.Gray;
            this.livro.Iconcolor = System.Drawing.Color.Transparent;
            this.livro.Iconimage = ((System.Drawing.Image)(resources.GetObject("livro.Iconimage")));
            this.livro.Iconimage_right = null;
            this.livro.Iconimage_right_Selected = null;
            this.livro.Iconimage_Selected = null;
            this.livro.IconMarginLeft = 0;
            this.livro.IconMarginRight = 0;
            this.livro.IconRightVisible = true;
            this.livro.IconRightZoom = 0D;
            this.livro.IconVisible = true;
            this.livro.IconZoom = 90D;
            this.livro.IsTab = false;
            this.livro.Location = new System.Drawing.Point(117, 86);
            this.livro.Name = "livro";
            this.livro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.livro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.livro.OnHoverTextColor = System.Drawing.Color.White;
            this.livro.selected = false;
            this.livro.Size = new System.Drawing.Size(31, 31);
            this.livro.TabIndex = 93;
            this.livro.Text = "bunifuFlatButton1";
            this.livro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.livro.Textcolor = System.Drawing.Color.White;
            this.livro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livro.Click += new System.EventHandler(this.livro_Click);
            // 
            // btnRegEm
            // 
            this.btnRegEm.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRegEm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnRegEm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegEm.BorderRadius = 0;
            this.btnRegEm.ButtonText = "Devolver";
            this.btnRegEm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegEm.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegEm.ForeColor = System.Drawing.Color.White;
            this.btnRegEm.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegEm.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegEm.Iconimage")));
            this.btnRegEm.Iconimage_right = null;
            this.btnRegEm.Iconimage_right_Selected = null;
            this.btnRegEm.Iconimage_Selected = null;
            this.btnRegEm.IconMarginLeft = 0;
            this.btnRegEm.IconMarginRight = 0;
            this.btnRegEm.IconRightVisible = false;
            this.btnRegEm.IconRightZoom = 0D;
            this.btnRegEm.IconVisible = false;
            this.btnRegEm.IconZoom = 60D;
            this.btnRegEm.IsTab = false;
            this.btnRegEm.Location = new System.Drawing.Point(516, 86);
            this.btnRegEm.Name = "btnRegEm";
            this.btnRegEm.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnRegEm.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnRegEm.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegEm.selected = false;
            this.btnRegEm.Size = new System.Drawing.Size(115, 32);
            this.btnRegEm.TabIndex = 92;
            this.btnRegEm.Text = "Devolver";
            this.btnRegEm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegEm.Textcolor = System.Drawing.Color.White;
            this.btnRegEm.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEm.Click += new System.EventHandler(this.btnRegEm_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(154, 65);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 16);
            this.bunifuCustomLabel1.TabIndex = 91;
            this.bunifuCustomLabel1.Text = "Id Aluno";
            // 
            // idaluno
            // 
            this.idaluno.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.idaluno.BorderColorIdle = System.Drawing.Color.White;
            this.idaluno.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.idaluno.BorderThickness = 3;
            this.idaluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idaluno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idaluno.ForeColor = System.Drawing.Color.White;
            this.idaluno.isPassword = false;
            this.idaluno.Location = new System.Drawing.Point(157, 86);
            this.idaluno.Margin = new System.Windows.Forms.Padding(4);
            this.idaluno.Name = "idaluno";
            this.idaluno.Size = new System.Drawing.Size(103, 30);
            this.idaluno.TabIndex = 90;
            this.idaluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(33, 65);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 16);
            this.bunifuCustomLabel2.TabIndex = 89;
            this.bunifuCustomLabel2.Text = "Id Livro";
            // 
            // idlivro
            // 
            this.idlivro.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.idlivro.BorderColorIdle = System.Drawing.Color.White;
            this.idlivro.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.idlivro.BorderThickness = 3;
            this.idlivro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idlivro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idlivro.ForeColor = System.Drawing.Color.White;
            this.idlivro.isPassword = false;
            this.idlivro.Location = new System.Drawing.Point(33, 85);
            this.idlivro.Margin = new System.Windows.Forms.Padding(4);
            this.idlivro.Name = "idlivro";
            this.idlivro.Size = new System.Drawing.Size(77, 30);
            this.idlivro.TabIndex = 88;
            this.idlivro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTitulo.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.Color.White;
            this.LabelTitulo.Location = new System.Drawing.Point(95, 9);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(143, 27);
            this.LabelTitulo.TabIndex = 86;
            this.LabelTitulo.Text = "Devolução";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(34, 122);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(52, 16);
            this.bunifuCustomLabel4.TabIndex = 100;
            this.bunifuCustomLabel4.Text = "Alunos";
            // 
            // CGRIDALUNO
            // 
            this.CGRIDALUNO.AllowUserToAddRows = false;
            this.CGRIDALUNO.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CGRIDALUNO.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CGRIDALUNO.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.CGRIDALUNO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CGRIDALUNO.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CGRIDALUNO.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CGRIDALUNO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CGRIDALUNO.DoubleBuffered = true;
            this.CGRIDALUNO.EnableHeadersVisualStyles = false;
            this.CGRIDALUNO.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.CGRIDALUNO.HeaderForeColor = System.Drawing.Color.White;
            this.CGRIDALUNO.Location = new System.Drawing.Point(34, 149);
            this.CGRIDALUNO.Name = "CGRIDALUNO";
            this.CGRIDALUNO.ReadOnly = true;
            this.CGRIDALUNO.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CGRIDALUNO.Size = new System.Drawing.Size(597, 56);
            this.CGRIDALUNO.TabIndex = 99;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(302, 66);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(75, 16);
            this.bunifuCustomLabel3.TabIndex = 102;
            this.bunifuCustomLabel3.Text = "Operação";
            // 
            // operacao
            // 
            this.operacao.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.operacao.BorderColorIdle = System.Drawing.Color.White;
            this.operacao.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.operacao.BorderThickness = 3;
            this.operacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.operacao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.operacao.ForeColor = System.Drawing.Color.White;
            this.operacao.isPassword = false;
            this.operacao.Location = new System.Drawing.Point(305, 87);
            this.operacao.Margin = new System.Windows.Forms.Padding(4);
            this.operacao.Name = "operacao";
            this.operacao.Size = new System.Drawing.Size(103, 30);
            this.operacao.TabIndex = 101;
            this.operacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Devolução
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(653, 359);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.operacao);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.CGRIDALUNO);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.CGRIDLIVRO);
            this.Controls.Add(this.Aluno);
            this.Controls.Add(this.livro);
            this.Controls.Add(this.btnRegEm);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.idaluno);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.idlivro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Devolução";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolução";
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGRIDLIVRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGRIDALUNO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid CGRIDLIVRO;
        private Bunifu.Framework.UI.BunifuFlatButton Aluno;
        private Bunifu.Framework.UI.BunifuFlatButton livro;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegEm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox idaluno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox idlivro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelTitulo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid CGRIDALUNO;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox operacao;
    }
}