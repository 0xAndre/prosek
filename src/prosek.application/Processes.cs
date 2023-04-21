using prosek.models;
using System.Diagnostics;
using System.Management;

namespace prosek.application
{
    public class Processes
    {
        public Processes() { }

        public IEnumerable<Proc> GetAll()
        {
            Process[] currentProcess = Process.GetProcesses();

            foreach (Process p in currentProcess)
            {
                int processID = p.Id;
                Process? process = null;
                try
                {
                    process = Process.GetProcessById(processID);
                } 
                catch(Exception) {
                    continue;                
                }
                
                string path = ProcessExecutablePath(process);
                    
                if (!string.IsNullOrEmpty(path))
                {
                    yield return new Proc { Name = p.ProcessName, Id = p.Id, Path = path };
                }
            }
           
        }

        private string ProcessExecutablePath(Process process)
        {
            try
            {
                return process.MainModule.FileName;
            }
            catch
            {
                string query = "SELECT ExecutablePath, ProcessID FROM Win32_Process";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

                foreach (ManagementObject item in searcher.Get())
                {
                    object id = item["ProcessID"];
                    object path = item["ExecutablePath"];

                    if (path != null && id.ToString() == process.Id.ToString())
                    {
                        return path.ToString();
                    }
                }
            }

            return null;
        }
    }
}