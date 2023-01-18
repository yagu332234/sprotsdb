using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memberDB
{
    static class Program
    {
        public static ApplicationContext mainPage;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainPage = new ApplicationContext();
            mainPage.MainForm = new StartScreen();
            Application.Run(mainPage);
        }
    }
}
