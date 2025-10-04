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

        //Murilo fez no dia 4/10 ----------------------------------------------------------------------------------
        public static bool AutenticarCPF(string cpf)
        {
            int decimoIdeal = 0;
            int onzeIdeal = 0;
            int total = 0;

            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                KryptonMessageBox.Show("Insira um CPF válido!");
                return false;
            }

            else
            {
                for (int i = 0; i < 9; i++)
                {
                    total += int.Parse(cpf[i].ToString()) * (10 - i);
                }
                int resto = total % 11;
                if (resto < 2)
                {
                    decimoIdeal = 0;
                }
                else
                {
                    decimoIdeal = 11 - resto;
                }
                total = 0;
                for (int i = 0; i < 10; i++)
                {
                    total += int.Parse(cpf[i].ToString()) * (11 - i);
                }
                resto = total % 11;
                if (resto < 2)
                {
                    onzeIdeal = 0;
                }
                else
                {
                    onzeIdeal = 11 - resto;
                }
                if (decimoIdeal == int.Parse(cpf[9].ToString()) && onzeIdeal == int.Parse(cpf[10].ToString()))
                {
                    return true;
                }
                else
                {
                    KryptonMessageBox.Show("Insira um CPF válido!");
                    return false;
                }
            }

        }             
        public static bool AutenticarEmail(string email)
        {
            if (!email.Contains("@"))
            {
                KryptonMessageBox.Show("Insira um Email válido!");
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool AutenticarTelefone(string telefone)
        {
            if (telefone.Length == 11 && telefone.All(char.IsDigit) || telefone.Length == 14 && telefone.All(char.IsDigit))
            {;
                return true;
            }
            else
            {
                KryptonMessageBox.Show("Insira um Telefone válido!");
                return false;
            }
        }
        //Murilo fez no dia 4/10 ----------------------------------------------------------------------------------

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
            foreach (Usuario u in Usuario.DadosDoCadastroLogin)
            {
                if (u.NomeUser == nomeUsuario && u.Senha == senha)
                {
                    KryptonMessageBox.Show("Login realizado com sucesso!");
                    return;
                }
            }
            KryptonMessageBox.Show("Username ou senha incorretos");
        }
        public void Desativar()
        {
            Ativo = false;
        }

    }
}
