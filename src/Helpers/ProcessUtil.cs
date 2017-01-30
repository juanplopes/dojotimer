using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Text;

namespace DojoTimer.Helpers
{
    public class ProcessUtil
    {
        public static bool IsLinux
        {
            get
            {
                int p = (int)Environment.OSVersion.Platform;
                return (p == 4) || (p == 6) || (p == 128);
            }
        }

        public static void KillProcessAndChildren(int processId)
        {
            var process = Process.GetProcessById(processId);

            try
            {
                process.Kill();

                if (IsLinux) return;

                var children = GetChildPrecesses(process.Id);
                foreach (var id in children)
                    KillProcessAndChildren(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static List<int> GetChildPrecesses(int parentId)
        {
            var query = "Select * From Win32_Process Where ParentProcessId = " + parentId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            var result = new List<int>();
            foreach (var p in processList)
                result.Add(Convert.ToInt32(p.GetPropertyValue("ProcessId")));
            return result;
        }
    }
}
