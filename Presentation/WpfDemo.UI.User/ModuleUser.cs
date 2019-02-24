using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;
using Prism.Events;
using Prism.Ioc;
using Prism.Mef.Modularity;
using Prism.Modularity;
using Prism.Regions;
using WpfDemo.Common;

namespace WpfDemo.UI.User
{
    [ModuleExport(typeof(ModuleUser))]
    public class ModuleUser : AModule, IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<IUserListView>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            RegionManager.RegisterViewWithRegion("MainRegion", typeof(IUserListView));
        }
    }
}
