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
        private readonly ILoader<OhlcCandleData> _loader;
        private readonly IParser<OhlcCandle> _parser;

        public OhlcDataService(
            ILoader<OhlcCandleData> loader,
            IParser<OhlcCandle> parser)
        {
            _loader = loader;
            _parser = parser;
        }


        public List<OhlcCandleData> GetAllCandleData()
        {
            throw new NotImplementedException();
        }
    }
}
