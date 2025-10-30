namespace StudyFlow
{
    partial class CadastroForm
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
            kryptonPanelEsquerda = new Krypton.Toolkit.KryptonPanel();
            TextBoxNome = new Krypton.Toolkit.KryptonTextBox();
            PanelDireita = new Krypton.Toolkit.KryptonPanel();
            pictureBoxMostrarSenha2 = new PictureBox();
            pictureBoxMostrarSenha = new PictureBox();
            ButtonSalvar = new Krypton.Toolkit.KryptonButton();
            linkLabelLogin = new LinkLabel();
            TextBoxSenha = new Krypton.Toolkit.KryptonTextBox();
            TextBoxConfirmeSenha = new Krypton.Toolkit.KryptonTextBox();
            TextBoxCpf = new Krypton.Toolkit.KryptonTextBox();
            TextBoxTelefone = new Krypton.Toolkit.KryptonTextBox();
            TextBoxEmail = new Krypton.Toolkit.KryptonTextBox();
            TextBoxUsuario = new Krypton.Toolkit.KryptonTextBox();
            LabelConfirmeSenha = new Krypton.Toolkit.KryptonLabel();
            LabelCpf = new Krypton.Toolkit.KryptonLabel();
            LabelSenha = new Krypton.Toolkit.KryptonLabel();
            LabelTelefone = new Krypton.Toolkit.KryptonLabel();
            LabelEmail = new Krypton.Toolkit.KryptonLabel();
            LabelUsuario = new Krypton.Toolkit.KryptonLabel();
            LabelNome = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelEsquerda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelDireita).BeginInit();
            PanelDireita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrarSenha2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrarSenha).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanelEsquerda
            // 
            kryptonPanelEsquerda.Dock = DockStyle.Left;
            kryptonPanelEsquerda.Location = new Point(0, 0);
            kryptonPanelEsquerda.Name = "kryptonPanelEsquerda";
            kryptonPanelEsquerda.Size = new Size(392, 588);
            kryptonPanelEsquerda.StateNormal.Color1 = Color.White;
            kryptonPanelEsquerda.TabIndex = 0;
            // 
            // TextBoxNome
            // 
            TextBoxNome.CueHint.Color1 = Color.DimGray;
            TextBoxNome.CueHint.CueHintText = "Digite seu nome completo";
            TextBoxNome.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxNome.Cursor = Cursors.IBeam;
            TextBoxNome.Location = new Point(52, 87);
            TextBoxNome.Name = "TextBoxNome";
            TextBoxNome.Size = new Size(301, 32);
            TextBoxNome.StateCommon.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxNome.StateCommon.Border.Rounding = 10F;
            TextBoxNome.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxNome.StateCommon.Content.Padding = new Padding(4, 3, 4, 3);
            TextBoxNome.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            TextBoxNome.StateNormal.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxNome.TabIndex = 8;
            // 
            // PanelDireita
            // 
            PanelDireita.Controls.Add(pictureBoxMostrarSenha2);
            PanelDireita.Controls.Add(pictureBoxMostrarSenha);
            PanelDireita.Controls.Add(ButtonSalvar);
            PanelDireita.Controls.Add(linkLabelLogin);
            PanelDireita.Controls.Add(TextBoxSenha);
            PanelDireita.Controls.Add(TextBoxConfirmeSenha);
            PanelDireita.Controls.Add(TextBoxCpf);
            PanelDireita.Controls.Add(TextBoxTelefone);
            PanelDireita.Controls.Add(TextBoxEmail);
            PanelDireita.Controls.Add(TextBoxUsuario);
            PanelDireita.Controls.Add(TextBoxNome);
            PanelDireita.Controls.Add(LabelConfirmeSenha);
            PanelDireita.Controls.Add(LabelCpf);
            PanelDireita.Controls.Add(LabelSenha);
            PanelDireita.Controls.Add(LabelTelefone);
            PanelDireita.Controls.Add(LabelEmail);
            PanelDireita.Controls.Add(LabelUsuario);
            PanelDireita.Controls.Add(LabelNome);
            PanelDireita.Dock = DockStyle.Fill;
            PanelDireita.Location = new Point(392, 0);
            PanelDireita.Name = "PanelDireita";
            PanelDireita.Size = new Size(412, 588);
            PanelDireita.StateNormal.Color1 = Color.FromArgb(32, 0, 177);
            PanelDireita.TabIndex = 11;
            // 
            // pictureBoxMostrarSenha2
            // 
            pictureBoxMostrarSenha2.BackColor = Color.FromArgb(200, 194, 231);
            pictureBoxMostrarSenha2.Cursor = Cursors.Hand;
            pictureBoxMostrarSenha2.Image = Properties.Resources.closed_eye;
            pictureBoxMostrarSenha2.Location = new Point(324, 335);
            pictureBoxMostrarSenha2.Name = "pictureBoxMostrarSenha2";
            pictureBoxMostrarSenha2.Size = new Size(26, 23);
            pictureBoxMostrarSenha2.TabIndex = 27;
            pictureBoxMostrarSenha2.TabStop = false;
            pictureBoxMostrarSenha2.Click += pictureBoxMostrarSenha2_Click;
            // 
            // pictureBoxMostrarSenha
            // 
            pictureBoxMostrarSenha.BackColor = Color.FromArgb(200, 194, 231);
            pictureBoxMostrarSenha.Cursor = Cursors.Hand;
            pictureBoxMostrarSenha.Image = Properties.Resources.closed_eye;
            pictureBoxMostrarSenha.Location = new Point(158, 335);
            pictureBoxMostrarSenha.Name = "pictureBoxMostrarSenha";
            pictureBoxMostrarSenha.Size = new Size(26, 23);
            pictureBoxMostrarSenha.TabIndex = 26;
            pictureBoxMostrarSenha.TabStop = false;
            pictureBoxMostrarSenha.Click += pictureBoxMostrarSenha_Click;
            // 
            // ButtonSalvar
            // 
            ButtonSalvar.Cursor = Cursors.Hand;
            ButtonSalvar.Location = new Point(136, 449);
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
            ButtonSalvar.TabIndex = 25;
            ButtonSalvar.Values.DropDownArrowColor = Color.Empty;
            ButtonSalvar.Values.Text = "Cadastrar";
            ButtonSalvar.Click += ButtonSalvar_Click;
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.ActiveLinkColor = Color.White;
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.BackColor = Color.FromArgb(32, 0, 177);
            linkLabelLogin.Cursor = Cursors.Hand;
            linkLabelLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabelLogin.LinkColor = Color.White;
            linkLabelLogin.Location = new Point(123, 525);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(163, 17);
            linkLabelLogin.TabIndex = 24;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "Já tem uma conta? Login";
            linkLabelLogin.VisitedLinkColor = Color.White;
            linkLabelLogin.LinkClicked += linkLabelLogin_LinkClicked;
            // 
            // TextBoxSenha
            // 
            TextBoxSenha.CueHint.Color1 = Color.DimGray;
            TextBoxSenha.CueHint.CueHintText = "Digite a senha";
            TextBoxSenha.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSenha.Cursor = Cursors.IBeam;
            TextBoxSenha.Location = new Point(52, 330);
            TextBoxSenha.Name = "TextBoxSenha";
            TextBoxSenha.PasswordChar = '●';
            TextBoxSenha.Size = new Size(135, 32);
            TextBoxSenha.StateCommon.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxSenha.StateCommon.Border.Rounding = 10F;
            TextBoxSenha.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxSenha.StateCommon.Content.Padding = new Padding(4, 3, 4, 3);
            TextBoxSenha.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            TextBoxSenha.StateNormal.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxSenha.TabIndex = 15;
            TextBoxSenha.UseSystemPasswordChar = true;
            // 
            // TextBoxConfirmeSenha
            // 
            TextBoxConfirmeSenha.CueHint.Color1 = Color.DimGray;
            TextBoxConfirmeSenha.CueHint.CueHintText = "Digite a senha";
            TextBoxConfirmeSenha.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxConfirmeSenha.Cursor = Cursors.IBeam;
            TextBoxConfirmeSenha.Location = new Point(218, 330);
            TextBoxConfirmeSenha.Name = "TextBoxConfirmeSenha";
            TextBoxConfirmeSenha.PasswordChar = '●';
            TextBoxConfirmeSenha.Size = new Size(135, 32);
            TextBoxConfirmeSenha.StateCommon.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxConfirmeSenha.StateCommon.Border.Rounding = 10F;
            TextBoxConfirmeSenha.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxConfirmeSenha.StateCommon.Content.Padding = new Padding(4, 3, 4, 3);
            TextBoxConfirmeSenha.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            TextBoxConfirmeSenha.StateNormal.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxConfirmeSenha.TabIndex = 14;
            TextBoxConfirmeSenha.UseSystemPasswordChar = true;
            // 
            // TextBoxCpf
            // 
            TextBoxCpf.CueHint.Color1 = Color.DimGray;
            TextBoxCpf.CueHint.CueHintText = "Digite seu CPF";
            TextBoxCpf.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxCpf.Cursor = Cursors.IBeam;
            TextBoxCpf.Location = new Point(218, 267);
            TextBoxCpf.Name = "TextBoxCpf";
            TextBoxCpf.Size = new Size(135, 32);
            TextBoxCpf.StateCommon.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxCpf.StateCommon.Border.Rounding = 10F;
            TextBoxCpf.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxCpf.StateCommon.Content.Padding = new Padding(4, 3, 4, 3);
            TextBoxCpf.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            TextBoxCpf.StateNormal.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxCpf.TabIndex = 13;
            // 
            // TextBoxTelefone
            // 
            TextBoxTelefone.CueHint.Color1 = Color.DimGray;
            TextBoxTelefone.CueHint.CueHintText = "Digite seu tel.";
            TextBoxTelefone.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxTelefone.Cursor = Cursors.IBeam;
            TextBoxTelefone.Location = new Point(52, 267);
            TextBoxTelefone.Name = "TextBoxTelefone";
            TextBoxTelefone.Size = new Size(135, 32);
            TextBoxTelefone.StateCommon.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxTelefone.StateCommon.Border.Rounding = 10F;
            TextBoxTelefone.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxTelefone.StateCommon.Content.Padding = new Padding(4, 3, 4, 3);
            TextBoxTelefone.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            TextBoxTelefone.StateNormal.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxTelefone.TabIndex = 12;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.CueHint.Color1 = Color.DimGray;
            TextBoxEmail.CueHint.CueHintText = "Digite seu e-mail";
            TextBoxEmail.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxEmail.Cursor = Cursors.IBeam;
            TextBoxEmail.Location = new Point(52, 205);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(301, 32);
            TextBoxEmail.StateActive.Border.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxEmail.StateActive.Border.Color2 = Color.FromArgb(200, 194, 231);
            TextBoxEmail.StateActive.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidInside;
            TextBoxEmail.StateCommon.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxEmail.StateCommon.Border.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxEmail.StateCommon.Border.Color2 = Color.FromArgb(200, 194, 231);
            TextBoxEmail.StateCommon.Border.Rounding = 10F;
            TextBoxEmail.StateCommon.Border.Width = 1;
            TextBoxEmail.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxEmail.StateCommon.Content.Padding = new Padding(4, 3, 4, 3);
            TextBoxEmail.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            TextBoxEmail.StateNormal.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxEmail.StateNormal.Border.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxEmail.StateNormal.Border.Color2 = Color.FromArgb(200, 194, 231);
            TextBoxEmail.TabIndex = 10;
            // 
            // TextBoxUsuario
            // 
            TextBoxUsuario.CueHint.Color1 = Color.DimGray;
            TextBoxUsuario.CueHint.CueHintText = "Digite seu usuário";
            TextBoxUsuario.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxUsuario.Cursor = Cursors.IBeam;
            TextBoxUsuario.Location = new Point(52, 146);
            TextBoxUsuario.Name = "TextBoxUsuario";
            TextBoxUsuario.Size = new Size(301, 32);
            TextBoxUsuario.StateCommon.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxUsuario.StateCommon.Border.Rounding = 10F;
            TextBoxUsuario.StateCommon.Content.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxUsuario.StateCommon.Content.Padding = new Padding(4, 3, 4, 3);
            TextBoxUsuario.StateCommon.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            TextBoxUsuario.StateNormal.Back.Color1 = Color.FromArgb(200, 194, 231);
            TextBoxUsuario.TabIndex = 9;
            // 
            // LabelConfirmeSenha
            // 
            LabelConfirmeSenha.Location = new Point(218, 308);
            LabelConfirmeSenha.Name = "LabelConfirmeSenha";
            LabelConfirmeSenha.Size = new Size(112, 20);
            LabelConfirmeSenha.StateCommon.ShortText.Color1 = Color.White;
            LabelConfirmeSenha.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelConfirmeSenha.StateNormal.ShortText.Color1 = Color.White;
            LabelConfirmeSenha.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelConfirmeSenha.TabIndex = 22;
            LabelConfirmeSenha.Values.Text = "Confirme a senha";
            // 
            // LabelCpf
            // 
            LabelCpf.Location = new Point(218, 247);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new Size(32, 20);
            LabelCpf.StateCommon.ShortText.Color1 = Color.White;
            LabelCpf.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelCpf.StateNormal.ShortText.Color1 = Color.White;
            LabelCpf.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelCpf.TabIndex = 21;
            LabelCpf.Values.Text = "CPF";
            // 
            // LabelSenha
            // 
            LabelSenha.Location = new Point(54, 309);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(46, 20);
            LabelSenha.StateCommon.ShortText.Color1 = Color.White;
            LabelSenha.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelSenha.StateNormal.ShortText.Color1 = Color.White;
            LabelSenha.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelSenha.TabIndex = 20;
            LabelSenha.Values.Text = "Senha";
            // 
            // LabelTelefone
            // 
            LabelTelefone.Location = new Point(52, 247);
            LabelTelefone.Name = "LabelTelefone";
            LabelTelefone.Size = new Size(61, 20);
            LabelTelefone.StateCommon.ShortText.Color1 = Color.White;
            LabelTelefone.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelTelefone.StateNormal.ShortText.Color1 = Color.White;
            LabelTelefone.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelTelefone.TabIndex = 19;
            LabelTelefone.Values.Text = "Telefone";
            // 
            // LabelEmail
            // 
            LabelEmail.Location = new Point(54, 184);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(47, 20);
            LabelEmail.StateCommon.ShortText.Color1 = Color.White;
            LabelEmail.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelEmail.StateNormal.ShortText.Color1 = Color.White;
            LabelEmail.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelEmail.TabIndex = 18;
            LabelEmail.Values.Text = "E-mail";
            // 
            // LabelUsuario
            // 
            LabelUsuario.Location = new Point(54, 125);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(111, 20);
            LabelUsuario.StateCommon.ShortText.Color1 = Color.White;
            LabelUsuario.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelUsuario.StateNormal.ShortText.Color1 = Color.White;
            LabelUsuario.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelUsuario.TabIndex = 17;
            LabelUsuario.Values.Text = "Nome de Usuário";
            // 
            // LabelNome
            // 
            LabelNome.Location = new Point(54, 66);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(104, 20);
            LabelNome.StateCommon.ShortText.Color1 = Color.White;
            LabelNome.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelNome.StateNormal.ShortText.Color1 = Color.White;
            LabelNome.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelNome.TabIndex = 16;
            LabelNome.Values.Text = "Nome completo";
            // 
            // CadastroForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(804, 588);
            Controls.Add(PanelDireita);
            Controls.Add(kryptonPanelEsquerda);
            Location = new Point(0, 0);
            Name = "CadastroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            FormClosing += CadastroForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)kryptonPanelEsquerda).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelDireita).EndInit();
            PanelDireita.ResumeLayout(false);
            PanelDireita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrarSenha2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMostrarSenha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelEsquerda;
        private Krypton.Toolkit.KryptonTextBox TextBoxNome;
        private Krypton.Toolkit.KryptonPanel PanelDireita;
        private Krypton.Toolkit.KryptonTextBox TextBoxTelefone;
        private Krypton.Toolkit.KryptonTextBox TextBoxEmail;
        private Krypton.Toolkit.KryptonTextBox TextBoxUsuario;
        private Krypton.Toolkit.KryptonTextBox TextBoxSenha;
        private Krypton.Toolkit.KryptonTextBox TextBoxConfirmeSenha;
        private Krypton.Toolkit.KryptonTextBox TextBoxCpf;
        private Krypton.Toolkit.KryptonLabel LabelConfirmeSenha;
        private Krypton.Toolkit.KryptonLabel LabelCpf;
        private Krypton.Toolkit.KryptonLabel LabelSenha;
        private Krypton.Toolkit.KryptonLabel LabelTelefone;
        private Krypton.Toolkit.KryptonLabel LabelEmail;
        private Krypton.Toolkit.KryptonLabel LabelUsuario;
        private Krypton.Toolkit.KryptonLabel LabelNome;
        private LinkLabel linkLabelLogin;
        private Krypton.Toolkit.KryptonButton ButtonSalvar;
        private PictureBox pictureBoxMostrarSenha2;
        private PictureBox pictureBoxMostrarSenha;
    }
}