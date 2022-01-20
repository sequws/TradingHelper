using FancyCandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.Models
{
    public class CandlesSource : System.Collections.ObjectModel.ObservableCollection<ICandle>, ICandlesSource
    {
        public CandlesSource(TimeFrame timeFrame)
        {
            this.timeFrame = timeFrame;
        }

        private readonly TimeFrame timeFrame;
        public TimeFrame TimeFrame { get { return timeFrame; } }
    }
}
