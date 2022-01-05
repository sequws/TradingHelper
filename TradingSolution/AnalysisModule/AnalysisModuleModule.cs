using AnalysisModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace AnalysisModule
{
    public class AnalysisModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("AnalysisContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainView>("MainViewAnalysis");
        }
    }
}