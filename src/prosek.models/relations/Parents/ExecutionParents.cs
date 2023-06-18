using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosek.models.relations.Parents
{
    public class Acronis
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AhnLabV3
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Alibaba
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ALYac
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AntiyAVL
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class APEX
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Arcabit
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Attributes
    {
        public string type_description { get; set; }
        public string tlsh { get; set; }
        public string vhash { get; set; }
        public List<string> type_tags { get; set; }
        public List<string> names { get; set; }
        public int last_modification_date { get; set; }
        public string type_tag { get; set; }
        public int times_submitted { get; set; }
        public TotalVotes total_votes { get; set; }
        public int size { get; set; }
        public string type_extension { get; set; }
        public int last_submission_date { get; set; }
        public List<Trid> trid { get; set; }
        public string sha256 { get; set; }
        public List<string> tags { get; set; }
        public int last_analysis_date { get; set; }
        public int unique_sources { get; set; }
        public int first_submission_date { get; set; }
        public string ssdeep { get; set; }
        public BundleInfo bundle_info { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string magic { get; set; }
        public LastAnalysisStats last_analysis_stats { get; set; }
        public string meaningful_name { get; set; }
        public int reputation { get; set; }
        public List<SigmaAnalysisResult> sigma_analysis_results { get; set; }
        public SigmaAnalysisSummary sigma_analysis_summary { get; set; }
        public SandboxVerdicts sandbox_verdicts { get; set; }
        public SigmaAnalysisStats sigma_analysis_stats { get; set; }
    }

    public class Avast
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AvastMobile
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AVG
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Avira
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Baidu
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class BitDefender
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class BitDefenderFalx
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class BitDefenderTheta
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Bkav
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class BundleInfo
    {
        public string highest_datetime { get; set; }
        public string lowest_datetime { get; set; }
        public int num_children { get; set; }
        public Extensions extensions { get; set; }
        public FileTypes file_types { get; set; }
        public string type { get; set; }
        public int uncompressed_size { get; set; }
    }

    public class CATQuickHeal
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ClamAV
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class CMC
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class CrowdStrike
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public object engine_update { get; set; }
    }

    public class Cybereason
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Cylance
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Cynet
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Cyren
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Datum
    {
        public Attributes attributes { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public Links links { get; set; }
    }

    public class DeepInstinct
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class DrWeb
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Elastic
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Emsisoft
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ESETNOD32
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Extensions
    {
        public int EXE { get; set; }
        public int Exe { get; set; }
        public int exe { get; set; }
        public int? mfl { get; set; }
        public int? jpg { get; set; }
        public int? ins { get; set; }
        public int? ini { get; set; }
        public int? ps1 { get; set; }
        public int? prx { get; set; }
        public int? inc { get; set; }
        public int? xml { get; set; }
        public int? wmz { get; set; }
        public int? txt { get; set; }
        public int? ico { get; set; }
        public int? dll { get; set; }
        public int? mui { get; set; }

        [JsonProperty("0/")]
        public int? _0 { get; set; }
        public int? bin { get; set; }
        public int? rll { get; set; }
        public int? DLL { get; set; }
        public int? mof { get; set; }
        public int? png { get; set; }
        public int? md { get; set; }
        public int? bat { get; set; }
        public int? vbs { get; set; }
        public int? tlb { get; set; }

        [JsonProperty("5/")]
        public int? _5 { get; set; }

        [JsonProperty("3/")]
        public int? _3 { get; set; }
        public int? xsd { get; set; }
        public int? com { get; set; }

        [JsonProperty("1/")]
        public int? _1 { get; set; }
    }

    public class FileTypes
    {
        public int directory { get; set; }

        [JsonProperty("Portable Executable")]
        public int PortableExecutable { get; set; }
        public int? JSON { get; set; }
        public int? XML { get; set; }
        public int? ZIP { get; set; }
        public int? unknown { get; set; }
        public int? JPG { get; set; }
        public int? PNG { get; set; }
    }

    public class FireEye
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Fortinet
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class FSecure
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class GData
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Google
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Gridinsoft
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Ikarus
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Jiangmin
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class K7AntiVirus
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class K7GW
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Kaspersky
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Kingsoft
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class LastAnalysisResults
    {
        public Bkav Bkav { get; set; }
        public Lionic Lionic { get; set; }
        public Elastic Elastic { get; set; }
        public DrWeb DrWeb { get; set; }

        [JsonProperty("MicroWorld-eScan")]
        public MicroWorldEScan MicroWorldeScan { get; set; }
        public CMC CMC { get; set; }

        [JsonProperty("CAT-QuickHeal")]
        public CATQuickHeal CATQuickHeal { get; set; }
        public McAfee McAfee { get; set; }
        public ALYac ALYac { get; set; }
        public Malwarebytes Malwarebytes { get; set; }
        public VIPRE VIPRE { get; set; }
        public Paloalto Paloalto { get; set; }
        public Sangfor Sangfor { get; set; }
        public Trustlook Trustlook { get; set; }
        public Alibaba Alibaba { get; set; }
        public K7GW K7GW { get; set; }
        public K7AntiVirus K7AntiVirus { get; set; }
        public BitDefenderTheta BitDefenderTheta { get; set; }
        public VirIT VirIT { get; set; }
        public Cyren Cyren { get; set; }
        public SymantecMobileInsight SymantecMobileInsight { get; set; }
        public Symantec Symantec { get; set; }
        public Tehtris tehtris { get; set; }

        [JsonProperty("ESET-NOD32")]
        public ESETNOD32 ESETNOD32 { get; set; }
        public APEX APEX { get; set; }

        [JsonProperty("TrendMicro-HouseCall")]
        public TrendMicroHouseCall TrendMicroHouseCall { get; set; }
        public Avast Avast { get; set; }
        public ClamAV ClamAV { get; set; }
        public Kaspersky Kaspersky { get; set; }
        public BitDefender BitDefender { get; set; }

        [JsonProperty("NANO-Antivirus")]
        public NANOAntivirus NANOAntivirus { get; set; }
        public ViRobot ViRobot { get; set; }
        public Rising Rising { get; set; }
        public Cynet Cynet { get; set; }
        public TACHYON TACHYON { get; set; }
        public Sophos Sophos { get; set; }

        [JsonProperty("F-Secure")]
        public FSecure FSecure { get; set; }
        public Baidu Baidu { get; set; }
        public Zillya Zillya { get; set; }
        public TrendMicro TrendMicro { get; set; }

        [JsonProperty("McAfee-GW-Edition")]
        public McAfeeGWEdition McAfeeGWEdition { get; set; }
        public Trapmine Trapmine { get; set; }
        public FireEye FireEye { get; set; }
        public Emsisoft Emsisoft { get; set; }
        public Ikarus Ikarus { get; set; }
        public GData GData { get; set; }
        public Jiangmin Jiangmin { get; set; }
        public Webroot Webroot { get; set; }
        public Avira Avira { get; set; }

        [JsonProperty("Antiy-AVL")]
        public AntiyAVL AntiyAVL { get; set; }
        public Microsoft Microsoft { get; set; }
        public Gridinsoft Gridinsoft { get; set; }
        public Xcitium Xcitium { get; set; }
        public Arcabit Arcabit { get; set; }
        public SUPERAntiSpyware SUPERAntiSpyware { get; set; }
        public ZoneAlarm ZoneAlarm { get; set; }

        [JsonProperty("Avast-Mobile")]
        public AvastMobile AvastMobile { get; set; }
        public Google Google { get; set; }
        public BitDefenderFalx BitDefenderFalx { get; set; }

        [JsonProperty("AhnLab-V3")]
        public AhnLabV3 AhnLabV3 { get; set; }
        public Acronis Acronis { get; set; }
        public VBA32 VBA32 { get; set; }
        public MAX MAX { get; set; }
        public Cylance Cylance { get; set; }
        public Panda Panda { get; set; }
        public Zoner Zoner { get; set; }
        public Tencent Tencent { get; set; }
        public Yandex Yandex { get; set; }
        public SentinelOne SentinelOne { get; set; }
        public MaxSecure MaxSecure { get; set; }
        public Fortinet Fortinet { get; set; }
        public AVG AVG { get; set; }
        public DeepInstinct DeepInstinct { get; set; }
        public CrowdStrike CrowdStrike { get; set; }
        public Kingsoft Kingsoft { get; set; }
        public Cybereason Cybereason { get; set; }
    }

    public class LastAnalysisStats
    {
        public int harmless { get; set; }

        [JsonProperty("type-unsupported")]
        public int typeunsupported { get; set; }
        public int suspicious { get; set; }

        [JsonProperty("confirmed-timeout")]
        public int confirmedtimeout { get; set; }
        public int timeout { get; set; }
        public int failure { get; set; }
        public int malicious { get; set; }
        public int undetected { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
    }

    public class Lionic
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Malwarebytes
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class MatchContext
    {
        public Values values { get; set; }
    }

    public class MAX
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class MaxSecure
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class McAfee
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class McAfeeGWEdition
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Meta
    {
        public int count { get; set; }
    }

    public class Microsoft
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class MicroWorldEScan
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class NANOAntivirus
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Paloalto
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Panda
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Rising
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ExecutionParents
    {
        public Meta meta { get; set; }
        public List<Datum> data { get; set; }
        public Links links { get; set; }
    }

    public class SandboxVerdicts
    {
        public Zenbox Zenbox { get; set; }

        [JsonProperty("Zenbox Linux")]
        public ZenboxLinux ZenboxLinux { get; set; }
    }

    public class Sangfor
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class SentinelOne
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class SigmaAnalysisResult
    {
        public string rule_title { get; set; }
        public string rule_source { get; set; }
        public List<MatchContext> match_context { get; set; }
        public string rule_level { get; set; }
        public string rule_description { get; set; }
        public string rule_author { get; set; }
        public string rule_id { get; set; }
    }

    public class SigmaAnalysisStats
    {
        public int high { get; set; }
        public int medium { get; set; }
        public int critical { get; set; }
        public int low { get; set; }
    }

    public class SigmaAnalysisSummary
    {
        [JsonProperty("Sigma Integrated Rule Set (GitHub)")]
        public SigmaIntegratedRuleSetGitHub SigmaIntegratedRuleSetGitHub { get; set; }

        [JsonProperty("SOC Prime Threat Detection Marketplace")]
        public SOCPrimeThreatDetectionMarketplace SOCPrimeThreatDetectionMarketplace { get; set; }
    }

    public class SigmaIntegratedRuleSetGitHub
    {
        public int high { get; set; }
        public int medium { get; set; }
        public int critical { get; set; }
        public int low { get; set; }
    }

    public class SOCPrimeThreatDetectionMarketplace
    {
        public int high { get; set; }
        public int medium { get; set; }
        public int critical { get; set; }
        public int low { get; set; }
    }

    public class Sophos
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class SUPERAntiSpyware
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Symantec
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class SymantecMobileInsight
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class TACHYON
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Tehtris
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public object engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Tencent
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class TotalVotes
    {
        public int harmless { get; set; }
        public int malicious { get; set; }
    }

    public class Trapmine
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class TrendMicro
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class TrendMicroHouseCall
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Trid
    {
        public string file_type { get; set; }
        public double probability { get; set; }
    }

    public class Trustlook
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Values
    {
        public string TerminalSessionId { get; set; }
        public string ProcessGuid { get; set; }
        public string ProcessId { get; set; }
        public string Product { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string ParentProcessGuid { get; set; }
        public string User { get; set; }
        public string Hashes { get; set; }
        public string OriginalFileName { get; set; }
        public string ParentImage { get; set; }
        public string FileVersion { get; set; }
        public string ParentProcessId { get; set; }
        public string CurrentDirectory { get; set; }
        public string CommandLine { get; set; }
        public string EventID { get; set; }
        public string LogonGuid { get; set; }
        public string LogonId { get; set; }
        public string Image { get; set; }
        public string IntegrityLevel { get; set; }
        public string ParentCommandLine { get; set; }
        public string UtcTime { get; set; }
        public string RuleName { get; set; }
        public string TargetFilename { get; set; }
        public string CreationUtcTime { get; set; }
    }

    public class VBA32
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class VIPRE
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class VirIT
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ViRobot
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Webroot
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Xcitium
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Yandex
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Zenbox
    {
        public string category { get; set; }
        public int confidence { get; set; }
        public string sandbox_name { get; set; }
        public List<string> malware_classification { get; set; }
    }

    public class ZenboxLinux
    {
        public string category { get; set; }
        public int confidence { get; set; }
        public string sandbox_name { get; set; }
        public List<string> malware_classification { get; set; }
    }

    public class Zillya
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ZoneAlarm
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Zoner
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }


}
