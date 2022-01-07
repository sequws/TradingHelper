using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.Models
{
    public class OhlcCandleData
    {
        public string Name { get; set; }
        IList<OhlcCandle> Candles { get; set; }
    }
}
