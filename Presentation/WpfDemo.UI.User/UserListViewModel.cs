using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Windows.Input;
using Prism.Mvvm;
using WpfDemo.Business;
using WpfDemo.Common;
using WpfDemo.Data;

namespace WpfDemo.UI.User
{
    /// <summary>
    /// 操作用户
    /// </summary>
    [Export(typeof(IUserListViewModel))]
    public class UserListViewModel : BindableBase, IUserListViewModel
    {
        /// <summary>
        /// 用户页面
        /// </summary>
        //[Import]
        public IUserListView View { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        private ObservableCollection<Entities.User> _users = new ObservableCollection<Entities.User>();

        /// <summary>
        /// 增加用户事件
        /// </summary>
        public ICommand AddCmd => new DelegateCmd(Add_Command);

        /// <summary>
        /// 用户业务类实例
        /// </summary>
        [Import]
        public Lazy<IUserBll> _userBll;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="userBll"></param>
        [ImportingConstructor]
        public UserListViewModel(IUserListView view)
        {
            View = view;
            View.ViewModel = this;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void Load()
        {  
            //得到用户列表
            UserItems = new ObservableCollection<Entities.User>(_userBll.Value.GetList());
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        public ObservableCollection<Entities.User> UserItems
        {
            get { return _users; }
            set { SetProperty(ref _users, value); }
        }

        /// <summary>
        /// 增加用户
        /// </summary>
        private void Add_Command()
        {
            _userBll.Value.Add(new Entities.User(){Name = "First"});
            Load();
        }
    }
}
