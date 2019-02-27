using System;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using WpfDemo.Business;
using WpfDemo.Common;

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

        #region  事件绑定

        /// <summary>
        /// 增加用户事件
        /// </summary>
        public ICommand AddCmd => new DelegateCmd(Add_Command);

        /// <summary>
        /// 删除事件
        /// </summary>
        public ICommand DeleteCmd => new DelegateCmd(Delete_Command);

        /// <summary>
        /// 更新事件
        /// </summary>
        public ICommand UpdateCmd => new DelegateCmd(Update_Command);

        /// <summary>
        /// 保存事件
        /// </summary>
        public ICommand SaveCmd => new DelegateCmd(Save_Command);

        /// <summary>
        /// 取消事件
        /// </summary>
        public ICommand CancelCmd => new DelegateCmd(Cancel_Command);
        
        #endregion

        /// <summary>
        /// 选中用户
        /// </summary>
        private Entities.User _selectItem;

        /// <summary>
        /// 选中的用户
        /// </summary>
        public Entities.User SelectItem
        {
            get { return _selectItem; }
            set { SetProperty(ref _selectItem, value); }
        }

        /// <summary>
        /// 用户业务类实例
        /// </summary>
        [Import]
        private Lazy<IUserBll> _userBll;

        /// <summary>
        /// 弹出窗口
        /// </summary>
        private readonly Popup _popup;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="view"></param>
        [ImportingConstructor]
        public UserListViewModel(IUserListView view)
        {
            View = view;
            View.ViewModel = this;
            _popup = ((UserControl)View).FindName("PopupDetails") as Popup;
        }

        /// <summary>
        /// 数据调入
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
            SelectItem = null;
            PopupOpration(true);
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        private void Delete_Command()
        {
            if (SelectItem == null) return;
            //删除
            SelectItem = null;
        }

        /// <summary>
        /// 更新用户
        /// </summary>
        private void Update_Command()
        {
            if (SelectItem == null) return;
            PopupOpration(true);
        }

        /// <summary>
        /// 保存用户
        /// </summary>
        private void Save_Command()
        {
            if (SelectItem == null)
            {
                var tbxName = ((UserControl) View).FindName("TbxName") as TextBox;
                if (tbxName != null) _userBll.Value.Add(new Entities.User() {Name = tbxName.Text});
            }
            else
            {
                //更新
                SelectItem = null;
            }

            PopupOpration(false);
            Load();
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void Cancel_Command()
        {
            PopupOpration(false);
        }

        /// <summary>
        /// 弹出窗口操作
        /// </summary>
        /// <param name="isOpen"></param>
        private void PopupOpration(bool isOpen)
        {
            if (_popup == null) return;
            _popup.IsOpen = isOpen;
            ((UserControl)View).IsEnabled = !isOpen;
        }
    }
}
