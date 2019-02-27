
namespace WpfDemo.UI.User
{
    /// <summary>
    /// 用户操作类接口
    /// </summary>
    public interface IUserListViewModel
    {
        /// <summary>
        /// 用户页面
        /// </summary>
        IUserListView View { set; get; }

        /// <summary>
        /// 数据调入
        /// </summary>
        void Load();
    }
}
