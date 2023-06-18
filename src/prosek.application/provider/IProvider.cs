using prosek.models.relations.Domains;
using prosek.models.relations.IPs;
using prosek.models.relations.Parents;
using prosek.models.relations.PE;
using prosek.models.relations.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Get a Process Information from Mocked File.
        /// </summary>
        public Analysis GetMockedProcessData();

        public ContactedIps GetMockedContactedIpsData();

        public ContactedIps GetContactedIPsData(string hash);

        public ExecutionParents GetMockedExecutionParentsData();

        public ExecutionParents GetExecutionParentsData(string hash);

        public ContactedDomains GetMockedContactedDomainsData();

        public PEResourceChildren GetMockedPEResourceChildrenData();

        public ContactedDomains GetContactedDomainsData(string hash);

        public PEResourceChildren GetPEResourceChildrenData(string hash);
    }
}
