using System.ComponentModel.Composition;
using Prism.Mvvm;

namespace WpfDemoMain
{
    /// <summary>
    /// 页面操作类
    /// </summary>
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : BindableBase, IShellViewModel
    {
        /// <summary>
        /// 页面标题初始值
        /// </summary>
        private string _appTitle = "Demo";

        /// <summary>
        /// 页面标题
        /// </summary>
        public string AppTitle
        {
            get { return _appTitle; }
            set { SetProperty(ref _appTitle, value); }
        }

        /// <summary>
        /// 初始化
        /// </summary>
        [ImportingConstructor]
        public ShellViewModel()
        {
            //View = view;
            //View.ViewModel = this;
            AppTitle = _appTitle;
        }

        /// <summary>
        /// 调入页面
        /// </summary>
        [Import]
        public IShellView View { get; set; }
    }
}