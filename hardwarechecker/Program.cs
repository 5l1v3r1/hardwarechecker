using hardwarechecker.Core;
using System;
using System.Windows.Forms;

namespace hardwarechecker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationContext context = new FormManager();
            Application.Run(context);
        }
    }
}
