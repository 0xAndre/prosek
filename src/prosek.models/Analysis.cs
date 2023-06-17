using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosek.models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Acronis
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Activities
    {
        [JsonProperty("com.soft.common.Main")]
        public ComSoftCommonMain comsoftcommonMain { get; set; }
    }

    public class AhnLabV3
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AlertContext
    {
        public string dest_ip { get; set; }
        public int dest_port { get; set; }
        public string src_ip { get; set; }
        public int? src_port { get; set; }
        public string url { get; set; }
        public string hostname { get; set; }
    }

    public class Alibaba
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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

    public class Androguard
    {
        public List<string> Activities { get; set; }
        public string AndroidVersionCode { get; set; }
        public string main_activity { get; set; }
        public Certificate certificate { get; set; }
        public double VTAndroidInfo { get; set; }
        public string Package { get; set; }
        public IntentFilters intent_filters { get; set; }
        public PermissionDetails permission_details { get; set; }
        public int AndroidApplication { get; set; }
        public bool AndroidApplicationError { get; set; }
        public string AndroidVersionName { get; set; }
        public RiskIndicator RiskIndicator { get; set; }
        public string MinSdkVersion { get; set; }
        public string TargetSdkVersion { get; set; }
        public string AndroguardVersion { get; set; }
        public string AndroidApplicationInfo { get; set; }
    }

    public class AndroidPermissionINTERNET
    {
        public string short_description { get; set; }
        public string full_description { get; set; }
        public string permission_type { get; set; }
    }

    public class AndroidPermissionREADPHONESTATE
    {
        public string short_description { get; set; }
        public string full_description { get; set; }
        public string permission_type { get; set; }
    }

    public class AndroidPermissionSENDSMS
    {
        public string short_description { get; set; }
        public string full_description { get; set; }
        public string permission_type { get; set; }
    }

    public class AndroidPermissionWRITEEXTERNALSTORAGE
    {
        public string short_description { get; set; }
        public string full_description { get; set; }
        public string permission_type { get; set; }
    }

    public class AntiyAVL
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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

    public class APK
    {
        public int DEX { get; set; }
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
        public PopularThreatClassification popular_threat_classification { get; set; }
        public int last_submission_date { get; set; }
        public string meaningful_name { get; set; }
        public CrowdsourcedIdsStats crowdsourced_ids_stats { get; set; }
        public List<Trid> trid { get; set; }
        public SandboxVerdicts sandbox_verdicts { get; set; }
        public string sha256 { get; set; }
        public string type_extension { get; set; }
        public List<string> tags { get; set; }
        public List<CrowdsourcedIdsResult> crowdsourced_ids_results { get; set; }
        public int last_analysis_date { get; set; }
        public int unique_sources { get; set; }
        public int first_submission_date { get; set; }
        public string sha1 { get; set; }
        public string ssdeep { get; set; }
        public BundleInfo bundle_info { get; set; }
        public Packers packers { get; set; }
        public string md5 { get; set; }
        public Androguard androguard { get; set; }
        public string magic { get; set; }
        public LastAnalysisStats last_analysis_stats { get; set; }
        public LastAnalysisResults last_analysis_results { get; set; }
        public int reputation { get; set; }
    }

    public class Avast
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AvastMobile
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AVG
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Avira
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Certificate
    {
        public Subject Subject { get; set; }
        public string validto { get; set; }
        public string serialnumber { get; set; }
        public string thumbprint { get; set; }
        public string validfrom { get; set; }
        public Issuer Issuer { get; set; }
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

    public class ComSoftCommonMain
    {
        public List<string> action { get; set; }
        public List<string> category { get; set; }
    }

    public class CrowdsourcedIdsResult
    {
        public string rule_category { get; set; }
        public string rule_url { get; set; }
        public string alert_severity { get; set; }
        public string rule_msg { get; set; }
        public string rule_source { get; set; }
        public string rule_raw { get; set; }
        public string rule_id { get; set; }
        public List<AlertContext> alert_context { get; set; }
        public List<string> rule_references { get; set; }
    }

    public class CrowdsourcedIdsStats
    {
        public int high { get; set; }
        public int info { get; set; }
        public int medium { get; set; }
        public int low { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Cyren
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Data
    {
        public Attributes attributes { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public Links links { get; set; }
    }

    public class DrWeb
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Extensions
    {
        public int xml { get; set; }
        public int dex { get; set; }
        public int MF { get; set; }
        public int cfg { get; set; }
        public int RSA { get; set; }
        public int SF { get; set; }
        public int png { get; set; }
    }

    public class FileTypes
    {
        public int XML { get; set; }
        public int unknown { get; set; }
        public int DEX { get; set; }
        public int directory { get; set; }
        public int PNG { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class FSecure
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class IntentFilters
    {
        public Activities Activities { get; set; }
    }

    public class Issuer
    {
        public string DN { get; set; }
        public string C { get; set; }
        public string CN { get; set; }
        public string L { get; set; }
        public string O { get; set; }
        public string ST { get; set; }
        public string OU { get; set; }
    }

    public class Jiangmin
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Kaspersky
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class LastAnalysisResults
    {
        public Bkav Bkav { get; set; }
        public Lionic Lionic { get; set; }
        public Elastic Elastic { get; set; }
        public Cynet Cynet { get; set; }
        public CMC CMC { get; set; }

        [JsonProperty("CAT-QuickHeal")]
        public CATQuickHeal CATQuickHeal { get; set; }
        public ALYac ALYac { get; set; }
        public Malwarebytes Malwarebytes { get; set; }
        public VIPRE VIPRE { get; set; }
        public Sangfor Sangfor { get; set; }
        public Trustlook Trustlook { get; set; }
        public BitDefender BitDefender { get; set; }
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
        public Alibaba Alibaba { get; set; }

        [JsonProperty("NANO-Antivirus")]
        public NANOAntivirus NANOAntivirus { get; set; }
        public ViRobot ViRobot { get; set; }

        [JsonProperty("MicroWorld-eScan")]
        public MicroWorldEScan MicroWorldeScan { get; set; }
        public Rising Rising { get; set; }
        public TACHYON TACHYON { get; set; }
        public Emsisoft Emsisoft { get; set; }
        public Baidu Baidu { get; set; }

        [JsonProperty("F-Secure")]
        public FSecure FSecure { get; set; }
        public DrWeb DrWeb { get; set; }
        public Zillya Zillya { get; set; }
        public TrendMicro TrendMicro { get; set; }

        [JsonProperty("McAfee-GW-Edition")]
        public McAfeeGWEdition McAfeeGWEdition { get; set; }
        public SentinelOne SentinelOne { get; set; }
        public Trapmine Trapmine { get; set; }
        public FireEye FireEye { get; set; }
        public Sophos Sophos { get; set; }
        public Paloalto Paloalto { get; set; }
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
        public McAfee McAfee { get; set; }
        public MAX MAX { get; set; }
        public VBA32 VBA32 { get; set; }
        public Cylance Cylance { get; set; }
        public Zoner Zoner { get; set; }
        public Tencent Tencent { get; set; }
        public Yandex Yandex { get; set; }
        public Ikarus Ikarus { get; set; }
        public MaxSecure MaxSecure { get; set; }
        public Fortinet Fortinet { get; set; }
        public AVG AVG { get; set; }
        public Panda Panda { get; set; }
        public CrowdStrike CrowdStrike { get; set; }
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
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class McAfee
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class McAfeeGWEdition
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Microsoft
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Packers
    {
        [JsonProperty("F-PROT")]
        public string FPROT { get; set; }
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

    public class PERM
    {
        public int DANGEROUS { get; set; }
        public int INTERNET { get; set; }
        public int MONEY { get; set; }
        public int SMS { get; set; }
        public int PRIVACY { get; set; }
    }

    public class PermissionDetails
    {
        [JsonProperty("android.permission.SEND_SMS")]
        public AndroidPermissionSENDSMS androidpermissionSEND_SMS { get; set; }

        [JsonProperty("android.permission.WRITE_EXTERNAL_STORAGE")]
        public AndroidPermissionWRITEEXTERNALSTORAGE androidpermissionWRITE_EXTERNAL_STORAGE { get; set; }

        [JsonProperty("android.permission.INTERNET")]
        public AndroidPermissionINTERNET androidpermissionINTERNET { get; set; }

        [JsonProperty("android.permission.READ_PHONE_STATE")]
        public AndroidPermissionREADPHONESTATE androidpermissionREAD_PHONE_STATE { get; set; }
    }

    public class PopularThreatCategory
    {
        public int count { get; set; }
        public string value { get; set; }
    }

    public class PopularThreatClassification
    {
        public string suggested_threat_label { get; set; }
        public List<PopularThreatCategory> popular_threat_category { get; set; }
        public List<PopularThreatName> popular_threat_name { get; set; }
    }

    public class PopularThreatName
    {
        public int count { get; set; }
        public string value { get; set; }
    }

    public class Rising
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class RiskIndicator
    {
        public APK APK { get; set; }
        public PERM PERM { get; set; }
    }

    public class Analysis
    {
        public Data data { get; set; }
    }

    public class SandboxVerdicts
    {
        [JsonProperty("Zenbox Linux")]
        public ZenboxLinux ZenboxLinux { get; set; }

        [JsonProperty("Zenbox android")]
        public ZenboxAndroid Zenboxandroid { get; set; }
    }

    public class Sangfor
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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

    public class Sophos
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Subject
    {
        public string DN { get; set; }
        public string C { get; set; }
        public string CN { get; set; }
        public string L { get; set; }
        public string O { get; set; }
        public string ST { get; set; }
        public string OU { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class SymantecMobileInsight
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class TrendMicroHouseCall
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class VBA32
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
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
        public string result { get; set; }
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
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Yandex
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public string result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ZenboxAndroid
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
        public string result { get; set; }
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
