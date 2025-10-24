using System;
using System.Windows.Forms;

namespace StudyFlow
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm()); // inicia pelo Login
            Application.Run(new BaseForm());
        }
    }
}

