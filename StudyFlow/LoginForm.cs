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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudyFlow
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LabelLogin_Click(object sender, EventArgs e)
        {

        }

        private void PanelDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            string dadosLogin = TextBoxUsuario.Text.Trim();
            string senhaLogin = TextBoxSenha.Text;

            if (string.IsNullOrEmpty(dadosLogin))
            {
                MessageBox.Show("Digite o nome de usuário.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senhaLogin))
            {
                MessageBox.Show("Digite a senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxSenha.Focus();
                return;
            }



            //login teste----------------------
            //carlos 04/10---------------------
            string nomeCompleto = "senhor batata da silva";
            string cpf = "52998224725";
            string telefone = "12991545412";
            string email = "SenhorBatata@gmail.com";
            string nomeUsuario1 = "srBatata";
            string senha1 = "perdiMeuChapeu";
            bool ativo = false;

            Usuario testeUsuario = new Usuario();
            testeUsuario.AtribuirDadosDoUsuario(nomeCompleto, cpf, telefone, email, nomeUsuario1, senha1, ativo);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario);
            //teste
            //---------------------------------




            Usuario.Logar(dadosLogin, senhaLogin);

        }

        private void linkLabelCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroForm cadastro = new CadastroForm();
            cadastro.Show();

            this.Hide();
        }

        private void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PanelEsquerda_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool senhaVisivel = false;
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
    }
}


