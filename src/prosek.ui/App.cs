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
        }

        private void App_Load(object sender, EventArgs e)
        {
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
        }

        private void processView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(processView.SelectedNode.Text);
        }
    }
}