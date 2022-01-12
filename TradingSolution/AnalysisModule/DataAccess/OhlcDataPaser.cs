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
    public class OhlcDataPaser : Parser, IParser<OhlcCandleData>
    {
        private OhlcCandleData _candle = new OhlcCandleData();
        
        public OhlcCandleData GetData()
        {
            return _candle;
        }

        // Split OHLC data from line 
        public override bool TryParse(string input)
        {
            if (string.IsNullOrEmpty(input)) return false;
            var lines = input.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            _candle = new OhlcCandleData();

            // get ohlc data with time and volume
            foreach (var line in lines)
            {
                try
                {
                    var data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    if (data.Length == 7)
                    {
                        var timeData = data[1].Split(':');
                        OhlcCandle candle = new OhlcCandle
                        {
                            Date = DateTime.Parse(data[0]),
                            Time = new TimeSpan(int.Parse(timeData[0]), int.Parse(timeData[1]), 0),
                            Open = double.Parse(data[2].Replace('.',',')),
                            High = double.Parse(data[3].Replace('.', ',')),
                            Low = double.Parse(data[4].Replace('.', ',')),
                            Close = double.Parse(data[5].Replace('.', ',')),
                            Volume = int.Parse(data[6])
                        };
                        _candle.Candles.Add(candle);
                    }
                }
                catch(Exception e)
                {
                    AddError($"Error during parsing: {line} \n{e.Message}");
                }
            }

            return true;
        }
    }
}
