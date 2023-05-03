using prosek.application;
using prosek.models;
using prosek.ui.shared;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace prosek.ui
{
    public partial class App : Form
    {

        public App()
        {
            InitializeComponent();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        private void splitContainer1_SplitterMoved_1(object sender, SplitterEventArgs e)
        {

        }

        private void toolMenuPlay_Click(object sender, EventArgs e)
        {
            FillTree();
        }

        private void FillTree()
        {
            toolStripProgressBar.Visible = true;
            processView.Nodes.Clear();

            var currentProcess = Process.GetProcesses().GroupBy(p => p.ProcessName).Select(g => g.First()).ToList();

            int i = 0;

            foreach (Process p in currentProcess)
            {
                toolStripProgressBar.Value = ((i++ + 1) * 100 / currentProcess.Count);
                try
                {
                    processView.Nodes.Add($"({p.Id}) {p?.MainModule?.FileName}");
                    toolStripStatusLabel.Text = $"Prosek - Processes ({processView.Nodes.Count})";
                }
                catch (Exception)
                {
                    continue;
                }
            }

            toolStripProgressBar.Visible = false;
        }

        private void App_Load(object sender, EventArgs e)
        {
            toolStripProgressBar.Visible = true;

            int i = 0;

            foreach (Process p in Store.processs)
            {
                toolStripProgressBar.Value = ((i++ + 1) * 100 / Store.processs.Count);
                try
                {
                    processView.Nodes.Add($"({p.Id}) {p?.MainModule?.FileName}");
                    toolStripStatusLabel.Text = $"Prosek - Processes ({processView.Nodes.Count})";
                }
                catch (Exception)
                {
                    continue;
                }
            }

            toolStripProgressBar.Visible = false;
        }

        private void processView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(processView.SelectedNode.Text);
            string rawProcessId = processView.SelectedNode.Text.Split(" ")[0];
            int processId = int.Parse(rawProcessId.Substring(1, rawProcessId.Length - 2));
            var process = Process.GetProcessById(processId);
            string hash = Hash.SHA256CheckSum(process.MainModule?.FileName);

            DataManager.GetVirusTotalFileData(hash);
        }
    }
}