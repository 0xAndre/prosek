using prosek.application.exceptions;
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
        public string GetMockedProcessData()
        {
            string fileName = @"D:\git\prosek\docs\example_malicious.json";

            return File.ReadAllText(fileName);
        }

        /// <inheritdoc/>
        public string GetProcessData(string hash, string processName)
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

                    return response.Content.ReadAsStringAsync().Result;
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
