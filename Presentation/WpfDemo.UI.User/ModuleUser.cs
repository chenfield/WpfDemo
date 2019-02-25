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
            RegionManager.RegisterViewWithRegion("MainRegion", () => _viewModel.View);
        }
    }
}
