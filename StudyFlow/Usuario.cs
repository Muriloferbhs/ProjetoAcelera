using Krypton.Toolkit;
using System.Collections;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudyFlow
{
    internal class Usuario
    {
        public string NomeUser { get; set; }// parametro de login
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }// parametro de login
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string DataDeNascimento { get; set; }
        public string SenhaHash { get; private set; }//usar hash para senha ser segura
        public string Senha { get; set; } // apenas para teste
        public string Salt { get; private set; }// numero aleatorio para calcular o hash
        public bool Ativo { get; private set; } = true;// verificar se o usuario esta ativo

        public static ArrayList DadosDoCadastroLogin = new ArrayList();
        public void AtribuirSenha(string senha)
        {
            Senha = senha;
        }
        public Usuario()
        { }

        public void AtribuirDadosDoUsuario(string nomeCompleto, string cpf, string telefone, string email, string nomeUsuario, string senha)
        {
            NomeCompleto = nomeCompleto;
            NomeUser = nomeUsuario;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            AtribuirSenha(senha);
        }

        public static void Logar(string nomeUsuario, string senha)
        {
            int cont = 0;
            foreach (Usuario u in Usuario.DadosDoCadastroLogin)
            {
                if (u.NomeUser == nomeUsuario && u.Senha == senha)
                {
                    cont++;
                }
            }

            if (cont == 1)
            {
                KryptonMessageBox.Show("Login realizado com sucesso!");
            }
            else
            {
                KryptonMessageBox.Show("Username ou senha incorretos");
            }
        }
        public void Desativar()
        {
            Ativo = false;
        }

    }
}
