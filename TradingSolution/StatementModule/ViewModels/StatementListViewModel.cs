using Core.Interfaces;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
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
    public class StatementListViewModel : BindableBase, INavigationAware
    {
        private string _message;
        private readonly IStatementService _statementService;
        private readonly IRegionManager regionManager;

        public ObservableCollection<Statement> ListOfStatements { get; set; }
        public Statement SelectedStatement { get; set; }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public StatementListViewModel(IStatementService statemenrService, IRegionManager regionManager)
        {
            Message = "Statement list:";
            _statementService = statemenrService;
            this.regionManager = regionManager;
            ListOfStatements = new ObservableCollection<Statement>(_statementService.GetAllStatements());
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            //navigationService = navigationContext.NavigationService;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }

        private DelegateCommand _openStatementViewComman;
        public DelegateCommand OpenStatementViewComman =>
            _openStatementViewComman ?? (_openStatementViewComman = new DelegateCommand(ExecuteOpenStatementCommand));

        void ExecuteOpenStatementCommand()
        {
            NavigationParameters navParams = new NavigationParameters();
            if (SelectedStatement != null)
            {
                navParams.Add("statement", SelectedStatement);
            }

            regionManager.RequestNavigate("ContentRegion", new Uri("StatementView", UriKind.Relative), navParams);
        }
    }
}
