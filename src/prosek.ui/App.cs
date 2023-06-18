using Newtonsoft.Json;
using prosek.application;
using prosek.application.exceptions;
using prosek.application.provider;
using prosek.application.provider.virustotal;
using prosek.models.relations.Domains;
using prosek.models.relations.IPs;
using prosek.models.relations.Parents;
using prosek.models.relations.PE;
using prosek.models.relations.Process;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace prosek.ui
{
    public partial class App : Form
    {

        IProvider VirusTotal = new VirusTotalProvider();

        private string DefaultLoadingValue = "Loading...";

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

            StartLoadingFields();

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
                StartLoadingFields();
                Process process = null;
                string moduleName = null, fileName = null, id = null;

                if (Utils.IsMainProcess(processView.SelectedNode.Text))
                {
                    string rawProcessId = processView.SelectedNode.Text.Split(" ")[0];
                    int processId = int.Parse(rawProcessId.Substring(1, rawProcessId.Length - 2));
                    process = Process.GetProcessById(processId);
                    fileName = process.MainModule?.FileName;
                    moduleName = process.MainModule?.ModuleName;
                    id = process.Id.ToString();

                    FillFileAssemblyInfo(fileName);
                }
                else
                {
                    fileName = processView.SelectedNode.Text;
                    process = Process.GetProcessesByName(fileName).FirstOrDefault();
                    var moduleNameParsed = fileName.Split("\\");
                    moduleName = fileName.Split("\\")[moduleNameParsed.Length - 1];
                    id = "n/a";

                    FillFileAssemblyInfo(fileName);
                }

                string hash = Hash.SHA256CheckSum(fileName);

                Analysis fileInfo = this.VirusTotal.GetProcessData(hash, moduleName);

                GetRelations(hash);

                FillProcessDetails(id, moduleName, fileName, fileInfo);

                var analysisResults = fileInfo.data.attributes.last_analysis_results;

                listViewDetection.View = View.Details;
                listViewDetection.Items.Clear();

                int undetectedVendors = 0, maliciousVendors = 0;

                foreach (var prop in analysisResults.GetType().GetProperties())
                {
                    object obj = prop.GetValue(analysisResults, null);

                    if (obj == null)
                    {
                        continue;
                    }

                    AnalysisResult analysisResult = JsonConvert.DeserializeObject<AnalysisResult>(JsonConvert.SerializeObject(obj)) ?? throw new NotFoundException();

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

        private void FillFileAssemblyInfo(string FileName)
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

        private void GetRelations(string hash)
        {
            GetContactedIPs(hash);
            GetExecutionParents(hash);
            GetContactedDomains(hash);
            GetPEResourceChildren(hash);
        }

        private void GetContactedIPs(string hash)
        {
            ContactedIps contectedIps = this.VirusTotal.GetContactedIPsData(hash);

            lstViewContactedIps.View = View.Details;
            lstViewContactedIps.Items.Clear();

            foreach (var ip in contectedIps.data)
            {
                int totalAnalysis = ip.attributes.last_analysis_stats.malicious
                        + ip.attributes.last_analysis_stats.harmless
                        + ip.attributes.last_analysis_stats.undetected
                        + ip.attributes.last_analysis_stats.suspicious
                        + ip.attributes.last_analysis_stats.timeout;

                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(ip.attributes.last_analysis_date);
                DateTime lastAnalysisDate = dateTimeOffset.DateTime;

                ListViewItem lvi = new ListViewItem(new string[] { ip.id, $"{ip.attributes.last_analysis_stats.malicious}/{totalAnalysis}", ip.attributes.country, ip.attributes.as_owner, lastAnalysisDate.ToString() });

                lvi.UseItemStyleForSubItems = false;
                lstViewContactedIps.Items.Add(lvi);
            }
        }

        private void GetExecutionParents(string hash)
        {
            ExecutionParents executionParents = this.VirusTotal.GetExecutionParentsData(hash);

            lstViewExecutionParents.View = View.Details;
            lstViewExecutionParents.Items.Clear();

            foreach (var executionParent in executionParents.data)
            {
                int totalAnalysis = executionParent.attributes.last_analysis_stats.malicious
                        + executionParent.attributes.last_analysis_stats.harmless
                        + executionParent.attributes.last_analysis_stats.undetected
                        + executionParent.attributes.last_analysis_stats.suspicious
                        + executionParent.attributes.last_analysis_stats.timeout;

                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(executionParent.attributes.last_analysis_date);
                DateTime lastAnalysisDate = dateTimeOffset.DateTime;

                ListViewItem lvi = new ListViewItem(new string[] { lastAnalysisDate.ToString(), $"{executionParent.attributes.last_analysis_stats.malicious}/{totalAnalysis}", executionParent.attributes.type_extension, executionParent.attributes.meaningful_name });

                lvi.UseItemStyleForSubItems = false;
                lstViewExecutionParents.Items.Add(lvi);
            }
        }

        private void GetContactedDomains(string hash)
        {
            ContactedDomains contactedDomains = this.VirusTotal.GetContactedDomainsData(hash);

            lstViewContactedDomains.View = View.Details;
            lstViewContactedDomains.Items.Clear();

            foreach (var contactedDomain in contactedDomains.data)
            {
                int totalAnalysis = contactedDomain.attributes.last_analysis_stats.malicious
                        + contactedDomain.attributes.last_analysis_stats.harmless
                        + contactedDomain.attributes.last_analysis_stats.undetected
                        + contactedDomain.attributes.last_analysis_stats.suspicious
                        + contactedDomain.attributes.last_analysis_stats.timeout;

                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(contactedDomain.attributes.creation_date);
                DateTime creationDate = dateTimeOffset.DateTime;

                ListViewItem lvi = new ListViewItem(new string[] { contactedDomain.id, $"{contactedDomain.attributes.last_analysis_stats.malicious}/{totalAnalysis}", creationDate.ToString(), contactedDomain.attributes.registrar });

                lvi.UseItemStyleForSubItems = false;
                lstViewContactedDomains.Items.Add(lvi);
            }
        }

        private void GetPEResourceChildren(string hash)
        {
            PEResourceChildren peResourceChildrens = this.VirusTotal.GetPEResourceChildrenData(hash);

            lstViewPEResourceChildren.View = View.Details;
            lstViewPEResourceChildren.Items.Clear();

            foreach (var peResourceChildren in peResourceChildrens.data)
            {
                int totalAnalysis = peResourceChildren.attributes.last_analysis_stats.malicious
                        + peResourceChildren.attributes.last_analysis_stats.harmless
                        + peResourceChildren.attributes.last_analysis_stats.undetected
                        + peResourceChildren.attributes.last_analysis_stats.suspicious
                        + peResourceChildren.attributes.last_analysis_stats.timeout;

                DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(peResourceChildren.attributes.last_analysis_date);
                DateTime lastAnalysisDate = dateTimeOffset.DateTime;

                ListViewItem lvi = new ListViewItem(new string[] { lastAnalysisDate.ToString(), $"{peResourceChildren.attributes.last_analysis_stats.malicious}/{totalAnalysis}", peResourceChildren.attributes.type_extension, peResourceChildren.attributes.sha256 });

                lvi.UseItemStyleForSubItems = false;
                lstViewPEResourceChildren.Items.Add(lvi);
            }
        }

        private void StartLoadingFields()
        {
            lblProcessNameValue.Text = this.DefaultLoadingValue;
            lblProcessPathValue.Text = this.DefaultLoadingValue;
            lblProcessIdValue.Text = this.DefaultLoadingValue;

            lblSHA256Value.Text = this.DefaultLoadingValue;
            lblSHA1Value.Text = this.DefaultLoadingValue;
            lblTypeValue.Text = this.DefaultLoadingValue;
            lblTlshValue.Text = this.DefaultLoadingValue;
            lblVhashValue.Text = this.DefaultLoadingValue;
            lblSizeValue.Text = this.DefaultLoadingValue;

            lblFileVersionValue.Text = this.DefaultLoadingValue;
            lblDescriptionValue.Text = this.DefaultLoadingValue;
            lblCompanyNameValue.Text = this.DefaultLoadingValue;
            lblCopyrightValue.Text = this.DefaultLoadingValue;
            lblOriginalFilenameValue.Text = this.DefaultLoadingValue;
            lblLanguageValue.Text = this.DefaultLoadingValue;
            lblProductNameValue.Text = this.DefaultLoadingValue;
            lblProductVersionValue.Text = this.DefaultLoadingValue;

            lblStatusUndetected.Text = $"0 vendors have not detected malware on this file";
            lblStatusMalicious.Text = $"0 vendors detected malware on this file";

            ListViewItem lvi = new ListViewItem(new string[] { this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue });
            lvi.UseItemStyleForSubItems = false;
            listViewDetection.Items.Clear();
            listViewDetection.Items.Add(lvi);

            lvi = new ListViewItem(new string[] { this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue });
            lvi.UseItemStyleForSubItems = false;
            lstViewContactedIps.Items.Clear();
            lstViewContactedIps.Items.Add(lvi);

            lvi = new ListViewItem(new string[] { this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue });
            lvi.UseItemStyleForSubItems = false;
            lstViewExecutionParents.Items.Clear();
            lstViewExecutionParents.Items.Add(lvi);

            lvi = new ListViewItem(new string[] { this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue });
            lvi.UseItemStyleForSubItems = false;
            lstViewContactedDomains.Items.Clear();
            lstViewContactedDomains.Items.Add(lvi);

            lvi = new ListViewItem(new string[] { this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue, this.DefaultLoadingValue });
            lvi.UseItemStyleForSubItems = false;
            lstViewPEResourceChildren.Items.Clear();
            lstViewPEResourceChildren.Items.Add(lvi);
        }
    }
}