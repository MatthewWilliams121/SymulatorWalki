using System;
using System.Windows.Forms;

namespace index
{
    internal static class Program
    {
        /// <summary>
        ///     Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var form = new MainForm();
            Application.Run(form);
        }
    }
}