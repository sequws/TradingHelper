using AnalysisModule.DataAccess;
using AnalysisModule.Interfaces;
using AnalysisModule.Models;
using AnalysisModule.Services;
using AnalysisModule.Views;
using Core.Interfaces;
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
            regionManager.RegisterViewWithRegion("AnalysisContentRegion", typeof(Report));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILoader<OhlcFile>, OhlcDataLoader>();
            containerRegistry.RegisterSingleton<IParser<OhlcCandleData>, OhlcDataPaser>();
            containerRegistry.RegisterSingleton<IOhlcDataService, OhlcDataService>();

            containerRegistry.RegisterForNavigation<MainView>("MainViewAnalysis");
            //containerRegistry.RegisterForNavigation<Report>("Report");            
        }
    }
}