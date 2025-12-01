using BCrypt.Net;//para usar hash
using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Collections;
using System.Text.Json;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudyFlow
{
    internal class Usuario
    {
        public string NomeUser { get; private set; }// parametro de login
        public string NomeCompleto { get; private set; }
        public string Cpf { get; private set; }// parametro de login
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; } // apenas para teste
        public bool Ativo { get; private set; } = true;// verificar se o usuario esta ativo
        public double Pontuacao { get; set; }
        public int PosiçãoRanking { get; set; } 
        public int Respondidas  { get; set; } 
        public int Acertos { get; set; }
        public string FotoPerfil { get; set; }//pensando em como fazer
        public string TextoUser { get; set; }
        public Image foto = Properties.Resources.abatar;




        public static ArrayList DadosDoCadastroLogin = new ArrayList();

       

        public static Usuario UsuarioLogado { get; set; }
       public static Usuario UsuarioSenhaEditada { get; set; }

        public Dictionary<string, bool> AcertouOuErrou { get; } = new Dictionary<string, bool>();
        public void MarcarComoCertaOuErrada(string ID, string respostaDada, string resposta)
        {
            if (respostaDada == resposta)
            {
                AcertouOuErrou[ID] = true;
            }
            else
            {
                AcertouOuErrou[ID] = false;
            }
        }


        public Dictionary<string, bool> QuestoesRespondidas { get; } = new Dictionary<string, bool>();
        public void MarcarComoRespondida(string ID)
        {
            if (!QuestoesRespondidas.ContainsKey(ID))
                QuestoesRespondidas[ID] = true;
        }
        public bool JaRespondeu(string ID)
        {
            return QuestoesRespondidas.ContainsKey(ID) && QuestoesRespondidas[ID];
        }


        public Dictionary<string, int> ErrosPorQuestao { get; } = new Dictionary<string, int>();


        public void SalvarErro(string ID)
        {
            if (!ErrosPorQuestao.ContainsKey(ID))
                ErrosPorQuestao[ID] = 0;

            if (ErrosPorQuestao.ContainsKey(ID))
                ErrosPorQuestao[ID]++;
        }


        public Usuario(string nomeCompleto, string cpf, string telefone, string email, string nomeUsuario, string senha, bool ativo, double pontuacao)
        {
            NomeCompleto = nomeCompleto;
            NomeUser = nomeUsuario;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Ativo = ativo;
            Pontuacao = pontuacao;
            AtribuirSenha(senha);
        }



        public void AtribuirSenha(string senha)
        {

            Senha = BCrypt.Net.BCrypt.HashPassword(senha);
        }


        public static bool AutenticarCPF(string cpf)
        {
            int decimoIdeal = 0;
            int onzeIdeal = 0;
            int total = 0;

            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                MessageBox.Show("Insira um CPF válido!");
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
                    MessageBox.Show("Insira um CPF válido!");
                    return false;
                }
            }

        }


        public static bool AutenticarEmail(string email)
        {
            if (!email.Contains("@"))
            {
                MessageBox.Show("Insira um Email válido!");
                return false;
            }
            else
            {
                return true;
            }
        }



        public static bool ValidarSenha(string senha) {

            // Pelo menos uma letra maiúscula
            if (!senha.Any(char.IsUpper))
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra MAIÚSCULA.");
                return false;
            }

            // Pelo menos uma letra minúscula
            if (!senha.Any(char.IsLower))
            {
                MessageBox.Show("A senha deve conter pelo menos uma letra minúscula.");
                return false;
            }

            // Pelo menos um número
            if (!senha.Any(char.IsDigit))
            {
                MessageBox.Show("A senha deve conter pelo menos um número.");
                return false;
            }

            // Pelo menos um caractere especial
            string especiais = "!@#$%^&*()-_=+[]{};:,.<>/?|";
            if (!senha.Any(c => especiais.Contains(c)))
            {
                MessageBox.Show("A senha deve conter pelo menos um caractere especial.");
                return false;
            }

            // Tamanho mínimo  
            if (senha.Length < 8)
            {
                MessageBox.Show("A senha deve ter no mínimo 8 caracteres.");
                return false;
            }

            return true;

        }


        public static bool AutenticarTelefone(string telefone)
        {
            if (telefone.Length == 11 && telefone.All(char.IsDigit) || telefone.Length == 14 && telefone.All(char.IsDigit))
            {
                ;
                return true;
            }
            else
            {
                MessageBox.Show("Insira um Telefone válido!");
                return false;
            }
        }

        public static Usuario Logar(string dadosLogin, string senhaLogin)
        {



            foreach (Usuario u in Usuario.DadosDoCadastroLogin)
            {

                if ((u.NomeUser == dadosLogin || u.Cpf == dadosLogin) && BCrypt.Net.BCrypt.Verify(senhaLogin, u.Senha) == true && u.Ativo == true)
                {


                    Usuario.UsuarioLogado = u;
                    return u;


                }
                else if ((u.NomeUser == dadosLogin || u.Cpf == dadosLogin) && BCrypt.Net.BCrypt.Verify(senhaLogin, u.Senha) == true && u.Ativo == false)
                {
                    DialogResult resultado = MessageBox.Show(
                        "Este usuário está desativado. Deseja reativá-lo?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        bool ativar = true;//caso queira ativar
                        Usuario.DesativarAtivarUser(ativar, u);
                    }



                    return null;
                }



            }
            MessageBox.Show("Username ou senha incorretos");
            return null;
        }

        public static Usuario DesativarAtivarUser(bool ativo, Usuario u)
        {

            if (ativo == true)
            {
                u.Ativo = true;
                return u;
            }
            else
            {
                u.Ativo = false;
                return u;
            }
        }

        public static void UsuariosDeTeste()
        {

            string nomeCompletoTeste = "Carlos Henrique dos Santos Pelegrini Duarte";
            string cpfTeste = "52998224725";
            string telefoneTeste = "12991545412";
            string emailTeste = "ricksz@gmail.com";
            string nomeUsuarioTeste = "rick";
            string senhaTeste = "2011";
            double pontuacao = 980; // topo
            bool ativoTeste = true;
            //Image foto = 

            string nomeCompletoTeste1 = "Sarah Nunes de Prado";
            string cpfTeste1 = "96001338914";
            string telefoneTeste1 = "12996238886";
            string emailTeste1 = "sarahnunes@gmail.com";
            string nomeUsuarioTeste1 = "sarah";
            string senhaTeste1 = "SoDeusSabe";
            double pontuacao1 = 950; // topo
            bool ativoTeste1 = false;

            string nomeCompletoTeste2 = "Murilo";
            string cpfTeste2 = "08386379499";
            string telefoneTeste2 = "12996036493";
            string emailTeste2 = "murilo123@gmail.com";
            string nomeUsuarioTeste2 = "murilo";
            string senhaTeste2 = "murilo2006";
            double pontuacao2 = 920; // topo
            bool ativoTeste2 = true;

            string nomeCompletoTeste3 = "JMurilo";
            string cpfTeste3 = "36840918041";
            string telefoneTeste3 = "12996036499";
            string emailTeste3 = "murilo123@gmail.com";
            string nomeUsuarioTeste3 = "Luiz Felipe";
            string senhaTeste3 = "aa";
            double pontuacao3 = 910; // topo
            bool ativoTeste3 = true;

            string nomeCompletoTeste4 = "Rafael Gomes de Souza";
            string cpfTeste4 = "50937642811";
            string telefoneTeste4 = "21974785522";
            string emailTeste4 = "rafael.souza@test.com";
            string nomeUsuarioTeste4 = "rafaels";
            string senhaTeste4 = "RafaSenha99";
            double pontuacao4 = 750;
            bool ativoTeste4 = true;

            string nomeCompletoTeste5 = "Beatriz Lima Fernandes";
            string cpfTeste5 = "16259387006";
            string telefoneTeste5 = "11987543390";
            string emailTeste5 = "beatriz.fernandes@test.com";
            string nomeUsuarioTeste5 = "biaf";
            string senhaTeste5 = "Bea@123456";
            double pontuacao5 = 680;
            bool ativoTeste5 = true;

            string nomeCompletoTeste6 = "Fernando Rocha Matos";
            string cpfTeste6 = "79031624583";
            string telefoneTeste6 = "31994451236";
            string emailTeste6 = "fernando.matos@test.com";
            string nomeUsuarioTeste6 = "fernandom";
            string senhaTeste6 = "F3rn4ndo!";
            double pontuacao6 = 720;
            bool ativoTeste6 = false;

            string nomeCompletoTeste7 = "Aline Santos Ribeiro";
            string cpfTeste7 = "25490873170";
            string telefoneTeste7 = "21988997766";
            string emailTeste7 = "aline.ribeiro@test.com";
            string nomeUsuarioTeste7 = "aliner";
            string senhaTeste7 = "Aline2025#";
            double pontuacao7 = 690;
            bool ativoTeste7 = true;

            string nomeCompletoTeste8 = "Gustavo Barros Oliveira";
            string cpfTeste8 = "39048125791";
            string telefoneTeste8 = "12996001234";
            string emailTeste8 = "gustavo.oliveira@test.com";
            string nomeUsuarioTeste8 = "gustavob";
            string senhaTeste8 = "Gust@vo321";
            double pontuacao8 = 710;
            bool ativoTeste8 = false;

        



            Usuario testeUsuario0 = new Usuario(nomeCompletoTeste, cpfTeste, telefoneTeste, emailTeste, nomeUsuarioTeste, senhaTeste, ativoTeste, pontuacao);
            Usuario testeUsuario1 = new Usuario(nomeCompletoTeste1, cpfTeste1, telefoneTeste1, emailTeste1, nomeUsuarioTeste1, senhaTeste1, ativoTeste1, pontuacao1);
            Usuario testeUsuario2 = new Usuario(nomeCompletoTeste2, cpfTeste2, telefoneTeste2, emailTeste2, nomeUsuarioTeste2, senhaTeste2, ativoTeste2, pontuacao2);
            Usuario testeUsuario3 = new Usuario(nomeCompletoTeste3, cpfTeste3, telefoneTeste3, emailTeste3, nomeUsuarioTeste3, senhaTeste3, ativoTeste3, pontuacao3);
            Usuario testeUsuario4 = new Usuario(nomeCompletoTeste4, cpfTeste4, telefoneTeste4, emailTeste4, nomeUsuarioTeste4, senhaTeste4, ativoTeste4, pontuacao4);
            Usuario testeUsuario5 = new Usuario(nomeCompletoTeste5, cpfTeste5, telefoneTeste5, emailTeste5, nomeUsuarioTeste5, senhaTeste5, ativoTeste5, pontuacao5);
            Usuario testeUsuario6 = new Usuario(nomeCompletoTeste6, cpfTeste6, telefoneTeste6, emailTeste6, nomeUsuarioTeste6, senhaTeste6, ativoTeste6, pontuacao6);
            Usuario testeUsuario7 = new Usuario(nomeCompletoTeste7, cpfTeste7, telefoneTeste7, emailTeste7, nomeUsuarioTeste7, senhaTeste7, ativoTeste7, pontuacao7);
            Usuario testeUsuario8 = new Usuario(nomeCompletoTeste8, cpfTeste8, telefoneTeste8, emailTeste8, nomeUsuarioTeste8, senhaTeste8, ativoTeste8, pontuacao8);

            Usuario.DadosDoCadastroLogin.Add(testeUsuario0);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario1);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario2);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario3);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario4);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario5);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario6);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario7);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario8);


        }

        public static void EditarUsuario(string? novoNome, string? novoTelefone, string? novoSobreMim, string? novoEmail) {


            foreach (Ranking r in Ranking.RankingGeral)
            {
                if (UsuarioLogado.NomeUser == r.NomeUserRanking)
                { r.NomeUserRanking = novoNome; }
            
            }

            if (!string.IsNullOrWhiteSpace(novoNome))
            UsuarioLogado.NomeUser = novoNome;

            if (AutenticarEmail(novoEmail) && !string.IsNullOrWhiteSpace(novoEmail))
                UsuarioLogado.Email = novoEmail;




            if (AutenticarTelefone(novoTelefone) == true)
                UsuarioLogado.Telefone = novoTelefone;
            else { UsuarioLogado.Telefone = UsuarioLogado.Telefone; }

            UsuarioLogado.TextoUser = novoSobreMim;

        }


        public static void Deslogar() {

            UsuarioLogado = null;
        }

        public static void RedefinirSenhaSenha(string novaSenha)
        {

            UsuarioSenhaEditada.AtribuirSenha(novaSenha);

            return;

        }

    }
}