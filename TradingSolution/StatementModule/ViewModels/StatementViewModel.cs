using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace StatementModule.ViewModels
{
    public class StatementViewModel : BindableBase
    {
        public string Info { get; set; } = "Statement info";
        private readonly IRegionManager _regionManager;
        public ICommand GoBackCommand { get; set; }

        public StatementViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            GoBackCommand = new DelegateCommand(GoBack, CanGoBack);
        }

        private bool CanGoBack()
        {
            return true;
        }

        private void GoBack()
        {
            _regionManager.RequestNavigate("ContentRegion", new Uri("StatementList", UriKind.Relative));
        }
    }
}
