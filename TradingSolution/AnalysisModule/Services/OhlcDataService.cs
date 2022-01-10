using AnalysisModule.Interfaces;
using AnalysisModule.Models;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.Services
{
    public class OhlcDataService : IOhlcDataService
    {
        private readonly ILoader<OhlcFile> _loader;
        private readonly IParser<OhlcCandle> _parser;

        public OhlcDataService(
            ILoader<OhlcFile> loader,
            IParser<OhlcCandle> parser)
        {
            _loader = loader;
            _parser = parser;
        }


        public List<OhlcCandleData> GetAllCandleData()
        {
            List<OhlcCandleData> loadedOhlcData = new List<OhlcCandleData>();

            var ohlcFiles = _loader.LoadData();

            foreach (var data in ohlcFiles)
            {
                if (_parser.TryParse(string.Join("\n", data.Lines)))
                {
                    //var parsed = _parser.GetData();
                }

            }

            return loadedOhlcData;
        }
    }
}
