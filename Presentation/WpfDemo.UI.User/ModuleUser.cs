using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;
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
    /// <summary>
    /// 
    /// </summary>
    [ModuleExport(typeof(ModuleUser))]
    public class ModuleUser : IModule
    {
        [Import] private IUserListViewModel _viewModel;

        [Import]
        IRegionManager _regionManager;

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("MainRegion", () => _viewModel.View);
            _viewModel.Load();
        }
    }
}
