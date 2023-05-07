using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using prosek.application.exceptions;
using prosek.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosek.application
{
    public class DataManager
    {
        public static string GetVirusTotalFileData(string hash, string processName)
        {
            try
            {
                HttpClient httpClient = new HttpClient();


                httpClient.DefaultRequestHeaders.Add("X-VT-Anti-Abuse-Header", GenerateRandomAlphanumericString(16));
                httpClient.DefaultRequestHeaders.Add("X-Tool", "vt-ui-main");
                httpClient.DefaultRequestHeaders.Add("Accept-Ianguage", "en-US,en;q=0.9,es;q=0.8");
                httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/112.0");

                var response = httpClient.GetAsync($"https://www.virustotal.com/ui/files/{hash}").Result;

                if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new NotFoundException($"Process: {processName} not found on VirusTotal.");
                }

                return response.Content.ReadAsStringAsync().Result;
            } 
            catch (Exception) {
                throw;
            }
            
        }

        private static string GenerateRandomAlphanumericString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
    }
}
