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

        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = txtBoxUsuario.Text.Trim();
            string senha = txtBoxSenha.Text.Trim();
            string confirmarSenha = txtBoxConfirmSenha.Text.Trim();

            if (string.IsNullOrEmpty(nomeUsuario) || string.IsNullOrEmpty(senha))
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

        private void TxtBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
