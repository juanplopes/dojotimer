using System;
using System.Collections.Generic;

using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;

namespace DojoTimer
{
    public class Options
    {
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
            Shortcut = Keys.Control | Keys.Space;
            var myDir = Environment.CurrentDirectory;
            Script = string.Format("@cd /D \"{0}\"\r\n@echo There is no script.", myDir);
        }

        public event Action<string> Write;

        public bool Run()
        {
            var temp = Path.GetTempFileName();
            var file = temp + ".cmd";
            try
            {

                var script = Script.Replace("\r\n", "\r\n@if errorlevel 1 exit /b %errorlevel%\r\n");
                script = "@chcp 28591\r\n" + script;
                File.WriteAllText(file, script, Encoding.GetEncoding(28591));

                var processes = Process.GetProcesses();

                var psi = MakeParams(file);
                var process = MakeProcess(psi);
                process.Start();
                process.BeginErrorReadLine();
                process.BeginOutputReadLine();

                process.WaitForExit();

                return process.ExitCode == 0;
            }
            catch (Exception e)
            {
                Write(string.Format("Error: {0}", e.Message));
                return false;
            }
            finally
            {
                File.Delete(temp);
                File.Delete(file);
            }
        }

        private Process MakeProcess(ProcessStartInfo psi)
        {
            var process = new Process();
            process.OutputDataReceived += (obj, e) => { if (Write != null) Write(e.Data); };
            process.ErrorDataReceived += (obj, e) => { if (Write != null) Write(e.Data); };

            process.StartInfo = psi;
            return process;
        }

        private static ProcessStartInfo MakeParams(string file)
        {
            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.FileName = file;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            return psi;
        }


    }
}
