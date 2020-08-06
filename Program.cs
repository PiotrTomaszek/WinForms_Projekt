using System;
using System.Windows.Forms;

namespace P4_Projekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Do zmiany na potrzeby testu

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm { StartPosition = FormStartPosition.CenterScreen });
        }
    }
}
