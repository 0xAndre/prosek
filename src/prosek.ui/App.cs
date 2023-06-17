using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using prosek.application;
using prosek.models;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using prosek.application.exceptions;
using System;
using System.Reflection;
using prosek.application.provider;
using prosek.application.provider.virustotal;

namespace prosek.ui
{
    public partial class App : Form
    {

        public App()
        {
            InitializeComponent();
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
            LoadProcesses();
        }

        private void LoadProcesses()
        {
            toolStripProgressBar.Visible = true;
            processView.Nodes.Clear();

            var currentProcess = Process.GetProcesses().GroupBy(p => p.ProcessName).Select(g => g.First()).ToList();

            int i = 0;

            processView.ImageList = imageList;

            imageList.Images.Add("dll", Image.FromFile($"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\\images\\dll.png"));

            foreach (Process p in currentProcess)
            {
                toolStripProgressBar.Value = ((i++ + 1) * 100 / currentProcess.Count);
                try
                {
                    Guid id = Guid.NewGuid();
                    processView.Nodes.Add(id.ToString(), $"({p.Id}) {p?.MainModule?.ModuleName}");

                    // add icons to list
                    imageList.Images.Add(p?.MainModule?.ModuleName, Icon.ExtractAssociatedIcon(p?.MainModule?.FileName));
                    processView.Nodes[processView.Nodes.Count - 1].ImageKey = p?.MainModule?.ModuleName;
                    processView.Nodes[processView.Nodes.Count - 1].SelectedImageKey = p?.MainModule?.ModuleName;

                    toolStripStatusLabel.Text = $"Prosek - Processes ({processView.Nodes.Count})";


                    foreach (ProcessModule dll in p.Modules)
                    {
                        if (!dll.FileName.ToUpper().Contains(".EXE"))
                        {
                            processView.Nodes[id.ToString()].Nodes.Add(dll.FileName);
                            var last = processView.Nodes[id.ToString()].Nodes[0];
                            last.ImageKey = "dll";
                            last.SelectedImageKey = "dll";
                        }

                    }
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
            LoadProcesses();
        }

        private void processView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Process process = null;
                string moduleName = null, fileName = null, id = null;
                IProvider virusTotal = new VirusTotalProvider();

                if (Utils.IsMainProcess(processView.SelectedNode.Text))
                {
                    string rawProcessId = processView.SelectedNode.Text.Split(" ")[0];
                    int processId = int.Parse(rawProcessId.Substring(1, rawProcessId.Length - 2));
                    process = Process.GetProcessById(processId);
                    fileName = process.MainModule?.FileName;
                    moduleName = process.MainModule?.ModuleName;
                    id = process.Id.ToString();

                    FillFileVersion(fileName);
                }
                else
                {
                    fileName = processView.SelectedNode.Text;
                    process = Process.GetProcessesByName(fileName).FirstOrDefault();
                    var moduleNameParsed = fileName.Split("\\");
                    moduleName = fileName.Split("\\")[moduleNameParsed.Length - 1];
                    id = "n/a";

                    FillFileVersion(fileName);

                }

                string hash = Hash.SHA256CheckSum(fileName);

                //Analysis fileInfo = virusTotal.GetProcessData(hash, moduleName);
                Analysis fileInfo = virusTotal.GetMockedProcessData();

                FillProcessDetails(id, moduleName, fileName, fileInfo);

                var analysisResults = fileInfo.data.attributes.last_analysis_results;


                //List<AnalysisResult> analysisResults = new List<AnalysisResult>();
                ListViewItem row = new ListViewItem();

                listViewDetection.View = View.Details;
                listViewDetection.Items.Clear();

                int undetectedVendors = 0, maliciousVendors = 0;


                foreach(var prop in analysisResults.GetType().GetProperties())
                {
                    object obj = prop.GetValue(analysisResults, null);

                    if(obj == null)
                    {
                        continue;
                    }

                    AnalysisResult analysisResult = JsonConvert.DeserializeObject<AnalysisResult>(JsonConvert.SerializeObject(obj));

                    if (analysisResult.category == "timeout")
                    {
                        continue;
                    }

                    if (analysisResult.category != "type-unsupported")
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { analysisResult.engine_name, analysisResult.category.ToUpper(), analysisResult.result });

                        if (analysisResult.category == "undetected")
                        {
                            lvi.SubItems[1].ForeColor = Color.Green;
                            undetectedVendors++;
                        }

                        if (analysisResult.category == "malicious")
                        {
                            lvi.SubItems[1].ForeColor = Color.Red;
                            lvi.SubItems[2].ForeColor = Color.Red;
                            maliciousVendors++;

                        }

                        if (analysisResult.category == "failure")
                        {
                            lvi.SubItems[1].ForeColor = Color.Orange;

                        }


                        lvi.UseItemStyleForSubItems = false;
                        listViewDetection.Items.Add(lvi);

                        lblStatusUndetected.Text = $"{undetectedVendors} vendors have not detected malware on this file";
                        lblStatusMalicious.Text = $"{maliciousVendors} vendors detected malware on this file";
                    }
                }
            }
            catch (NotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Process not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FillProcessDetails(string ProcesId, string ModuleName, string FileName, Analysis fileInfo)
        {
            lblProcessNameValue.Text = ModuleName;
            lblProcessPathValue.Text = FileName;
            lblProcessIdValue.Text = ProcesId;

            lblSHA256Value.Text = fileInfo.data.attributes.sha256.ToUpper();
            lblSHA1Value.Text = fileInfo.data.attributes.sha1.ToUpper();
            lblTypeValue.Text = fileInfo.data.attributes.type_description.ToUpper();
            lblTlshValue.Text = fileInfo.data.attributes.tlsh.ToUpper();
            lblVhashValue.Text = fileInfo.data.attributes.vhash.ToUpper();
            lblSizeValue.Text = Utils.SizeSuffix(Int64.Parse(fileInfo.data.attributes.size.ToString()));
        }

        private void FillFileVersion(string FileName)
        {
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(FileName);
            lblFileVersionValue.Text = fvi.FileVersion;
            lblDescriptionValue.Text = fvi.FileDescription;
            lblCompanyNameValue.Text = fvi.CompanyName;
            lblCopyrightValue.Text = fvi.LegalCopyright;
            lblOriginalFilenameValue.Text = fvi.OriginalFilename;
            lblLanguageValue.Text = fvi.Language;
            lblProductNameValue.Text = fvi.ProductName;
            lblProductVersionValue.Text = fvi.ProductVersion;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}