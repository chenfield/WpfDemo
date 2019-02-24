using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wams.UI.WpfAutomation
{
    public interface IShellViewModel
    {
        IShellView View { set; get; }
    }
}
