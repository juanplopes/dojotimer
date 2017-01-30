using System;
using System.Collections.Generic;

using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.IsolatedStorage;
using DojoTimer.Keyboard;

namespace DojoTimer.Helpers
{
    [Serializable]
    public class Options
    {
        public static readonly System.Drawing.Font DEFAULT_OUTPUT_FONT = 
            new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        public TimeSpan Period { get; set; }
        public string Script { get; set; }
        public Keys Shortcut { get; set; }

        public bool KeepTrack { get; set; }
        public bool UseSemaphore { get; set; }
        public string SemaphorePort { get; set; }
        public int SemaphoreBaudRate { get; set; }
        public char GreenSignalChar { get; set; }
        public char RedSignalChar { get; set; }
        public bool PlayAlarmSound { get; set; }
        public bool PlayTestResultSound { get; set; }
        public string[] Participants { get; set; }
        public string CommitScript { get; set; }
        public System.Drawing.Font Font { get; set; }
        public int TestTimeout { get; set; }
        public string WorkingDirectory { get; set; }

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
            Script = string.Format("echo There is no script.", myDir);
            KeepTrack = true;
            UseSemaphore = false;
            SemaphorePort = "COM12";
            GreenSignalChar = '2';
            RedSignalChar = '1';
            SemaphoreBaudRate = 9600;
            PlayAlarmSound = true;
            PlayTestResultSound = false;
            CommitScript = ProcessUtil.IsLinux ?
                "echo $(date) - $1 e $2 >> dojo.log" :
                "echo %date% %time% *** %~1 and %~2 >> dojo.log";
            Participants = new string[0];
            WorkingDirectory = Environment.CurrentDirectory;
            Font = DEFAULT_OUTPUT_FONT;
            TestTimeout = 2000;
        }

        [field:NonSerialized]
        public event Action<string> Write;

        public bool Run()
        {
            var runner = new ProcessRunner(Script, WorkingDirectory, TestTimeout);
            runner.Write += s => { if (Write != null) Write(s); };
            return runner.Run();
        }

        public static string ReferenceFile()
        {
            var path = Application.LocalUserAppDataPath;
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            return Path.Combine(path, ".options");
        }

        public static Options Load()
        {
            try
            {
                using (var stream = File.OpenRead(ReferenceFile()))
                    return (Options)new BinaryFormatter().Deserialize(stream);
            }
            catch { return new Options(); }
        }

        public void Save()
        {
            try
            {
                using (var stream = File.Create(ReferenceFile()))
                    new BinaryFormatter().Serialize(stream, this);
            }
            catch { }
        }

        public void MarkFinish(bool commit, string person1, string person2)
        {
            if (commit)
            {
                var runner = new ProcessRunner(CommitScript, WorkingDirectory, TestTimeout);
                var sb = new StringBuilder();
                runner.Write += x=>sb.AppendLine(x);

                if (!runner.Run(person1, person2))
                    MessageBox.Show("Commit failed.\n" + sb.ToString());
            }

            var list = new List<string>(Participants);
            list.RemoveAll(x => StringComparer.InvariantCultureIgnoreCase.Equals(x, person2));
            list.Add(person2);
            list.RemoveAll(x => StringComparer.InvariantCultureIgnoreCase.Equals(x, person1));
            list.Add(person1);

            list.RemoveAll(string.IsNullOrEmpty);

            Participants = list.ToArray();
        }


    }
}
