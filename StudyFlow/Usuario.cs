using Krypton.Toolkit;
using System.Collections;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudyFlow
{
    internal class Usuario
    {
        public string NomeUser { get; set; }// parametro de login
        public string Nome { get; set; }
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

        public static void CadastrarUsuario(string nomeUsuario, string senha, Usuario novoUsuario)
        {
            int cont = 0;
            foreach (Usuario u in Usuario.DadosDoCadastroLogin)
            {
                if (u.NomeUser == nomeUsuario)
                {
                    cont++;
                }
            }

            if (cont == 0)
            {
                novoUsuario.AtribuirSenha(senha);
                novoUsuario.NomeUser = nomeUsuario;
                Usuario.DadosDoCadastroLogin.Add(novoUsuario);

                KryptonMessageBox.Show("Conta cadastrada com sucesso!");
            }
            else
            {
                KryptonMessageBox.Show("Conta ja está cadastrada!");
            }
        }

        public static void Logar(string username, string password)
        {
            int cont = 0;
            foreach (Usuario u in Usuario.DadosDoCadastroLogin)
            {
                if (u.NomeUser == username && u.Senha == password)
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
