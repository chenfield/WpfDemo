using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfDemo.Business;
using WpfDemo.Common;
using WpfDemo.UI.User.Interface;

namespace WpfDemo.UI.User.ViewModels
{
    /// <summary>
    /// 编辑用户操作类
    /// </summary>
    [Export(typeof(IEditUserViewModel))]
    public class EditUserViewModel : ViewModelBase, IEditUserViewModel
    {
        /// <summary>
        /// 用户编辑页面
        /// </summary>
        [Import] public IEditUserView View { get; set; }
        
        /// <summary>
        /// 用户业务类实例
        /// </summary>
        [Import] private Lazy<IUserBll> _userBll;

        /// <summary>
        /// 用户列表页面
        /// </summary>
        [Import] private IUserListViewModel UserListViewModel { get; set; }

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
        /// 保存事件
        /// </summary>
        public ICommand SaveCmd => new DelegateCmd(Save_Command);

        /// <summary>
        /// 取消事件
        /// </summary>
        public ICommand CancelCmd => new DelegateCmd(Cancel_Command);

        /// <summary>
        /// 保存用户
        /// </summary>
        private void Save_Command()
        {
            var tbxName = ((UserControl)View).FindName("TbxName") as TextBox;

            if (tbxName != null)
            {
                Entities.User user;

                user = SelectItem;
                user.Name = tbxName.Text;
                _userBll.Value.Update(user);
            }

            Cancel_Command();
        }

        /// <summary>
        /// 取消
        /// </summary>
        private void Cancel_Command()
        {
            SelectItem = null;
            ReplaceMainRegion(UserListViewModel.View as ContentControl);
            UserListViewModel.Load();
        }
    }
}
