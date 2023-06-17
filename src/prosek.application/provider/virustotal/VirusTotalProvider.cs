using Newtonsoft.Json;
using prosek.application.exceptions;
using prosek.models;
using prosek.models.relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosek.application.provider.virustotal
{
    public class VirusTotalProvider : IProvider
    {

        private string _X_HEADER_FILENAME = "xabuseheader.txt";

        /// <summary>
        /// Initializes a new instance of the <see cref="VirusTotalProvider"/> class.
        /// </summary>
        public VirusTotalProvider() { }

        /// <inheritdoc/>
        public Analysis GetMockedProcessData()
        {
            string fileName = @"D:\git\prosek\docs\example.json";

            string file = File.ReadAllText(fileName);

            Analysis analysisResults = JsonConvert.DeserializeObject<Analysis>(file);

            return analysisResults;
        }

        /// <inheritdoc/>
        public ContactedIps GetMockedContactedIpsData()
        {
            string fileName = @"D:\git\prosek\docs\contactedips.json";

            string file = File.ReadAllText(fileName);

            ContactedIps analysisResults = JsonConvert.DeserializeObject<ContactedIps>(file);

            return analysisResults;
        }

        /// <inheritdoc/>
        public Analysis GetProcessData(string hash, string processName)
        {
            try
            {
                // get custom x-header
                string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

                if (string.IsNullOrEmpty(xAbuseHeader))
                {
                    xAbuseHeader = GenerateRandomAlphanumericString(16);
                }

                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("X-VT-Anti-Abuse-Header", xAbuseHeader);
                    httpClient.DefaultRequestHeaders.Add("X-Tool", "vt-ui-main");
                    httpClient.DefaultRequestHeaders.Add("Accept-Ianguage", "en-US,en;q=0.9,es;q=0.8");
                    httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/112.0");

                    HttpResponseMessage response = httpClient.GetAsync($"https://www.virustotal.com/ui/files/{hash}").Result;

                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new NotFoundException($"Process: {processName} not found on VirusTotal.");
                    }

                    string result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<Analysis>(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <inheritdoc/>
        public ContactedIps GetContactedIPsData(string hash)
        {
            try
            {
                // get custom x-header
                string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

                if (string.IsNullOrEmpty(xAbuseHeader))
                {
                    xAbuseHeader = GenerateRandomAlphanumericString(16);
                }

                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("X-VT-Anti-Abuse-Header", xAbuseHeader);
                    httpClient.DefaultRequestHeaders.Add("X-Tool", "vt-ui-main");
                    httpClient.DefaultRequestHeaders.Add("Accept-Ianguage", "en-US,en;q=0.9,es;q=0.8");
                    httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/112.0");

                    HttpResponseMessage response = httpClient.GetAsync($"https://www.virustotal.com/ui/files/{hash}/contacted_ips").Result;

                    string result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<ContactedIps>(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Generates random string to add on X-VT-Anti-Abuse-Header HTTP header request.
        /// </summary>
        /// <param name="length">String Length.</param>
        private static string GenerateRandomAlphanumericString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
    }
}
