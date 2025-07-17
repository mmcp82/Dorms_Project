using Dorms_Project.Services.DatabaseSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dorms_Project
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQL_Database_Setup sQL_Database_Setup = new SQL_Database_Setup();
            sQL_Database_Setup.InitializeDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Management_Form());
        }
    }
}
