using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosek.models
{
    public class AnalysisResult
    {
        public string? category { get; set; }
        public string? engine_name { get; set; }
        public string? engine_version { get; set; }
        public string? result { get; set; }
        public string? engine_update { get; set; }
    }
}
