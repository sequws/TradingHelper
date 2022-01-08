using AnalysisModule.Models;
using Core.Abstractions;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.DataAccess
{
    public class OhlcDataPaser : Parser, IParser<OhlcCandle>
    {
        private OhlcCandle _candle = new OhlcCandle();
        
        public OhlcCandle GetData()
        {
            return _candle;
        }

        // Split OHLC data from line 
        public override bool TryParse(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;

            // todo

            return true;
        }
    }
}
