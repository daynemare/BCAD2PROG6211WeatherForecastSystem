using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weatherForecastAppPOE
{
    static class Program
    {
        static string strt = Application.StartupPath;
        public static string conn = Path.GetFullPath(Path.Combine(strt, @"..\..\"));
        public static string connection = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + conn + @"DatabaseWFD.mdf;Integrated Security = True";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new SplashScreen());
        }
    }
}
