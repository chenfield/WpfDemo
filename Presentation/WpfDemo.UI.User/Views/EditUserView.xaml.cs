using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDemo.UI.User.Interface;

namespace WpfDemo.UI.User.Views
{
    /// <summary>
    /// EditUserView.xaml 的交互逻辑
    /// </summary>
    [Export(typeof(IEditUserView))]
    public partial class EditUserView : UserControl, IEditUserView
    {
        public EditUserView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户操作类
        /// </summary>
        [Import]
        public IEditUserViewModel ViewModel
        {
            get { return DataContext as IEditUserViewModel; }
            set { DataContext = value; }
        }
    }
}
