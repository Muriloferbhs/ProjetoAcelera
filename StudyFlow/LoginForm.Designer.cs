
using Krypton.Toolkit;
using System.Windows.Forms;

namespace StudyFlow
{
    partial class LoginForm 
    {
        /// <summary> FormClosing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            PanelEsquerda = new KryptonPanel();
            pictureBox2 = new PictureBox();
            PanelDireita = new KryptonPanel();
            pictureBoxMostrarSenha = new PictureBox();
            TextBoxSenha = new KryptonTextBox();
            PictureBoxSenha = new KryptonPictureBox();
            TextBoxUsuario = new KryptonTextBox();
            linkLabelSenha = new LinkLabel();
            linkLabelCadastro = new LinkLabel();
            ButtonEntrar = new KryptonButton();
            pictureBoxUsuario = new PictureBox();
            LabelLogin = new KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)PanelEsquerda).BeginInit();
            PanelEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelDireita).BeginInit();
            PanelDireita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrarSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSenha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).BeginInit();
            SuspendLayout();
            // 
            // PanelEsquerda
            // 
            PanelEsquerda.Controls.Add(pictureBox2);
            PanelEsquerda.Dock = DockStyle.Left;
            PanelEsquerda.Location = new Point(0, 0);
            PanelEsquerda.Name = "PanelEsquerda";
            PanelEsquerda.Size = new Size(391, 600);
            PanelEsquerda.StateCommon.Color1 = Color.FromArgb(32, 0, 177);
            PanelEsquerda.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(32, 0, 177);
            pictureBox2.Image = Properties.Resources.logoStudyLogin;
            pictureBox2.Location = new Point(64, 87);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 351);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // PanelDireita
            // 
            PanelDireita.Controls.Add(pictureBoxMostrarSenha);
            PanelDireita.Controls.Add(TextBoxSenha);
            PanelDireita.Controls.Add(PictureBoxSenha);
            PanelDireita.Controls.Add(TextBoxUsuario);
            PanelDireita.Controls.Add(linkLabelSenha);
            PanelDireita.Controls.Add(linkLabelCadastro);
            PanelDireita.Controls.Add(ButtonEntrar);
            PanelDireita.Controls.Add(pictureBoxUsuario);
            PanelDireita.Controls.Add(LabelLogin);
            PanelDireita.Dock = DockStyle.Fill;
            PanelDireita.Location = new Point(391, 0);
            PanelDireita.Name = "PanelDireita";
            PanelDireita.Size = new Size(409, 600);
            PanelDireita.StateCommon.Color1 = Color.White;
            PanelDireita.TabIndex = 1;
            // 
            // pictureBoxMostrarSenha
            // 
            pictureBoxMostrarSenha.BackColor = Color.FromArgb(173, 186, 255);
            pictureBoxMostrarSenha.Cursor = Cursors.Hand;
            pictureBoxMostrarSenha.Image = Properties.Resources.closed_eye;
            pictureBoxMostrarSenha.Location = new Point(305, 240);
            pictureBoxMostrarSenha.Name = "pictureBoxMostrarSenha";
            pictureBoxMostrarSenha.Size = new Size(26, 23);
            pictureBoxMostrarSenha.TabIndex = 8;
            pictureBoxMostrarSenha.TabStop = false;
            pictureBoxMostrarSenha.Click += pictureBoxMostrarSenha_Click;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.CueHint.Color1 = Color.White;
            TextBoxSenha.CueHint.CueHintText = "Senha";
            TextBoxSenha.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSenha.Cursor = Cursors.IBeam;
            TextBoxSenha.Location = new Point(85, 234);
            TextBoxSenha.Name = "TextBoxSenha";

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
            // PictureBoxSenha
            // 
            PictureBoxSenha.Image = Properties.Resources.icone_senha;
            PictureBoxSenha.Location = new Point(40, 234);
            PictureBoxSenha.Name = "PictureBoxSenha";
            PictureBoxSenha.Size = new Size(39, 34);
            PictureBoxSenha.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBoxSenha.TabIndex = 7;
            PictureBoxSenha.TabStop = false;
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.CueHint.Color1 = Color.White;
            TextBoxUsuario.CueHint.CueHintText = "Usuário";
            TextBoxUsuario.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxUsuario.Location = new Point(85, 185);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(250, 34);
            TextBoxUsuario.StateCommon.Back.Color1 = Color.FromArgb(173, 186, 255);
            TextBoxUsuario.StateCommon.Border.Color1 = Color.FromArgb(173, 186, 255);
            TextBoxUsuario.StateCommon.Border.Color2 = Color.FromArgb(173, 186, 255);
            TextBoxUsuario.StateCommon.Border.Rounding = 7F;
            TextBoxUsuario.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxUsuario.StateCommon.Content.Padding = new Padding(4, 5, 4, 5);
            TextBoxUsuario.StateCommon.Content.TextH = PaletteRelativeAlign.Near;
            TextBoxUsuario.TabIndex = 1;
            // 
            // linkLabelSenha
            // 
            linkLabelSenha.ActiveLinkColor = Color.Gray;
            linkLabelSenha.AutoSize = true;
            linkLabelSenha.BackColor = Color.White;
            linkLabelSenha.Cursor = Cursors.Hand;
            linkLabelSenha.Font = new Font("Segoe UI", 9F);
            linkLabelSenha.LinkColor = Color.Gray;
            linkLabelSenha.Location = new Point(150, 271);
            linkLabelSenha.Name = "linkLabelSenha";
            linkLabelSenha.Size = new Size(118, 15);
            linkLabelSenha.TabIndex = 3;
            linkLabelSenha.TabStop = true;
            linkLabelSenha.Text = "Esqueci minha senha";
            linkLabelSenha.VisitedLinkColor = Color.Gray;
            linkLabelSenha.LinkClicked += linkLabelSenha_LinkClicked;
            // 
            // linkLabelCadastro
            // 
            linkLabelCadastro.ActiveLinkColor = Color.Blue;
            linkLabelCadastro.AutoSize = true;
            linkLabelCadastro.BackColor = Color.White;
            linkLabelCadastro.Cursor = Cursors.Hand;
            linkLabelCadastro.Font = new Font("Segoe UI", 11F);
            linkLabelCadastro.Location = new Point(89, 478);
            linkLabelCadastro.Name = "linkLabelCadastro";
            linkLabelCadastro.Size = new Size(246, 20);
            linkLabelCadastro.TabIndex = 5;
            linkLabelCadastro.TabStop = true;
            linkLabelCadastro.Text = "Não possui uma conta? Cadastre-se";
            linkLabelCadastro.VisitedLinkColor = Color.Blue;
            linkLabelCadastro.LinkClicked += linkLabelCadastro_LinkClicked;
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.Cursor = Cursors.Hand;
            ButtonEntrar.Location = new Point(145, 343);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.OverrideDefault.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.OverrideDefault.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.Size = new Size(132, 35);
            ButtonEntrar.StateCommon.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.StateCommon.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.StateCommon.Border.Color1 = Color.DarkOrange;
            ButtonEntrar.StateCommon.Border.Rounding = 15F;
            ButtonEntrar.StateCommon.Border.Width = 1;
            ButtonEntrar.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonEntrar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEntrar.StateNormal.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.StateNormal.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.StatePressed.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.StatePressed.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.StateTracking.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.StateTracking.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonEntrar.StateTracking.Border.Color1 = Color.Red;
            ButtonEntrar.StateTracking.Border.Rounding = 15F;
            ButtonEntrar.StateTracking.Border.Width = 2;
            ButtonEntrar.StateTracking.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEntrar.TabIndex = 4;
            ButtonEntrar.Values.DropDownArrowColor = Color.Empty;
            ButtonEntrar.Values.Text = "Entrar";
            ButtonEntrar.Click += ButtonEntrar_Click;
            // 
            // pictureBoxUsuario
            // 
            pictureBoxUsuario.BackColor = Color.Transparent;
            pictureBoxUsuario.Image = Properties.Resources.icone_usuario;
            pictureBoxUsuario.Location = new Point(15, 163);
            pictureBoxUsuario.Name = "pictureBoxUsuario";
            pictureBoxUsuario.Size = new Size(88, 83);
            pictureBoxUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUsuario.TabIndex = 0;
            pictureBoxUsuario.TabStop = false;
            // 
            // LabelLogin
            // 
            LabelLogin.Location = new Point(160, 87);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(96, 45);
            LabelLogin.StateCommon.Image.ImageColorMap = Color.Transparent;
            LabelLogin.StateCommon.ShortText.Color1 = Color.Blue;
            LabelLogin.StateCommon.ShortText.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            LabelLogin.TabIndex = 0;
            LabelLogin.Values.Text = "Login";
            // 
            // LoginForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(800, 600);
            Controls.Add(PanelDireita);
            Controls.Add(PanelEsquerda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)PanelEsquerda).EndInit();
            PanelEsquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelDireita).EndInit();
            PanelDireita.ResumeLayout(false);
            PanelDireita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrarSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxSenha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel PanelEsquerda;
        private Krypton.Toolkit.KryptonPanel PanelDireita;
        private Krypton.Toolkit.KryptonLabel LabelLogin;
        private Krypton.Toolkit.KryptonTextBox TextBoxUsuario;
        private Krypton.Toolkit.KryptonTextBox TextBoxSenha;
        private Krypton.Toolkit.KryptonButton ButtonEntrar;
        private LinkLabel linkLabelSenha;
        private LinkLabel linkLabelCadastro;
        private PictureBox pictureBoxUsuario;
        private KryptonPictureBox PictureBoxSenha;
        private PictureBox pictureBoxMostrarSenha;
        private PictureBox pictureBox2;
    }
}