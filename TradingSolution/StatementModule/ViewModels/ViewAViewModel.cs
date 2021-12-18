using Core.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using StatementModule.Interfaces;
using StatementModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;
        private readonly IStatementService _statementService;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(IStatementService statemenrService)
        {
            Message = "View A from Module";
            _statementService = statemenrService;

            var statements = _statementService.GetAllStatements();
        }
    }
}
