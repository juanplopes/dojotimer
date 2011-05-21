using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DojoTimer
{
    public class Options
    {
        public const string DefaultRunFile = "run.cmd";

        public TimeSpan Period { get; set; }
        public string WorkingDir { get; set; }

        public Options()
        {
            Period = TimeSpan.FromMinutes(5);
        }

        public event Action<string> Write;

        public bool Run()
        {
            var processes = Process.GetProcesses();

            if (WorkingDir == null) return true;

            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.FileName = Path.Combine(WorkingDir, DefaultRunFile);
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.WorkingDirectory = WorkingDir;
            var process = new Process();
            process.OutputDataReceived += (obj, e) => { if (Write != null) Write(e.Data); };
            process.ErrorDataReceived += (obj, e) => { if (Write != null) Write(e.Data); };

            process.StartInfo = psi;
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            
            process.WaitForExit();
            return process.ExitCode == 0;
        }

      
    }
}
