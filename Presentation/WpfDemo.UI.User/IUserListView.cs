using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo.UI.User
{
    /// <summary>
    /// 用户页面接口
    /// </summary>
    public interface IUserListView
    {
        /// <summary>
        /// 用户操作类
        /// </summary>
        IUserListViewModel ViewModel { set; get; }
    }
}
