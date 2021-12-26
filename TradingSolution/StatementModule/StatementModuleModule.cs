using StatementModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Core.Interfaces;
using StatementModule.Models;
using StatementModule.DataAccess;
using StatementModule.Sevices;
using StatementModule.Interfaces;

namespace StatementModule
{
    public class StatementModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(MainView));
            regionManager.RegisterViewWithRegion("StatementContentRegion", typeof(StatementList));
            //regionManager.RegisterViewWithRegion("StatementContentRegion", typeof(StatementView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILoader<StatementFile>, StatementLoader>();
            containerRegistry.RegisterSingleton<IParser<Statement>, StatementMt4Parser>();
            containerRegistry.RegisterSingleton<IStatementService, StatementService>();

            containerRegistry.RegisterForNavigation<MainView>("MainViewStatement");
            containerRegistry.RegisterForNavigation<StatementList>("StatementList");
            containerRegistry.RegisterForNavigation<StatementView>("StatementView");
        }
    }
}