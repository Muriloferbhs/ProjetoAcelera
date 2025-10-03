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

namespace StudyFlow
{
    public partial class CadastroForm : KryptonForm
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void kryptonLabel5_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel7_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSalvar_Click(object sender, EventArgs e)
        {
            string nomeCompleto = TextBoxNome.Text.Trim();
            string nomeUsuario = TextBoxUsuario.Text.Trim();
            string telefone = TextBoxTelefone.Text.Trim();
            string email = TextBoxEmail.Text.Trim();
            string cpf = TextBoxCpf.Text.Trim();
            string senha = TextBoxSenha.Text.Trim();
            string confirmarSenha = TextBoxConfirmeSenha.Text.Trim();

            if (string.IsNullOrEmpty(nomeUsuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(nomeCompleto) ||
                string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(cpf))
            {
                KryptonMessageBox.Show("Preencha todos os campos!", "Atenção");
                return;
            }
            if (senha != confirmarSenha)
            {
                KryptonMessageBox.Show("As senhas não são iguais!", "Atenção");
                return;
            }


            // logica para novo salvar novo usuario :P


            KryptonMessageBox.Show("Usuário cadastrado com sucesso!");
            this.Close();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }


        private void CadastroForm_FormClosing(object sender, FormClosingEventArgs e)
        {
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

    }
}

