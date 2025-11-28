using Krypton.Toolkit;
using System.Windows.Forms;
namespace StudyFlow {
    partial class RedefinirSenhaForm
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            PanelEsquerda = new KryptonPanel();
            pictureBox2 = new PictureBox();
            PanelDireita = new KryptonPanel();
            pictureBoxVerSenha = new PictureBox();
            pictureBoxVerConfirmarSenha = new PictureBox();
            TextBoxConfirmarSenha = new KryptonTextBox();
            PictureBoxSenha = new KryptonPictureBox();
            TextBoxSenha = new KryptonTextBox();
            linkLabelLogin = new LinkLabel();
            ButtonSalvar = new KryptonButton();
            RedefinirSenha = new KryptonLabel();
            kryptonPictureBox1 = new KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)PanelEsquerda).BeginInit();
            PanelEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelDireita).BeginInit();
            PanelDireita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVerSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVerConfirmarSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelEsquerda
            // 
            PanelEsquerda.Controls.Add(pictureBox2);
            PanelEsquerda.Dock = DockStyle.Left;
            PanelEsquerda.Location = new Point(0, 0);
            PanelEsquerda.Name = "PanelEsquerda";
            PanelEsquerda.Size = new Size(393, 600);
            PanelEsquerda.StateCommon.Color1 = Color.FromArgb(32, 0, 177);
            PanelEsquerda.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(32, 0, 177);
            pictureBox2.Image = Properties.Resources.logoStudyLogin;
            pictureBox2.Location = new Point(65, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 351);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PanelDireita
            // 
            PanelDireita.Controls.Add(kryptonPictureBox1);
            PanelDireita.Controls.Add(pictureBoxVerSenha);
            PanelDireita.Controls.Add(pictureBoxVerConfirmarSenha);
            PanelDireita.Controls.Add(TextBoxConfirmarSenha);
            PanelDireita.Controls.Add(PictureBoxSenha);
            PanelDireita.Controls.Add(TextBoxSenha);
            PanelDireita.Controls.Add(linkLabelLogin);
            PanelDireita.Controls.Add(ButtonSalvar);
            PanelDireita.Controls.Add(RedefinirSenha);
            PanelDireita.Dock = DockStyle.Fill;
            PanelDireita.Location = new Point(393, 0);
            PanelDireita.Name = "PanelDireita";
            PanelDireita.Size = new Size(407, 600);
            PanelDireita.StateCommon.Color1 = Color.White;
            PanelDireita.TabIndex = 1;
            // 
            // pictureBoxVerSenha
            // 
            pictureBoxVerSenha.BackColor = Color.FromArgb(173, 186, 255);
            pictureBoxVerSenha.Cursor = Cursors.Hand;
            pictureBoxVerSenha.Image = Properties.Resources.closed_eye;
            pictureBoxVerSenha.Location = new Point(305, 227);
            pictureBoxVerSenha.Name = "pictureBoxVerSenha";
            pictureBoxVerSenha.Size = new Size(26, 25);
            pictureBoxVerSenha.TabIndex = 9;
            pictureBoxVerSenha.TabStop = false;
            pictureBoxVerSenha.Click += pictureBoxVerSenha_Click;
            // 
            // pictureBoxVerConfirmarSenha
            // 
            pictureBoxVerConfirmarSenha.BackColor = Color.FromArgb(173, 186, 255);
            pictureBoxVerConfirmarSenha.Cursor = Cursors.Hand;
            pictureBoxVerConfirmarSenha.Image = Properties.Resources.closed_eye;
            pictureBoxVerConfirmarSenha.Location = new Point(305, 298);
            pictureBoxVerConfirmarSenha.Name = "pictureBoxVerConfirmarSenha";
            pictureBoxVerConfirmarSenha.Size = new Size(26, 23);
            pictureBoxVerConfirmarSenha.TabIndex = 8;
            pictureBoxVerConfirmarSenha.TabStop = false;
            pictureBoxVerConfirmarSenha.Click += pictureBoxVerConfirmarSenha_Click;
            // 
            // TextBoxConfirmarSenha
            // 
            TextBoxConfirmarSenha.CueHint.Color1 = Color.White;
            TextBoxConfirmarSenha.CueHint.CueHintText = "Confirmar Senha";
            TextBoxConfirmarSenha.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxConfirmarSenha.Cursor = Cursors.IBeam;
            TextBoxConfirmarSenha.Location = new Point(85, 293);
            TextBoxConfirmarSenha.Name = "TextBoxConfirmarSenha";
            TextBoxConfirmarSenha.PasswordChar = '●';
            TextBoxConfirmarSenha.Size = new Size(250, 34);
            TextBoxConfirmarSenha.StateCommon.Back.Color1 = Color.FromArgb(173, 186, 255);
            TextBoxConfirmarSenha.StateCommon.Border.Color1 = Color.FromArgb(173, 186, 255);
            TextBoxConfirmarSenha.StateCommon.Border.Color2 = Color.FromArgb(173, 186, 255);
            TextBoxConfirmarSenha.StateCommon.Border.Rounding = 6F;
            TextBoxConfirmarSenha.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            TextBoxConfirmarSenha.StateCommon.Content.Padding = new Padding(4, 5, 4, 5);
            TextBoxConfirmarSenha.TabIndex = 2;
            TextBoxConfirmarSenha.UseSystemPasswordChar = true;
            // 
            // PictureBoxSenha
            // 
            PictureBoxSenha.Image = Properties.Resources.icone_senha;
            PictureBoxSenha.Location = new Point(40, 293);
            PictureBoxSenha.Name = "PictureBoxSenha";
            PictureBoxSenha.Size = new Size(39, 34);
            PictureBoxSenha.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxSenha.TabIndex = 7;
            PictureBoxSenha.TabStop = false;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.CueHint.Color1 = Color.White;
            TextBoxSenha.CueHint.CueHintText = "Digite a senha";
            TextBoxSenha.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSenha.Cursor = Cursors.IBeam;
            TextBoxSenha.Location = new Point(81, 221);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.PasswordChar = '●';
            TextBoxSenha.Size = new Size(250, 34);
            TextBoxSenha.StateCommon.Back.Color1 = Color.FromArgb(173, 186, 255);
            TextBoxSenha.StateCommon.Border.Color1 = Color.FromArgb(173, 186, 255);
            TextBoxSenha.StateCommon.Border.Color2 = Color.FromArgb(173, 186, 255);
            TextBoxSenha.StateCommon.Border.Rounding = 6F;
            TextBoxSenha.StateCommon.Content.Font = new Font("Segoe UI", 9.75F);
            TextBoxSenha.StateCommon.Content.Padding = new Padding(4, 5, 4, 5);
            TextBoxSenha.TabIndex = 2;
            TextBoxSenha.UseSystemPasswordChar = true;
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.ActiveLinkColor = Color.Blue;
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.BackColor = Color.White;
            linkLabelLogin.Cursor = Cursors.Hand;
            linkLabelLogin.Font = new Font("Segoe UI", 11F);
            linkLabelLogin.Location = new Point(120, 449);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(174, 20);
            linkLabelLogin.TabIndex = 5;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "Já tem uma conta? Login";
            linkLabelLogin.VisitedLinkColor = Color.Blue;
            linkLabelLogin.LinkClicked += linkLabelLogin_LinkClicked;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.Cursor = Cursors.Hand;
            ButtonSalvar.Location = new Point(140, 389);
            ButtonSalvar.Name = "ButtonSalvar";
            ButtonSalvar.OverrideDefault.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.OverrideDefault.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.Size = new Size(132, 35);
            ButtonSalvar.StateCommon.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.StateCommon.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.StateCommon.Border.Color1 = Color.DarkOrange;
            ButtonSalvar.StateCommon.Border.Rounding = 15F;
            ButtonSalvar.StateCommon.Border.Width = 1;
            ButtonSalvar.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonSalvar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSalvar.StateNormal.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.StateNormal.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.StatePressed.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.StatePressed.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.StateTracking.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.StateTracking.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonSalvar.StateTracking.Border.Color1 = Color.Red;
            ButtonSalvar.StateTracking.Border.Rounding = 15F;
            ButtonSalvar.StateTracking.Border.Width = 2;
            ButtonSalvar.StateTracking.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSalvar.TabIndex = 4;
            ButtonSalvar.Values.DropDownArrowColor = Color.Empty;
            ButtonSalvar.Values.Text = "Salvar";
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // RedefinirSenha
            // 
            RedefinirSenha.Location = new Point(85, 132);
            RedefinirSenha.Name = "RedefinirSenha";
            RedefinirSenha.Size = new Size(241, 45);
            RedefinirSenha.StateCommon.Image.ImageColorMap = Color.Transparent;
            RedefinirSenha.StateCommon.ShortText.Color1 = Color.Blue;
            RedefinirSenha.StateCommon.ShortText.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            RedefinirSenha.TabIndex = 0;
            RedefinirSenha.Values.Text = "Redefinir Senha";
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Image = Properties.Resources.icone_senha;
            kryptonPictureBox1.Location = new Point(40, 221);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(39, 34);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 10;
            kryptonPictureBox1.TabStop = false;
            // 
            // RedefinirSenhaForm
            // 
            ClientSize = new Size(800, 600);
            Controls.Add(PanelDireita);
            Controls.Add(PanelEsquerda);
            MaximizeBox = false;
            Name = "RedefinirSenhaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecuperarSenha";
            FormClosing += RecuperarSenhaForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)PanelEsquerda).EndInit();
            PanelEsquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelDireita).EndInit();
            PanelDireita.ResumeLayout(false);
            PanelDireita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVerSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVerConfirmarSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ResumeLayout(false);


        }



        #endregion

        private Krypton.Toolkit.KryptonPanel PanelEsquerda;
        private Krypton.Toolkit.KryptonPanel PanelDireita;
        private Krypton.Toolkit.KryptonLabel RedefinirSenha;
        private Krypton.Toolkit.KryptonTextBox TextBoxSenha;
        private Krypton.Toolkit.KryptonTextBox TextBoxConfirmarSenha;
        private Krypton.Toolkit.KryptonButton ButtonSalvar;
        private LinkLabel linkLabelLogin;


        private KryptonPictureBox PictureBoxSenha;
        private PictureBox pictureBoxMostrarSenha2;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxVerConfirmarSenha;
        private PictureBox pictureBoxVerSenha;
        private KryptonPictureBox kryptonPictureBox1;
    }
}