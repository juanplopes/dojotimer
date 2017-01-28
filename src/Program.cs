using System;
using System.Collections.Generic;

using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace DojoTimer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            var path = args.Length > 0 ? Path.GetFullPath(args[0]) : null;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(path));
			
        }
    }
}
