using ModuleA;
using ModuleB;
using ModulesTest.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace ModulesTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            var moduleAType = typeof(ModuleAModule);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = moduleAType.Name,
                ModuleType = moduleAType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable
            });

            var moduleBType = typeof(ModuleBModule);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = moduleBType.Name,
                ModuleType = moduleBType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable
            });

        }
    }
}
