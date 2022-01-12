using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.Models
{
    public class OhlcCandle
    {
        public double Open { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Volume { get; set; }
    }
}
