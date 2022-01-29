using ControlzEx.Theming;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Threading;
using System.Windows;
using TradingHelper.Views;

namespace TradingHelper
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            var lang = TradingHelper.Properties.Settings.Default.AppLanguage;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var regionManager = Container.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Hello));

            //containerRegistry.RegisterForNavigation<Hello>("Hello");
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Set the application theme to Dark.Green
            //ThemeManager.Current.ChangeTheme(this, "Dark.Green");
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<StatementModule.StatementModuleModule>();
            moduleCatalog.AddModule<JournalModule.JournalModuleModule>();
            moduleCatalog.AddModule<AnalysisModule.AnalysisModuleModule>();
        }
    }
}
