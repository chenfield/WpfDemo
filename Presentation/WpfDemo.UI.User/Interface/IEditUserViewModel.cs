using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo.UI.User.Interface
{
    /// <summary>
    /// 编辑用户页面控制类接口
    /// </summary>
    public interface IEditUserViewModel
    {
        IEditUserView View { set; get; }

        Entities.User SelectItem { set; get; }
    }
}
