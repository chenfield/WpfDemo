using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.Common;
using WpfDemo.Business;
using System.Windows.Input;

namespace WpfDemoMain
{

    public class MainWindowViewModel
    {
        public ICommand AddCommand => new DelegateCmd(Add_Command);

        private void Add_Command()
        {
            UserBll user = new UserBll();
            user.Add(new WpfDemo.Entities.User() { Name = "First" });
        }
    }
}
