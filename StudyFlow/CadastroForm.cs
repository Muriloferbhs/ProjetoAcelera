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
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
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
                MessageBox.Show("Preencha todos os campos!", "Atenção");
                return;
            }

            if (Usuario.ValidarSenha(senha) == false)
            {
                
                return;
            }



            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não são iguais!", "Atenção");
                return;
            }

            if (Usuario.AutenticarCPF(cpf) == false)
            {
                return;
            }
            if (Usuario.AutenticarEmail(email) == false)
            {
                return;
            }
            if (Usuario.AutenticarTelefone(telefone) == false)
            {
                return;
            }

            

            bool cont = false;

            foreach (Usuario u in Usuario.DadosDoCadastroLogin)
            {
                if (u.NomeUser == nomeUsuario || u.Cpf == cpf)
                {
                    cont = true;
                }
            }

            if (cont == false)
            {

                bool ativo = true;
                double pontuação = 0.0;
                Usuario novoUsuario = new Usuario(nomeCompleto, cpf, telefone, email, nomeUsuario, senha, ativo, pontuação);
                Usuario.DadosDoCadastroLogin.Add(novoUsuario);
                MessageBox.Show("Conta cadastrada com sucesso!");
               
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Conta ja está cadastrada!");
            }
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

        private void pictureBoxMostrarSenha_Click(object sender, EventArgs e)
        {
            // Alterna o estado da senha
            TextBoxSenha.UseSystemPasswordChar = !TextBoxSenha.UseSystemPasswordChar;

            // Altera o icone
            if (TextBoxSenha.UseSystemPasswordChar)
            {
                pictureBoxMostrarSenha.Image = Properties.Resources.closed_eye; // senha oculta
            }
            else
            {
                pictureBoxMostrarSenha.Image = Properties.Resources.open_eye; // senha visível
            }
        }

        private void pictureBoxMostrarSenha2_Click(object sender, EventArgs e)
        {
            // Alterna o estado da senha
            TextBoxConfirmeSenha.UseSystemPasswordChar = !TextBoxConfirmeSenha.UseSystemPasswordChar;

            // Altera o icone
            if (TextBoxConfirmeSenha.UseSystemPasswordChar)
            {
                pictureBoxMostrarSenha2.Image = Properties.Resources.closed_eye; // senha oculta
            }
            else
            {
                pictureBoxMostrarSenha2.Image = Properties.Resources.open_eye; // senha visível
            }
        }
    }
}
