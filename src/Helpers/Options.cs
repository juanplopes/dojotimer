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

namespace DojoTimer.Helpers
{
    [Serializable]
    public class Options
    {
        public TimeSpan Period { get; set; }
        public string Script { get; set; }
        public Keys Shortcut { get; set; }

        public bool KeepTrack { get; set; }
        public string[] Participants { get; set; }
        public string CommitScript { get; set; }

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
            CommitScript = string.Format("echo Dojo today with %1 and %2.", myDir);
            Participants = new string[0];
            WorkingDirectory = Environment.CurrentDirectory;
        }

        [field:NonSerialized]
        public event Action<string> Write;

        public bool Run()
        {
            var runner = new ProcessRunner(Script, WorkingDirectory);
            runner.Write += s => { if (Write != null) Write(s); };
            return runner.Run();
        }

        public static Options Load()
        {
            try
            {
                using (var stream = new IsolatedStorageFileStream(".options", FileMode.Open))
                    return (Options)new BinaryFormatter().Deserialize(stream);
            }
            catch { return new Options(); }
        }

        public void Save()
        {
            using (var stream = new IsolatedStorageFileStream(".options", FileMode.Create))
                new BinaryFormatter().Serialize(stream, this);
        }

        public void MarkFinish(bool commit, string person1, string person2)
        {
            if (commit)
                new ProcessRunner(CommitScript, WorkingDirectory).Run(person1, person2);

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
