using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using DojoTimer.Keyboard;

namespace DojoTimer.Helpers
{
    public class ProcessRunner
    {
        string scriptText;
        string workingDir;
        int timeout;

        public ProcessRunner(string scriptText, string workingDir, int timeout)
        {
            this.scriptText = scriptText;
            this.workingDir = workingDir;
            this.timeout = timeout;
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
                var lines = scriptText.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < lines.Length; i++) lines[i] = "(" + lines[i] + ")";

                File.WriteAllText(file, String.Join(" && ", lines));

                var psi = MakeParams(file, args);
                var process = MakeProcess(psi);
                process.Start();
                if (Write != null)
                {
                    process.BeginErrorReadLine();
                    process.BeginOutputReadLine();
                }

                if (timeout > 0)
                {
                    if (!process.WaitForExit(timeout))
                    {
                        ProcessUtil.KillProcessAndChildren(process.Id);
                        InvokeWrite(string.Format("Error: process timeout ({0}ms)", timeout));
                    }
                }
                else
                {
                    process.WaitForExit();
                }

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
            string argStr = file + " ";
            foreach (var arg in args)
                argStr += string.Format("\"{0}\" ", arg);

            var psi = new ProcessStartInfo();
            if (ProcessUtil.IsLinux)
            {
                psi.FileName = "/bin/sh";
            }
            else
            {
                psi.FileName = "cmd";
                argStr = "/C " + argStr;
            }

            psi.UseShellExecute = false;
            psi.Arguments = argStr;
            psi.WorkingDirectory = workingDir;

            psi.RedirectStandardError = Write != null;
            psi.RedirectStandardOutput = Write != null;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            return psi;
        }

    }
}
