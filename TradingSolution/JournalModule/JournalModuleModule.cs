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

            regionManager.RegisterViewWithRegion("JournalContentRegion", typeof(ViewA));
            //regionManager.RegisterViewWithRegion("JournalContentRegion", typeof(ViewB));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(MainJournalView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>("ViewA");
            containerRegistry.RegisterForNavigation<ViewB>("ViewB");
        }
    }
}