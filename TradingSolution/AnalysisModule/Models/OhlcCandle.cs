using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.Models
{
    public class OhlcCandle
    {
        double Open { get; set; }
        double High { get; set; }
        double Low { get; set; }
        double Close { get; set; }
        DateTime Date { get; set; }
        TimeSpan Time { get; set; }
        int Volume { get; set; }
    }
}
