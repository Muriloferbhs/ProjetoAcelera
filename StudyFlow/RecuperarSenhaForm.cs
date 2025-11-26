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

namespace StudyFlow {
    public partial class RecuperarSenhaForm : Form {
        public RecuperarSenhaForm() {
            InitializeComponent();
        }

        private void ButtonConfirmar_Click(object sender, EventArgs e) {



            string nomeCompleto_Recuperar = TextBoxNome.Text.Trim();
            string telefone_Recuperar = TextBoxTelefone.Text.Trim();
            string email_Recuperar = TextBoxEmail.Text.Trim();
            string cpf_Recuperar = TextBoxCpf.Text.Trim();

            if (string.IsNullOrEmpty(nomeCompleto_Recuperar) || string.IsNullOrEmpty(telefone_Recuperar) || string.IsNullOrEmpty(email_Recuperar) ||
                string.IsNullOrEmpty(cpf_Recuperar))
            {
                KryptonMessageBox.Show("Preencha todos os campos!", "Atenção");
                return;
            }


            foreach (Usuario u in Usuario.DadosDoCadastroLogin)
            {


                if (u.NomeCompleto == nomeCompleto_Recuperar && u.Telefone == telefone_Recuperar && u.Email == email_Recuperar && u.Cpf == cpf_Recuperar)
                {


                    RedefinirSenhaForm redefinirSenha = new RedefinirSenhaForm();
                    redefinirSenha.Show();
                    this.Hide();

                    Usuario.UsuarioSenhaEditada = u;

                    return;

                }


            }


            DialogResult resultado = MessageBox.Show(
                        "Dados não encontrados, deseja fazer cadastro?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
            if (resultado == DialogResult.Yes)
            {

                CadastroForm cadastro = new CadastroForm();
                cadastro.Show();
                this.Hide();

            }
            return;


















        }
    }
}
