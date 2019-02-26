using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;
using System.Windows;
using Autofac;
using Prism.Modularity;
using WpfDemo.Business;
using WpfDemo.Data;
using WpfDemo.UI.User;

namespace WpfDemoMain
{
    /// <summary>
    /// 
    /// </summary>
    public class MefBootstrapper : Prism.Mef.MefBootstrapper
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(MefBootstrapper).Assembly));

            //加载Modules目录
            if (Directory.Exists("./Modules"))
            {
                var catalog = new DirectoryCatalog("./Modules");
                AggregateCatalog = new AggregateCatalog(catalog);
                AggregateCatalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));

                var container = new CompositionContainer(this.AggregateCatalog);
                container.ComposeParts(this);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            var uri = new Uri("/WpfDemoMain;Component/ModulesCatalog.xaml", UriKind.Relative);
            return Prism.Modularity.ModuleCatalog.CreateFromXaml(uri);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject CreateShell()
        {
            var viewModel = Container.GetExportedValue<IShellViewModel>();
            return (DependencyObject)viewModel.View;
        }

        /// <summary>
        /// 
        /// </summary>
        protected override void InitializeShell()
        {
            //base.InitializeShell();
            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();
        }
    }
}