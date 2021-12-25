using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JournalModule.ViewModels
{
    public class MainJournalViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public MainJournalViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            NavigateCommandJournal = new DelegateCommand<string>(Navigate);

            //logger.Info("MainWindow Start!");
        }

        private void Navigate(string uri)
        {
            _regionManager.RequestNavigate("JournalContentRegion", uri);
        }

        public DelegateCommand<string> NavigateCommandJournal { get; set; }
    }
}
