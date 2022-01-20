using AnalysisModule.Interfaces;
using AnalysisModule.Models;
using Core.Interfaces;
using FancyCandles;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysisModule.ViewModels
{
    public class ReportViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        readonly IOhlcDataService _service;

        public CandlesSource Candles { get; set; }
        public string ChartName { get; set; }

        public ReportViewModel(IOhlcDataService service)
        {
            Message = "Report";

            _service = service;
            var data = _service.GetAllCandleData();

            Candles = new CandlesSource(TimeFrame.H1);
            ChartName = data[0].Name;

            foreach (var candle in data[0].Candles)
            {
                Candles.Add(new Candle(candle.Date.Add(candle.Time), candle.Open, candle.High, candle.Low, candle.Close, candle.Volume));
            }

            Message = $"{ChartName}, candles: {Candles.Count}";
        }
    }
}
