using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FoxForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Variables.create_main_form();
            Application.Run(Variables.main_form);
        }
    }
}
