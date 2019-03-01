using System.ComponentModel.Composition;
using System.Windows.Controls;
using WpfDemo.UI.User.Interface;

namespace WpfDemo.UI.User.Views
{
    /// <summary>
    /// 用户列表页
    /// </summary>
    [Export(typeof(IUserListView))]
    public partial class UserListView : UserControl, IUserListView
    {
        /// <summary>
        /// 初始化
        /// </summary>
        public UserListView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户操作类
        /// </summary>
        public IUserListViewModel ViewModel
        {
            get { return DataContext as IUserListViewModel; }
            set { DataContext = value; }
        }
    }
}
