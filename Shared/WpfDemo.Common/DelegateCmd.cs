using System;
using System.Windows.Input;

namespace WpfDemo.Common
{
    /// <summary>
    /// 事件委托类
    /// </summary>
    public class DelegateCmd : ICommand
    {
        private readonly Action _action;

        public DelegateCmd(Action action)
        {
            _action = action;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged { add { } remove { } }
#pragma warning restore 67
    }
}
