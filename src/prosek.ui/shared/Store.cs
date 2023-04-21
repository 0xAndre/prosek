using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosek.ui.shared
{
    public static class Store
    {
        public static List<Process> processs = new List<Process>();

        public static void GetAllProcess()
        {
            var currentProcess = Process.GetProcesses().GroupBy(p => p.ProcessName).Select(g => g.First()).ToList();

            foreach (Process p in currentProcess)
            {
                try
                {
                    processs.Add(p);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
