
namespace StudyFlow
{
    partial class LoginForm
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
            panelDireita = new Panel();
            labelLogin = new Label();
            linkLabelCadastro = new LinkLabel();
            linkLabelSenha = new LinkLabel();
            txtPassword = new TextBox();
            btnEntrar = new Button();
            labelUser = new Label();
            labelSenha = new Label();
            txtUserName = new TextBox();
            panelEsquerda = new Panel();
            panelDireita.SuspendLayout();
            SuspendLayout();
            // 
            // panelDireita
            // 
            panelDireita.BackColor = Color.White;
            panelDireita.Controls.Add(labelLogin);
            panelDireita.Controls.Add(linkLabelCadastro);
            panelDireita.Controls.Add(linkLabelSenha);
            panelDireita.Controls.Add(txtPassword);
            panelDireita.Controls.Add(btnEntrar);
            panelDireita.Controls.Add(labelUser);
            panelDireita.Controls.Add(labelSenha);
            panelDireita.Controls.Add(txtUserName);
            panelDireita.Dock = DockStyle.Fill;
            panelDireita.Location = new Point(400, 0);
            panelDireita.Name = "panelDireita";
            panelDireita.Size = new Size(384, 561);
            panelDireita.TabIndex = 6;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogin.ForeColor = Color.FromArgb(0, 41, 255);
            labelLogin.Location = new Point(175, 114);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(63, 25);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Login";
            // 
            // linkLabelCadastro
            // 
            linkLabelCadastro.AutoSize = true;
            linkLabelCadastro.Cursor = Cursors.Hand;
            linkLabelCadastro.LinkColor = Color.FromArgb(0, 41, 255);
            linkLabelCadastro.Location = new Point(86, 356);
            linkLabelCadastro.Name = "linkLabelCadastro";
            linkLabelCadastro.Size = new Size(187, 15);
            linkLabelCadastro.TabIndex = 6;
            linkLabelCadastro.TabStop = true;
            linkLabelCadastro.Text = "Não tem uma conta? Cadastrar-se";
            linkLabelCadastro.VisitedLinkColor = Color.FromArgb(0, 41, 255);
            linkLabelCadastro.LinkClicked += linkLabelCadastro_LinkClicked;
            // 
            // linkLabelSenha
            // 
            linkLabelSenha.AutoSize = true;
            linkLabelSenha.Cursor = Cursors.Hand;
            linkLabelSenha.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelSenha.LinkColor = Color.FromArgb(115, 115, 115);
            linkLabelSenha.Location = new Point(121, 240);
            linkLabelSenha.Name = "linkLabelSenha";
            linkLabelSenha.Size = new Size(115, 13);
            linkLabelSenha.TabIndex = 5;
            linkLabelSenha.TabStop = true;
            linkLabelSenha.Text = "Esqueci minha senha";
            linkLabelSenha.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Location = new Point(121, 214);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Senha";
            txtPassword.Size = new Size(172, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.FromArgb(237, 75, 0);
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(154, 280);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(82, 33);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(55, 177);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(47, 15);
            labelUser.TabIndex = 0;
            labelUser.Text = "Usuário";
            labelUser.Click += label1_Click;
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(63, 217);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 2;
            labelSenha.Text = "Senha";
            labelSenha.Click += labelSenha_Click;
            // 
            // txtUserName
            // 
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Location = new Point(121, 174);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "Usuário";
            txtUserName.Size = new Size(172, 23);
            txtUserName.TabIndex = 1;
            txtUserName.TextChanged += textUserName_TextChanged;
            // 
            // panelEsquerda
            // 
            panelEsquerda.BackColor = Color.FromArgb(32, 0, 177);
            panelEsquerda.Dock = DockStyle.Left;
            panelEsquerda.Location = new Point(0, 0);
            panelEsquerda.Name = "panelEsquerda";
            panelEsquerda.Size = new Size(400, 561);
            panelEsquerda.TabIndex = 5;
            // 
            // LoginForm
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panelDireita);
            Controls.Add(panelEsquerda);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            panelDireita.ResumeLayout(false);
            panelDireita.PerformLayout();
            ResumeLayout(false);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        #endregion

        private Panel panelDireita;
        private Label labelLogin;
        private LinkLabel linkLabelCadastro;
        private LinkLabel linkLabelSenha;
        private TextBox txtPassword;
        private Button btnEntrar;
        private Label labelUser;
        private Label labelSenha;
        private TextBox txtUserName;
        private Panel panelEsquerda;
    }
}