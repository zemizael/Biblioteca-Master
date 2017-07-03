namespace Biblioteca_Master.Formularios
{
    partial class Situacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Situacao));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnclose = new Bunifu.Framework.UI.BunifuImageButton();
            this.griddadosaluno = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LabelTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Aluno = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.idaluno = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.griddadoslivro = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddadosaluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddadoslivro)).BeginInit();
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
            this.btnclose.Location = new System.Drawing.Point(439, 33);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(28, 27);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnclose.TabIndex = 81;
            this.btnclose.TabStop = false;
            this.btnclose.Zoom = 10;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // griddadosaluno
            // 
            this.griddadosaluno.AllowUserToAddRows = false;
            this.griddadosaluno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.griddadosaluno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.griddadosaluno.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.griddadosaluno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.griddadosaluno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.griddadosaluno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.griddadosaluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddadosaluno.DoubleBuffered = true;
            this.griddadosaluno.EnableHeadersVisualStyles = false;
            this.griddadosaluno.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.griddadosaluno.HeaderForeColor = System.Drawing.Color.White;
            this.griddadosaluno.Location = new System.Drawing.Point(26, 172);
            this.griddadosaluno.Name = "griddadosaluno";
            this.griddadosaluno.ReadOnly = true;
            this.griddadosaluno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.griddadosaluno.Size = new System.Drawing.Size(441, 57);
            this.griddadosaluno.TabIndex = 80;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelTitulo.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.Color.White;
            this.LabelTitulo.Location = new System.Drawing.Point(80, 33);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(233, 27);
            this.LabelTitulo.TabIndex = 78;
            this.LabelTitulo.Text = "Situação do Aluno";
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
            this.Aluno.Location = new System.Drawing.Point(266, 122);
            this.Aluno.Name = "Aluno";
            this.Aluno.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Aluno.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Aluno.OnHoverTextColor = System.Drawing.Color.White;
            this.Aluno.selected = false;
            this.Aluno.Size = new System.Drawing.Size(31, 31);
            this.Aluno.TabIndex = 77;
            this.Aluno.Text = "bunifuFlatButton1";
            this.Aluno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aluno.Textcolor = System.Drawing.Color.White;
            this.Aluno.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aluno.Click += new System.EventHandler(this.Aluno_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 101);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(63, 16);
            this.bunifuCustomLabel1.TabIndex = 76;
            this.bunifuCustomLabel1.Text = "ID Aluno";
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
            this.idaluno.Location = new System.Drawing.Point(26, 122);
            this.idaluno.Margin = new System.Windows.Forms.Padding(4);
            this.idaluno.Name = "idaluno";
            this.idaluno.Size = new System.Drawing.Size(223, 30);
            this.idaluno.TabIndex = 75;
            this.idaluno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // griddadoslivro
            // 
            this.griddadoslivro.AllowUserToAddRows = false;
            this.griddadoslivro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.griddadoslivro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.griddadoslivro.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.griddadoslivro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.griddadoslivro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.griddadoslivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.griddadoslivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddadoslivro.DoubleBuffered = true;
            this.griddadoslivro.EnableHeadersVisualStyles = false;
            this.griddadoslivro.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.griddadoslivro.HeaderForeColor = System.Drawing.Color.White;
            this.griddadoslivro.Location = new System.Drawing.Point(26, 251);
            this.griddadoslivro.Name = "griddadoslivro";
            this.griddadoslivro.ReadOnly = true;
            this.griddadoslivro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.griddadoslivro.Size = new System.Drawing.Size(441, 193);
            this.griddadoslivro.TabIndex = 82;
            // 
            // Situacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(495, 468);
            this.Controls.Add(this.griddadoslivro);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.griddadosaluno);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.Aluno);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.idaluno);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Situacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Situacao";
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddadosaluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddadoslivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnclose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid griddadosaluno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel LabelTitulo;
        private Bunifu.Framework.UI.BunifuFlatButton Aluno;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox idaluno;
        private Bunifu.Framework.UI.BunifuCustomDataGrid griddadoslivro;
    }
}