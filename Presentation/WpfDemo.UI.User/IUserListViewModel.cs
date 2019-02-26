using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo.UI.User
{
    /// <summary>
    /// 用户操作类接口
    /// </summary>
    public interface IUserListViewModel
    {
        /// <summary>
        /// 用户页面
        /// </summary>
        IUserListView View { set; get; }

        void Load();
    }
}
