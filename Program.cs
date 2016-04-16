using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mediaDownloader
{
    static class Program
    {

        public static Boolean isStandaloneMode = false;
        public static string versionCode = "1.6.0";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
               pluginInstance.createNewInstance();

        }
    }
}
