using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;
using Autofac;
using Prism.Events;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using WpfDemo.Business;
using WpfDemo.Common;
using WpfDemo.Data;

namespace WpfDemo.UI.User
{
    [ModuleExport(typeof(ModuleUser))]
    public class ModuleUser : AModule, IModule
    {
        [Import] private IUserListViewModel _viewModel;

        public void Initialize()
        {
            var builder = new ContainerBuilder();

            var assembly = typeof(ModuleDataConfiguration).Assembly;
            var assembly1 = typeof(ModuleBusinessConfiguration).Assembly;

            // 只注册AModule 不会注册 BModule
            builder.RegisterAssemblyModules(typeof(ModuleDataConfiguration), assembly);
            builder.RegisterAssemblyModules(typeof(ModuleBusinessConfiguration), assembly1);

            //builder.RegisterModule(new ModuleDataConfiguration());
            //builder.RegisterModule(new ModuleBusinessConfiguration());
            builder.Build();
            RegionManager.RegisterViewWithRegion("MainRegion", () => _viewModel.View);
        }
    }
}
