using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace StudyFlow
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            
            Usuario.UsuariosDeTeste();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm()); // inicia pelo Login
            //Application.Run(new RedefinirSenhaForm());
            //Application.Run(new BaseForm());
            //Application.Run(new QuestoesForm());
            //Application.Run(new RankingForm());
            //Application.Run(new ResolucoesForm());
            //Application.Run(new HomeForm());
            //Application.Run(new PopupForm());
        }
    }
}

