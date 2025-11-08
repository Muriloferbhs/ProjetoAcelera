using System;
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
            //Application.Run(new BaseForm());
            //Application.Run(new QuestoesForm());
            //Application.Run(new RankingForm());
        }
    }
}

