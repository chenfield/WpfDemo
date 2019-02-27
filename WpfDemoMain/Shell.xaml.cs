using System;
using System.ComponentModel.Composition;
using System.Windows;

namespace WpfDemoMain
{
    /// <summary>
    /// 主页面
    /// </summary>
    [Export(typeof(IShellView))]
    public partial class Shell : Window, IShellView
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public Shell()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 页面操作类
        /// </summary>
        [Import]
        public IShellViewModel ViewModel
        {
            set { DataContext = value; }
            get { return DataContext as IShellViewModel; }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosed(System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}