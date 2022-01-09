using AnalysisModule.Models;
using Core.Abstractions;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.DataAccess
{
    public class OhlcDataLoader : Loader, ILoader<OhlcCandleData>
    {
        public OhlcDataLoader() : base("ohlcdata", "*.csv")
        {

        }

        public IEnumerable<OhlcCandleData> LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
