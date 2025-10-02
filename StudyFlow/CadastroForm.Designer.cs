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
            txtBoxUsuario = new Krypton.Toolkit.KryptonTextBox();
            txtBoxSenha = new Krypton.Toolkit.KryptonTextBox();
            txtBoxConfirmSenha = new Krypton.Toolkit.KryptonTextBox();
            LabelUsuario = new Krypton.Toolkit.KryptonLabel();
            LabelSenha = new Krypton.Toolkit.KryptonLabel();
            LabelConfirmSenha = new Krypton.Toolkit.KryptonLabel();
            btnSalvar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanelEsquerda).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanelEsquerda
            // 
            kryptonPanelEsquerda.Dock = DockStyle.Left;
            kryptonPanelEsquerda.Location = new Point(0, 0);
            kryptonPanelEsquerda.Name = "kryptonPanelEsquerda";
            kryptonPanelEsquerda.Size = new Size(400, 561);
            kryptonPanelEsquerda.StateNormal.Color1 = Color.FromArgb(32, 0, 177);
            kryptonPanelEsquerda.TabIndex = 0;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.CueHint.Color1 = Color.Gray;
            txtBoxUsuario.CueHint.CueHintText = "Usuario";
            txtBoxUsuario.Cursor = Cursors.IBeam;
            txtBoxUsuario.Location = new Point(562, 88);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(132, 23);
            txtBoxUsuario.TabIndex = 1;
            txtBoxUsuario.TextChanged += txtBoxUsuario_TextChanged;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.CueHint.Color1 = Color.Gray;
            txtBoxSenha.CueHint.CueHintText = "Senha";
            txtBoxSenha.Cursor = Cursors.IBeam;
            txtBoxSenha.Location = new Point(562, 128);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PasswordChar = '●';
            txtBoxSenha.Size = new Size(132, 23);
            txtBoxSenha.TabIndex = 2;
            txtBoxSenha.UseSystemPasswordChar = true;
            txtBoxSenha.TextChanged += TxtBoxSenha_TextChanged;
            // 
            // txtBoxConfirmSenha
            // 
            txtBoxConfirmSenha.CueHint.Color1 = Color.Gray;
            txtBoxConfirmSenha.CueHint.CueHintText = "Confirmar senha";
            txtBoxConfirmSenha.Cursor = Cursors.IBeam;
            txtBoxConfirmSenha.Location = new Point(562, 157);
            txtBoxConfirmSenha.Name = "txtBoxConfirmSenha";
            txtBoxConfirmSenha.PasswordChar = '●';
            txtBoxConfirmSenha.Size = new Size(132, 23);
            txtBoxConfirmSenha.TabIndex = 3;
            txtBoxConfirmSenha.UseSystemPasswordChar = true;
            // 
            // LabelUsuario
            // 
            LabelUsuario.Location = new Point(477, 91);
            LabelUsuario.Name = "LabelUsuario";
            LabelUsuario.Size = new Size(55, 20);
            LabelUsuario.TabIndex = 4;
            LabelUsuario.Values.Text = "Usuário: ";
            // 
            // LabelSenha
            // 
            LabelSenha.Location = new Point(477, 131);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(46, 20);
            LabelSenha.TabIndex = 5;
            LabelSenha.Values.Text = "Senha:";
            // 
            // LabelConfirmSenha
            // 
            LabelConfirmSenha.Location = new Point(456, 160);
            LabelConfirmSenha.Name = "LabelConfirmSenha";
            LabelConfirmSenha.Size = new Size(103, 20);
            LabelConfirmSenha.TabIndex = 6;
            LabelConfirmSenha.Values.Text = "Confirmar senha:";
            // 
            // btnSalvar
            // 
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.Location = new Point(572, 201);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 25);
            btnSalvar.TabIndex = 7;
            btnSalvar.Values.DropDownArrowColor = Color.Empty;
            btnSalvar.Values.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // CadastroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnSalvar);
            Controls.Add(LabelConfirmSenha);
            Controls.Add(LabelSenha);
            Controls.Add(LabelUsuario);
            Controls.Add(txtBoxConfirmSenha);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(kryptonPanelEsquerda);
            Name = "CadastroForm";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)kryptonPanelEsquerda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanelEsquerda;
        private Krypton.Toolkit.KryptonTextBox txtBoxUsuario;
        private Krypton.Toolkit.KryptonTextBox txtBoxSenha;
        private Krypton.Toolkit.KryptonTextBox txtBoxConfirmSenha;
        private Krypton.Toolkit.KryptonLabel LabelUsuario;
        private Krypton.Toolkit.KryptonLabel LabelSenha;
        private Krypton.Toolkit.KryptonLabel LabelConfirmSenha;
        private Krypton.Toolkit.KryptonButton btnSalvar;
    }
}