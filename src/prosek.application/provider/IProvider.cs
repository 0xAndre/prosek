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
        public string GetProcessData(string hash, string processName);

        /// <summary>
        /// Get a Process Information from Mocked File.
        /// </summary>
        public string GetMockedProcessData();
    }
}
