using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemo.UI.User
{
    public interface IUserListViewModel
    {
        IUserListView View { set; get; }
    }
}
