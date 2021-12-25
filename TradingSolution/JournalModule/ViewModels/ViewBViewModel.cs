using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JournalModule.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        public ViewBViewModel()
        {
            Message = "Jornual module View B";
        }
    }
}
