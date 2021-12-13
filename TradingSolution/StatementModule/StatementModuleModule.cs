using StatementModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Core.Interfaces;
using StatementModule.Models;
using StatementModule.DataAccess;

namespace StatementModule
{
    public class StatementModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ILoader<StatementFile>, StatementLoader>();
        }
    }
}