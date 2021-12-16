using Core.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
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
        private readonly ILoader<StatementFile> _statementLoader;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel(ILoader<StatementFile> statementLoader)
        {
            Message = "View A from Module";
            _statementLoader = statementLoader;

            var files =_statementLoader.LoadData();
        }
    }
}
