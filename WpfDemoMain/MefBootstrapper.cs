using System;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using WpfDemo.UI.User;

namespace Wams.UI.WpfAutomation
{
    public class MefBootstrapper : Prism.Mef.MefBootstrapper
    {
        private CompositionContainer _container;

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            //this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(GetType().Assembly));
            //An aggregate catalog that combines multiple catalogs
            var catalog = new AggregateCatalog();
            //Adds all the parts found in the same assembly as the Program class
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(MefBootstrapper).Assembly));
            _container = new CompositionContainer(catalog);
            //AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof (MefBootstrapper).Assembly));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        protected override IContainerExtension CreateContainerExtension()
        {
            return CreateContainerExtension();
            //return _container;
        }

        protected override void ConfigureModuleCatalog()
        {
            Type moduleCType = typeof(ModuleUser);
            ModuleCatalog.AddModule(
            new ModuleInfo()
            {
                ModuleName = moduleCType.Name,
                ModuleType = moduleCType.AssemblyQualifiedName,
            });
        }

        //protected override IModuleCatalog CreateModuleCatalog()
        //{
        //    var uri = new Uri("/WpfDemoMain;Component/ModulesCatalog.xaml", UriKind.Relative);
        //    return Prism.Modularity.ModuleCatalog.CreateFromXaml(uri);
        //}

        protected override DependencyObject CreateShell()
        {
            var viewModel = Container.GetExportedValue<IShellViewModel>();
            return (DependencyObject)viewModel.View;
        }

        protected override void InitializeShell()
        {
           // base.InitializeShell();
            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();
        }
    }
}