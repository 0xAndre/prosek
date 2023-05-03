using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosek.application
{
    public class DataManager
    {
        public static void GetVirusTotalFileData(string hash)
        {
            HttpClient httpClient = new HttpClient();
            string xAbuseHeader = File.ReadAllText("xabuseheader.txt");
            
            httpClient.DefaultRequestHeaders.Add("X-VT-Anti-Abuse-Header", xAbuseHeader);
            httpClient.DefaultRequestHeaders.Add("X-Tool", "vt-ui-main");
            httpClient.DefaultRequestHeaders.Add("Accept-Ianguage", "en-US,en;q=0.9,es;q=0.8");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/112.0");

            var response = httpClient.GetAsync($"https://www.virustotal.com/ui/files/{hash}").Result;
            response.EnsureSuccessStatusCode();
            string fileInfo = response.Content.ReadAsStringAsync().Result;
        }
    }
}
