using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotPytato.UI.Windows;

namespace HotPytato
{
    static class HotPytatoWindowsUI
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            HotPytato.HotPytatoBackend.Init();
            Application.Run(new MainWindow());
        }
    }
}
