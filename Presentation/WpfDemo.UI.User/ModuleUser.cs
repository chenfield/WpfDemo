using System.ComponentModel.Composition;
using Prism.Mef.Modularity;
using WpfDemo.Common;
using WpfDemo.UI.User.Interface;

namespace WpfDemo.UI.User
{
    /// <summary>
    /// 用户组件类
    /// </summary>
    [ModuleExport(typeof(ModuleUser))]
    public class ModuleUser : AModule
    {
        /// <summary>
        /// 用户操作类
        /// </summary>
        [Import] private IUserListViewModel _viewModel;

        /// <summary>
        /// 用户组件初始调入
        /// </summary>
        public override void Initialize()
        {
            RegionManager.RegisterViewWithRegion("MainRegion", () => _viewModel.View);
            _viewModel.Load();
        }
    }
}
