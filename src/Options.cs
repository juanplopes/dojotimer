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
        public string Script { get; set; }
        public Keys Shortcut { get; set; }
        public Keys ShortcutKey { get { return Shortcut & Keys.KeyCode; } }
        public ModifierKeys ShortcutModifiers
        {
            get
            {
                ModifierKeys mods = 0;
                if ((Shortcut & Keys.Alt) > 0) mods |= ModifierKeys.Alt;
                if ((Shortcut & Keys.Control) > 0) mods |= ModifierKeys.Control;
                if ((Shortcut & Keys.Shift) > 0) mods |= ModifierKeys.Shift;
                return mods;
            }
        }

        public Options()
        {
            Period = TimeSpan.FromMinutes(5);
            Shortcut = Keys.Control | Keys.Alt | Keys.M;
        }

        public event Action<string> Write;

        public bool Run()
        {
            var processes = Process.GetProcesses();

            if (Script == null) return true;

            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.FileName = Script;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.WorkingDirectory = Path.GetDirectoryName(Script);
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
