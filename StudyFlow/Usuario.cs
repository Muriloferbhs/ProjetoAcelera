using BCrypt.Net;//para usar hash
using Krypton.Toolkit;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Collections;
using System.Text.Json;
using System.Text.Json;
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





        public static ArrayList DadosDoCadastroLogin = new ArrayList();


        public static Usuario UsuarioLogado { get; set; }

        public static Dictionary<string, bool> AcertouOuErrou { get; } = new Dictionary<string, bool>();
        public static void MarcarComoCertaOuErrada(string ID, string respostaDada, string resposta)
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


        public static Dictionary<string, bool> QuestoesRespondidas { get; } = new Dictionary<string, bool>();
        public static void MarcarComoRespondida(string ID)
        {
            if (!QuestoesRespondidas.ContainsKey(ID))
                QuestoesRespondidas[ID] = true;
        }
        public static bool JaRespondeu(string ID)
        {
            return QuestoesRespondidas.ContainsKey(ID) && QuestoesRespondidas[ID];
        }


        public static Dictionary<string, int> ErrosPorQuestao { get; } = new Dictionary<string, int>();


        public static void SalvarErro(string ID)
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
            //carlos 04/10--------------------------------------------------------------------------------------------
            Senha = BCrypt.Net.BCrypt.HashPassword(senha);
        }







        //Murilo fez no dia 4/10 ----------------------------------------------------------------------------------
        //genial, não tinha pensado em validar assim (Henrique falando)
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
            {
                ;
                return true;
            }
            else
            {
                KryptonMessageBox.Show("Insira um Telefone válido!");
                return false;
            }
        }
        //Murilo fez no dia 4/10 ----------------------------------------------------------------------------------






        public static Usuario Logar(string dadosLogin, string senhaLogin)
        {



            foreach (Usuario u in Usuario.DadosDoCadastroLogin)
            {

                //carlos 04/10 (acresentar o parametro cpf pra login)---------------------------------------------------------------------
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
            KryptonMessageBox.Show("Username ou senha incorretos");
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
            double pontuacao = 2.0;
            bool ativoTeste = true;

            Usuario testeUsuario = new Usuario(nomeCompletoTeste, cpfTeste, telefoneTeste, emailTeste, nomeUsuarioTeste, senhaTeste, ativoTeste, pontuacao);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario);


            string nomeCompletoTeste1 = "Sarah Nunes de Prado";
            string cpfTeste1 = "96001338914";
            string telefoneTeste1 = "12996238886";
            string emailTeste1 = "sarahnunes@gmail.com";
            string nomeUsuarioTeste1 = "sarah";
            string senhaTeste1 = "SoDeusSabe";
            double pontuacao1 = 3.0;
            bool ativoTeste1 = false;

            Usuario testeUsuario1 = new Usuario(nomeCompletoTeste1, cpfTeste1, telefoneTeste1, emailTeste1, nomeUsuarioTeste1, senhaTeste1, ativoTeste1, pontuacao1);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario1);



            string nomeCompletoTeste2 = "Murilo";
            string cpfTeste2 = "08386379499";
            string telefoneTeste2 = "12996036493";
            string emailTeste2 = "murilo123@gmail.com";
            string nomeUsuarioTeste2 = "murilo";
            string senhaTeste2 = "murilo2006";
            double pontuacao2 = 3.0;
            bool ativoTeste2 = true;

            Usuario testeUsuario2 = new Usuario(nomeCompletoTeste2, cpfTeste2, telefoneTeste2, emailTeste2, nomeUsuarioTeste2, senhaTeste2, ativoTeste2, pontuacao2);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario2);


            string nomeCompletoTeste3 = "JMurilo";
            string cpfTeste3 = "36840918041";
            string telefoneTeste3 = "12996036499";
            string emailTeste3 = "murilo123@gmail.com";
            string nomeUsuarioTeste3 = "aa";
            string senhaTeste3 = "aa";
            double pontuacao3 = 10;
            bool ativoTeste3 = true;

            Usuario testeUsuario3 = new Usuario(nomeCompletoTeste3, cpfTeste3, telefoneTeste3, emailTeste3, nomeUsuarioTeste3, senhaTeste3, ativoTeste3, pontuacao3);
            Usuario.DadosDoCadastroLogin.Add(testeUsuario3);

        }








        public static void EditarUsuario(string? novoNome, string? novoTelefone, string? novoSobreMim) {


            foreach (Ranking r in Ranking.RankingGeral)
            {
                if (UsuarioLogado.NomeUser == r.NomeUserRanking)
                { r.NomeUserRanking = novoNome; }
            
            }

            if (!string.IsNullOrWhiteSpace(novoNome))
            UsuarioLogado.NomeUser = novoNome;

           

            if (!string.IsNullOrWhiteSpace(novoTelefone))
            UsuarioLogado.Telefone = novoTelefone;

            UsuarioLogado.TextoUser = novoSobreMim;

        }


        public static void Deslogar() {

            UsuarioLogado = null;
        }






















        public static void RecuperarSenha()
        {




        }







    }
}