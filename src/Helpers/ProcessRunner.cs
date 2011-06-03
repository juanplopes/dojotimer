using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace DojoTimer.Helpers
{
    public class ProcessRunner
    {
        string scriptText;
        string workingDir;
        public ProcessRunner(string scriptText, string workingDir)
        {
            this.scriptText = scriptText;
            this.workingDir = workingDir;
        }
        public event Action<string> Write;
        public void InvokeWrite(string arg)
        {
            if (Write != null)
                Write(arg);
        }

        public bool Run(params string[] args)
        {
            var temp = Path.GetTempFileName();
            var file = temp + ".cmd";
            try
            {
                var script = scriptText.Replace("\r\n", "\r\n@if errorlevel 1 exit /b %errorlevel%\r\n");
                script = "@chcp 28591>NUL\r\n" + script;
                File.WriteAllText(file, script, Encoding.GetEncoding(28591));

                var processes = Process.GetProcesses();

                var psi = MakeParams(file, args);
                var process = MakeProcess(psi);
                process.Start();
                if (Write != null)
                {
                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();
                }

                process.WaitForExit();

                return process.ExitCode == 0;
            }
            catch (Exception e)
            {
                InvokeWrite(string.Format("Error: {0}", e.Message));
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
            process.OutputDataReceived += (obj, e) => { InvokeWrite(e.Data); };
            process.ErrorDataReceived += (obj, e) => { InvokeWrite(e.Data); };

            process.StartInfo = psi;
            return process;
        }

        private ProcessStartInfo MakeParams(string file, params string[] args)
        {
            string argStr = "";
            foreach (var arg in args)
                argStr += string.Format("\"{0}\" ", arg);

            var psi = new ProcessStartInfo();
            psi.UseShellExecute = false;
            psi.Arguments = argStr;
            psi.WorkingDirectory = workingDir;
            psi.FileName = file;
            psi.RedirectStandardError = Write != null;
            psi.RedirectStandardOutput = Write != null;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            return psi;
        }

    }
}
