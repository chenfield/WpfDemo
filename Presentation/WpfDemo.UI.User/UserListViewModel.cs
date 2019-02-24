using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using Prism.Mvvm;
using WpfDemo.Business;

namespace WpfDemo.UI.User
{
    /// <summary>
    /// 
    /// </summary>
    [Export(typeof(IUserListViewModel))]
    public class UserListViewModel : BindableBase, IUserListViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public IUserListView View { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<Entities.User> _users = new ObservableCollection<Entities.User>();

        UserBll bll = new UserBll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="view"></param>
        [ImportingConstructor]
        public UserListViewModel(IUserListView view)
        {
            View = view;
            View.ViewModel = this;
            //DeleteCommand = new DelegateCommand<ComboItem>(Delete_Command);

            UserItems = new ObservableCollection<Entities.User>(bll.GetUsers());
        }

        public ObservableCollection<Entities.User> UserItems
        {
            get { return _users; }
            set { SetProperty(ref _users, value); }
        }
    }
}
