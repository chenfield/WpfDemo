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
    [ModuleExport(typeof(ModuleUser))]
    public class ModuleUser : IModule
    {
        [Import] private IUserListViewModel _viewModel;

        [Import]
        IRegionManager _regionManager;

        // 当Prism加载该模块时，它将通过MEF实例化该类，MEF将注入一个Region Manager实例
        //[ImportingConstructor]
        //public ModuleUser(IRegionManager regionManager)
        //{
        //    _regionManager = regionManager;
        //}

        //private readonly IComponentContext _builder;

        //public ModuleUser(IComponentContext builder, 
        //                  IEventAggregator eventAggregator, 
        //                  IRegionManager regionManager):base(eventAggregator, regionManager)
        //{
        //    _builder = builder;
        //}

        public void Initialize()
        {
            //var obj = _builder.Resolve<IUserListViewModel>();
            _regionManager.RegisterViewWithRegion("MainRegion", () => _viewModel.View);
            _viewModel.Load();
        }
    }
}
