using System;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;
using System.Windows;
using Prism.Modularity;

namespace WpfDemoMain
{
    /// <summary>
    /// MEF Bootstrapper
    /// </summary>
    public class MefBootstrapper : Prism.Mef.MefBootstrapper
    {
        /// <summary>
        /// 加载组件
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

                //加载主项目类
                AggregateCatalog.Catalogs.Add(new AssemblyCatalog(Assembly.GetExecutingAssembly()));

                var container = new CompositionContainer(this.AggregateCatalog);
                container.ComposeParts(this);
            }
        }
        
        /// <summary>
        /// 注册WPF组件
        /// </summary>
        /// <returns></returns>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            var uri = new Uri("/WpfDemoMain;Component/ModulesCatalog.xaml", UriKind.Relative);
            return Prism.Modularity.ModuleCatalog.CreateFromXaml(uri);
        }

        /// <summary>
        /// 建立起动页面
        /// </summary>
        /// <returns></returns>
        protected override DependencyObject CreateShell()
        {
            var viewModel = Container.GetExportedValue<IShellViewModel>();
            return (DependencyObject)viewModel.View;
        }

        /// <summary>
        /// 设置主窗口打开页面
        /// </summary>
        protected override void InitializeShell()
        {
            //base.InitializeShell();
            Application.Current.MainWindow = (Window) Shell;
            Application.Current.MainWindow.Show();
        }
    }
}