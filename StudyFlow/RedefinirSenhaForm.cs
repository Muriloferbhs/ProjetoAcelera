using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyFlow {
    public partial class RedefinirSenhaForm : Form {
        public RedefinirSenhaForm() {
            InitializeComponent();
        }


        private void ButtonSalvar_Click(object sender, EventArgs e) {
            string novaSenha = TextBoxSenha.Text.Trim();
            string confirmarNovaSenha = TextBoxConfirmarSenha.Text;
        

            if (string.IsNullOrEmpty(novaSenha))
            {
                MessageBox.Show("Digite a senhao.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxSenha.Focus();
                return;
            }

            if (string.IsNullOrEmpty(confirmarNovaSenha))
            {
                MessageBox.Show("Digite a senha novamente.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxConfirmarSenha.Focus();
                return;
            }


            if (novaSenha != confirmarNovaSenha)
            {
                KryptonMessageBox.Show("As senhas não são iguais!", "Atenção");
                return;
            }




            Usuario.RedefinirSenhaSenha(novaSenha);

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();


        }







        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void RecuperarSenhaForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show(
                    "Deseja realmente sair?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true; // Cancela o fechamento
                }
                else
                {
                    Application.Exit(); // Fecha toda a aplicação
                }
            }
        }

        private bool senhaVisivel = false;
        private void pictureBoxVerSenha_Click(object sender, EventArgs e) {
            // Alterna o estado da senha
            TextBoxSenha.UseSystemPasswordChar = !TextBoxSenha.UseSystemPasswordChar;

            // Altera o icone
            if (TextBoxSenha.UseSystemPasswordChar)
            {
                pictureBoxVerSenha.Image = Properties.Resources.closed_eye; // senha oculta
            }
            else
            {
                pictureBoxVerSenha.Image = Properties.Resources.open_eye; // senha visível
            }
        }

        private void pictureBoxVerConfirmarSenha_Click(object sender, EventArgs e) {
            // Alterna o estado da senha
            TextBoxConfirmarSenha.UseSystemPasswordChar = !TextBoxConfirmarSenha.UseSystemPasswordChar;

            // Altera o icone
            if (TextBoxConfirmarSenha.UseSystemPasswordChar)
            {
                pictureBoxVerConfirmarSenha.Image = Properties.Resources.closed_eye; // senha oculta
            }
            else
            {
                pictureBoxVerConfirmarSenha.Image = Properties.Resources.open_eye; // senha visível
            }
        }
    }
}
