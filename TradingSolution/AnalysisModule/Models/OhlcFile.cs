using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.Models
{
    public class OhlcFile
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public List<string> Lines { get; set; }
    }
}
