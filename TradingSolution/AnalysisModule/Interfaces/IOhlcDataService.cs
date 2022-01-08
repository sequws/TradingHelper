using AnalysisModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.Interfaces
{
    interface IOhlcDataService
    {
        List<OhlcCandleData> GetAllCandleData();
    }
}
