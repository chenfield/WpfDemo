using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemoMain
{
    public interface IShellView
    {
        IShellViewModel ViewModel { set; get; }
    }
}
