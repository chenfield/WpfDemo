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
        //[Import]
        public IUserBll _userBll;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        /// <param name="userBll"></param>
        [ImportingConstructor]
        public UserListViewModel(IUserListView view)
        {
            Load();

            //得到用户业务实例
            _userBll = new UserBll(new UserDal());

            View = view;
            View.ViewModel = this;

            //得到用户列表
            UserItems = new ObservableCollection<Entities.User>(_userBll.GetList());
        }

        public void Load()
        {
            //加载Modules目录
            if (Directory.Exists("./Modules"))
            {
                //this.AggregateCatalog.Catalogs.Add(new DirectoryCatalog("./Modules"));

                var catalog = new DirectoryCatalog("./Modules");
                var container = new CompositionContainer(catalog);
                container.ComposeParts(this);
            }
        }

        /// <summary>
        /// 得到用户列表
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
            _userBll.Add(new Entities.User(){Name = "First"});

            UserItems = new ObservableCollection<Entities.User>(_userBll.GetList());
        }
    }
}
