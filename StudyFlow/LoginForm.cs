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
            string nomeUsuario = TextBoxUsuario.Text.Trim();
            string senha = TextBoxSenha.Text;

            if (string.IsNullOrEmpty(nomeUsuario))
            {
                MessageBox.Show("Digite o nome de usuário.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Digite a senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxSenha.Focus();
                return;
            }

            // ===============================
            // AQUI: implementar usando List<User>
            // ===============================

            MessageBox.Show("Lógica de autenticação ficará para o grupo (List<User>).");
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
    }
}


