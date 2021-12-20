using Core.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using StatementModule.Interfaces;
using StatementModule.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatementModule.ViewModels
{
    public class StatementListViewModel : BindableBase
    {
        private string _message;
        private readonly IStatementService _statementService;

        public ObservableCollection<Statement> ListOfStatements { get; set; }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public StatementListViewModel(IStatementService statemenrService)
        {
            Message = "Statement list:";
            _statementService = statemenrService;

            ListOfStatements = new ObservableCollection<Statement>(_statementService.GetAllStatements());
        }
    }
}
