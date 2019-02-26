using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using Prism.Events;
using Prism.Mvvm;

namespace WpfDemoMain
{
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : BindableBase, IShellViewModel
    {
        private string _appTitle = "Demo";

        public string AppTitle
        {
            get { return _appTitle; }
            set { SetProperty(ref _appTitle, value); }
        }

        [ImportingConstructor]
        public ShellViewModel()
        {
            //View = view;
            //View.ViewModel = this;
            AppTitle = _appTitle;
        }

        [Import]
        public IShellView View { get; set; }
    }
}