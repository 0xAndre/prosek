using Newtonsoft.Json;
using prosek.application.exceptions;
using prosek.models.relations.Community;
using prosek.models.relations.Domains;
using prosek.models.relations.IPs;
using prosek.models.relations.Parents;
using prosek.models.relations.PE;
using prosek.models.relations.Process;

namespace prosek.application.provider.virustotal
{
    public class VirusTotalProvider : IProvider
    {
        private string _X_HEADER_FILENAME = "xabuseheader.txt";

        private string BaseUrl = "https://www.virustotal.com/ui/files/";

        /// <summary>
        /// Initializes a new instance of the <see cref="VirusTotalProvider"/> class.
        /// </summary>
        public VirusTotalProvider()
        {
            // create a file if not exists
            using (StreamWriter w = File.AppendText(_X_HEADER_FILENAME)) { }
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

                using (HttpClient client = GetHttpClient())
                {
                    HttpResponseMessage response = client
                        .GetAsync(string.Concat(client.BaseAddress, hash))
                        .Result;

                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new NotFoundException(
                            $"Process: {processName} not found on VirusTotal."
                        );
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

                using (HttpClient client = GetHttpClient())
                {
                    HttpResponseMessage response = client
                        .GetAsync(string.Concat(client.BaseAddress, hash, "/contacted_ips"))
                        .Result;

                    string result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<ContactedIps>(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <inheritdoc/>
        public ContactedDomains GetContactedDomainsData(string hash)
        {
            try
            {
                // get custom x-header
                string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

                if (string.IsNullOrEmpty(xAbuseHeader))
                {
                    xAbuseHeader = GenerateRandomAlphanumericString(16);
                }

                using (HttpClient client = GetHttpClient())
                {
                    HttpResponseMessage response = client
                        .GetAsync(string.Concat(client.BaseAddress, hash, "/contacted_domains"))
                        .Result;

                    string result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<ContactedDomains>(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <inheritdoc/>
        public PEResourceChildren GetPEResourceChildrenData(string hash)
        {
            try
            {
                // get custom x-header
                string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

                if (string.IsNullOrEmpty(xAbuseHeader))
                {
                    xAbuseHeader = GenerateRandomAlphanumericString(16);
                }

                using (HttpClient client = GetHttpClient())
                {
                    HttpResponseMessage response = client
                        .GetAsync(string.Concat(client.BaseAddress, hash, "/pe_resource_children"))
                        .Result;

                    string result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<PEResourceChildren>(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <inheritdoc/>
        public ExecutionParents GetExecutionParentsData(string hash)
        {
            try
            {
                // get custom x-header
                string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

                if (string.IsNullOrEmpty(xAbuseHeader))
                {
                    xAbuseHeader = GenerateRandomAlphanumericString(16);
                }

                using (HttpClient client = GetHttpClient())
                {
                    HttpResponseMessage response = client
                        .GetAsync(string.Concat(client.BaseAddress, hash, "/execution_parents"))
                        .Result;

                    string result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<ExecutionParents>(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <inheritdoc/>
        public Comments GetCommunityCommentsData(string hash)
        {
            try
            {
                // get custom x-header
                string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

                if (string.IsNullOrEmpty(xAbuseHeader))
                {
                    xAbuseHeader = GenerateRandomAlphanumericString(16);
                }

                using (HttpClient client = GetHttpClient())
                {
                    HttpResponseMessage response = client
                        .GetAsync(string.Concat(client.BaseAddress, hash, "/comments?relationships=item,author"))
                        .Result;

                    string result = response.Content.ReadAsStringAsync().Result;

                    return JsonConvert.DeserializeObject<Comments>(result);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Http client.
        /// </summary>
        /// <returns>Http client.</returns>
        private HttpClient GetHttpClient()
        {
            HttpClient httpClient = new HttpClient { BaseAddress = new Uri(this.BaseUrl) };

            // get custom x-header
            string xAbuseHeader = File.ReadAllText(_X_HEADER_FILENAME);

            if (string.IsNullOrEmpty(xAbuseHeader))
            {
                xAbuseHeader = GenerateRandomAlphanumericString(16);
            }

            httpClient.DefaultRequestHeaders.Add("X-VT-Anti-Abuse-Header", xAbuseHeader);
            httpClient.DefaultRequestHeaders.Add("X-Tool", "vt-ui-main");
            httpClient.DefaultRequestHeaders.Add("Accept-Ianguage", "en-US,en;q=0.9,es;q=0.8");
            httpClient.DefaultRequestHeaders.Add(
                "User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:109.0) Gecko/20100101 Firefox/112.0"
            );

            return httpClient;
        }

        /// <summary>
        /// Generates random string to add on X-VT-Anti-Abuse-Header HTTP header request.
        /// </summary>
        /// <param name="length">String Length.</param>
        private static string GenerateRandomAlphanumericString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            var random = new Random();
            var randomString = new string(
                Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray()
            );
            return randomString;
        }
    }
}
