using JournalModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace JournalModule
{
    public class JournalModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();

            regionManager.RegisterViewWithRegion("JournalContentRegion", typeof(Journal));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(MainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Journal>("Journal");
            containerRegistry.RegisterForNavigation<MainView>("MainViewJournal");
            containerRegistry.RegisterForNavigation<NewTransaction>("NewTransaction");
        }
    }
}