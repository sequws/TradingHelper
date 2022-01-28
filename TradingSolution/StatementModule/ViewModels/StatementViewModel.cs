using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using StatementModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace StatementModule.ViewModels
{
    public class StatementViewModel : BindableBase, INavigationAware
    {
        public string Info { get; set; } = "Statement info";
        private readonly IRegionManager _regionManager;
        public ICommand GoBackCommand { get; set; }

        private Statement _statement;
        public Statement Statement
        {
            get
            {
                return _statement;
            }
            set
            {
                _statement = value;
                RaisePropertyChanged();
            }
        }

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

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            var statement = (Statement)navigationContext.Parameters["statement"];
            if (statement != null)
            {
                // get statement from service?
                Statement = statement;
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
