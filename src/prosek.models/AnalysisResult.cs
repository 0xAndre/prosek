using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosek.models
{
    public class AnalysisResult
    {
        /// <summary>
        /// Gets or sets Provider Process Category.
        /// </summary>
        /// <value>
        /// The Process Category.
        /// </value>
        public string? category { get; set; }

        /// <summary>
        /// Gets or sets Provider Process Engine.
        /// </summary>
        /// <value>
        /// The Process Engine.
        /// </value>
        public string? engine_name { get; set; }

        /// <summary>
        /// Gets or sets Provider Process Engine Version.
        /// </summary>
        /// <value>
        /// The Process Version.
        /// </value>
        public string? engine_version { get; set; }

        /// <summary>
        /// Gets or sets Provider Process Result.
        /// </summary>
        /// <value>
        /// The Process Result.
        /// </value>
        public string? result { get; set; }

        /// <summary>
        /// Gets or sets Provider Process Engine Update.
        /// </summary>
        /// <value>
        /// The Process Engine Update.
        /// </value>
        public string? engine_update { get; set; }
    }
}
