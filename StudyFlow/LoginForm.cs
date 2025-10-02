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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


        private void LabelLogin_Click(object sender, EventArgs e)
        {

        }

        private void PanelDireita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonEntrar_Click(object sender, EventArgs e)
        {
            string NomeUsuario = TextBoxUsuario.Text.Trim();
            string Senha = TextBoxSenha.Text;

            if (string.IsNullOrEmpty(NomeUsuario))
            {
                MessageBox.Show("Digite o nome de usuário.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBoxUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(Senha))
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
            cadastro.ShowDialog();
        }

        private void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
