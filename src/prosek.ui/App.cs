using prosek.application;
using prosek.models;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace prosek.ui
{
    public partial class App : Form
    {
        public delegate void FunctionDelegate();
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
            processView.BeginInvoke(new FunctionDelegate(FillTree));

        }

        private void FillTree()
        {
            Processes processes = new Processes();
            
            foreach (var proc in processes.GetAll())
            {
                processView.Nodes.Add(proc.Path);
                toolStripStatusLabel.Text = $"Processes ({processView.Nodes.Count})";
            }
           
        }

        private void App_Load(object sender, EventArgs e)
        {
            // var topNode = new TreeNode($"Processes ({processView.Nodes.Count})");
            // processView.Nodes.Add(topNode);
        }
    }
}