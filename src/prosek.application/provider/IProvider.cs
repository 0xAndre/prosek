using prosek.models.relations.Domains;
using prosek.models.relations.IPs;
using prosek.models.relations.Parents;
using prosek.models.relations.PE;
using prosek.models.relations.Process;

namespace prosek.application.provider
{
    public interface IProvider
    {
        /// <summary>
        /// Get a Process Information from Provider.
        /// </summary>
        /// <param name="hash">File Hash.</param>
        /// <param name="processName">Process Name.</param>
        public Analysis GetProcessData(string hash, string processName);

        /// <summary>
        /// Get a Process Contacted IPs from Provider.
        /// </summary>
        /// <param name="hash">File Hash.</param>
        public ContactedIps GetContactedIPsData(string hash);

        /// <summary>
        /// Get a Process Execution Parents from Provider.
        /// </summary>
        /// <param name="hash">File Hash.</param>
        public ExecutionParents GetExecutionParentsData(string hash);

        /// <summary>
        /// Get a Process Contacted Domains from Provider.
        /// </summary>
        /// <param name="hash">File Hash.</param>
        public ContactedDomains GetContactedDomainsData(string hash);

        /// <summary>
        /// Get a Process PEResource Children from Provider.
        /// </summary>
        /// <param name="hash">File Hash.</param>
        public PEResourceChildren GetPEResourceChildrenData(string hash);
    }
}
