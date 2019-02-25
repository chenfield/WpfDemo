using System;
using System.ComponentModel.Composition.Hosting;
using System.Windows;
using Autofac;
using Prism.Modularity;
using WpfDemo.Business;
using WpfDemo.Data;
using WpfDemo.UI.User;

namespace WpfDemoMain
{
    public class MefBootstrapper : Prism.Mef.MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MefBootstrapper).Assembly));
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            var uri = new Uri("/WpfDemoMain;Component/ModulesCatalog.xaml", UriKind.Relative);
            return Prism.Modularity.ModuleCatalog.CreateFromXaml(uri);
        }

        protected override DependencyObject CreateShell()
        {
            var viewModel = Container.GetExportedValue<IShellViewModel>();
            return (DependencyObject)viewModel.View;
        }

        protected override void InitializeShell()
        {
            //base.InitializeShell();
            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();
        }
    }
}