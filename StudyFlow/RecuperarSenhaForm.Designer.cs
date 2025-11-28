namespace StudyFlow {
    partial class RecuperarSenhaForm {
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
            kryptonPanelEsquerda = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            TextBoxNome = new Krypton.Toolkit.KryptonTextBox();
            PanelDireita = new Krypton.Toolkit.KryptonPanel();
            ButtonConfirmar = new Krypton.Toolkit.KryptonButton();
            linkLabelLogin = new LinkLabel();
            TextBoxCpf = new Krypton.Toolkit.KryptonTextBox();
            TextBoxTelefone = new Krypton.Toolkit.KryptonTextBox();
            TextBoxEmail = new Krypton.Toolkit.KryptonTextBox();
            LabelCpf = new Krypton.Toolkit.KryptonLabel();
            LabelTelefone = new Krypton.Toolkit.KryptonLabel();
            LabelEmail = new Krypton.Toolkit.KryptonLabel();
            LabelNome = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelEsquerda).BeginInit();
            kryptonPanelEsquerda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PanelDireita).BeginInit();
            PanelDireita.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanelEsquerda
            // 
            kryptonPanelEsquerda.Controls.Add(pictureBox1);
            kryptonPanelEsquerda.Dock = DockStyle.Left;
            kryptonPanelEsquerda.Location = new Point(0, 0);
            kryptonPanelEsquerda.Name = "kryptonPanelEsquerda";
            kryptonPanelEsquerda.Size = new Size(392, 600);
            kryptonPanelEsquerda.StateNormal.Color1 = Color.White;
            kryptonPanelEsquerda.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.logostudycadastro;
            pictureBox1.Location = new Point(66, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 351);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TextBoxNome
            // 
            TextBoxNome.CueHint.Color1 = Color.DimGray;
            TextBoxNome.CueHint.CueHintText = "Digite seu nome completo";
            TextBoxNome.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxNome.Cursor = Cursors.IBeam;
            TextBoxNome.Location = new Point(52, 111);
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
            PanelDireita.Controls.Add(ButtonConfirmar);
            PanelDireita.Controls.Add(linkLabelLogin);
            PanelDireita.Controls.Add(TextBoxCpf);
            PanelDireita.Controls.Add(TextBoxTelefone);
            PanelDireita.Controls.Add(TextBoxEmail);
            PanelDireita.Controls.Add(TextBoxNome);
            PanelDireita.Controls.Add(LabelCpf);
            PanelDireita.Controls.Add(LabelTelefone);
            PanelDireita.Controls.Add(LabelEmail);
            PanelDireita.Controls.Add(LabelNome);
            PanelDireita.Dock = DockStyle.Fill;
            PanelDireita.Location = new Point(392, 0);
            PanelDireita.Name = "PanelDireita";
            PanelDireita.Size = new Size(408, 600);
            PanelDireita.StateNormal.Color1 = Color.FromArgb(32, 0, 177);
            PanelDireita.TabIndex = 11;
            // 
            // ButtonConfirmar
            // 
            ButtonConfirmar.Cursor = Cursors.Hand;
            ButtonConfirmar.Location = new Point(136, 449);
            ButtonConfirmar.Name = "ButtonConfirmar";
            ButtonConfirmar.OverrideDefault.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.OverrideDefault.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.Size = new Size(132, 35);
            ButtonConfirmar.StateCommon.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.StateCommon.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.StateCommon.Border.Color1 = Color.DarkOrange;
            ButtonConfirmar.StateCommon.Border.Rounding = 15F;
            ButtonConfirmar.StateCommon.Border.Width = 1;
            ButtonConfirmar.StateCommon.Content.ShortText.Color1 = Color.White;
            ButtonConfirmar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonConfirmar.StateNormal.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.StateNormal.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.StatePressed.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.StatePressed.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.StateTracking.Back.Color1 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.StateTracking.Back.Color2 = Color.FromArgb(237, 75, 0);
            ButtonConfirmar.StateTracking.Border.Color1 = Color.Red;
            ButtonConfirmar.StateTracking.Border.Rounding = 15F;
            ButtonConfirmar.StateTracking.Border.Width = 2;
            ButtonConfirmar.StateTracking.Content.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonConfirmar.TabIndex = 25;
            ButtonConfirmar.Values.DropDownArrowColor = Color.Empty;
            ButtonConfirmar.Values.Text = "Confirmar";
            ButtonConfirmar.Click += ButtonConfirmar_Click;
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
            // TextBoxCpf
            // 
            TextBoxCpf.CueHint.Color1 = Color.DimGray;
            TextBoxCpf.CueHint.CueHintText = "Digite seu CPF";
            TextBoxCpf.CueHint.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBoxCpf.Cursor = Cursors.IBeam;
            TextBoxCpf.Location = new Point(52, 344);
            TextBoxCpf.Name = "TextBoxCpf";
            TextBoxCpf.Size = new Size(301, 32);
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
            TextBoxTelefone.Size = new Size(301, 32);
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
            TextBoxEmail.Location = new Point(52, 185);
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
            // LabelCpf
            // 
            LabelCpf.Location = new Point(54, 318);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new Size(32, 20);
            LabelCpf.StateCommon.ShortText.Color1 = Color.White;
            LabelCpf.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelCpf.StateNormal.ShortText.Color1 = Color.White;
            LabelCpf.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelCpf.TabIndex = 21;
            LabelCpf.Values.Text = "CPF";
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
            LabelEmail.Location = new Point(54, 164);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(47, 20);
            LabelEmail.StateCommon.ShortText.Color1 = Color.White;
            LabelEmail.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelEmail.StateNormal.ShortText.Color1 = Color.White;
            LabelEmail.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelEmail.TabIndex = 18;
            LabelEmail.Values.Text = "E-mail";
            // 
            // LabelNome
            // 
            LabelNome.Location = new Point(52, 85);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(104, 20);
            LabelNome.StateCommon.ShortText.Color1 = Color.White;
            LabelNome.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LabelNome.StateNormal.ShortText.Color1 = Color.White;
            LabelNome.StateNormal.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            LabelNome.TabIndex = 16;
            LabelNome.Values.Text = "Nome completo";
            // 
            // RecuperarSenhaForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(800, 600);
            Controls.Add(PanelDireita);
            Controls.Add(kryptonPanelEsquerda);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "RecuperarSenhaForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecuperarSenha";
            FormClosing += RecuperarSenhaForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)kryptonPanelEsquerda).EndInit();
            kryptonPanelEsquerda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PanelDireita).EndInit();
            PanelDireita.ResumeLayout(false);
            PanelDireita.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelEsquerda;
        private Krypton.Toolkit.KryptonTextBox TextBoxNome;
        private Krypton.Toolkit.KryptonPanel PanelDireita;
        private Krypton.Toolkit.KryptonTextBox TextBoxTelefone;
        private Krypton.Toolkit.KryptonTextBox TextBoxEmail;
        private Krypton.Toolkit.KryptonTextBox TextBoxCpf;
        private Krypton.Toolkit.KryptonLabel LabelCpf;
        private Krypton.Toolkit.KryptonLabel LabelTelefone;
        private Krypton.Toolkit.KryptonLabel LabelEmail;
        private Krypton.Toolkit.KryptonLabel LabelNome;
        private LinkLabel linkLabelLogin;
        private Krypton.Toolkit.KryptonButton ButtonConfirmar;
        private PictureBox pictureBox1;
    }
}