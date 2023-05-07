using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using prosek.application;
using prosek.models;
using prosek.ui.shared;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using prosek.application.exceptions;

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
                    processView.Nodes.Add($"({p.Id}) {p?.MainModule?.ModuleName}");
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
            FillTree();
        }

        private void processView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                string rawProcessId = processView.SelectedNode.Text.Split(" ")[0];
                int processId = int.Parse(rawProcessId.Substring(1, rawProcessId.Length - 2));
                var process = Process.GetProcessById(processId);
                string hash = Hash.SHA256CheckSum(process.MainModule?.FileName);

                string fileInfo = DataManager.GetVirusTotalFileData(hash, process.MainModule?.ModuleName);

                JObject jObject = JObject.Parse(fileInfo);
                var aR = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(jObject["data"]["attributes"]["last_analysis_results"].ToString());

                List<AnalysisResult> analysisResults = new List<AnalysisResult>();
                ListViewItem row = new ListViewItem();

                listViewDetection.View = View.Details;
                listViewDetection.Items.Clear();

                foreach (var key in aR.Keys)
                {
                    analysisResults.Add(aR[key].ToObject<AnalysisResult>());
                    AnalysisResult analysisResult = aR[key].ToObject<AnalysisResult>();

                    if (analysisResult.category != "type-unsupported")
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { analysisResult.engine_name, analysisResult.category });

                        if (analysisResult.category == "undetected")
                        {
                            lvi.SubItems[1].ForeColor = Color.Green;
                        }

                        if (analysisResult.category == "detected")
                        {
                            lvi.SubItems[1].ForeColor = Color.Red;

                        }

                        if (analysisResult.category == "failure")
                        {
                            lvi.SubItems[1].ForeColor = Color.Orange;

                        }


                        lvi.UseItemStyleForSubItems = false;
                        listViewDetection.Items.Add(lvi);
                    }
                }
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Process not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}