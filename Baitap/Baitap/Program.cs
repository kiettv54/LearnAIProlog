using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SbsSW.SwiPlCs; //thu vien ket noi prolog
using NUnit.Framework;
using System.Text.RegularExpressions;
namespace Baitap
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files\swipl");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!PlEngine.IsInitialized)
            {
                String[] empty_param = { "" };
                PlEngine.Initialize(empty_param);
                Application.Run(new Form1());
                PlEngine.PlCleanup();
            }
        }
    }
}
