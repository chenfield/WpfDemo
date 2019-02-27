using System.Windows.Controls;
using System.ComponentModel.Composition;

namespace WpfDemo.UI.User
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
