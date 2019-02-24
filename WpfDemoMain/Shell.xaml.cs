using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Windows;

namespace Wams.UI.WpfAutomation
{
    /// <summary>
    ///     MainWindow.xaml 的交互逻辑
    /// </summary>

    [Export(typeof(IShellView))]
    public partial class Shell : Window, IShellView
    {
        public Shell()
        {
            InitializeComponent();
        }
        
        //[Import]
        public IShellViewModel ViewModel
        {
            set { DataContext = value; }
            get { return DataContext as IShellViewModel; }
        }

        protected override void OnClosed(System.EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}