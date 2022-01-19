using AnalysisModule.Interfaces;
using AnalysisModule.Models;
using Core.Interfaces;
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

        public ReportViewModel( IOhlcDataService service)
        {
            Message = "Report";

            _service = service;
            var data = _service.GetAllCandleData();
        }
    }
}
