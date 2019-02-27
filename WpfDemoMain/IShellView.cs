
namespace WpfDemoMain
{
    /// <summary>
    /// 页面类
    /// </summary>
    public interface IShellView
    {
        /// <summary>
        /// 操作类
        /// </summary>
        IShellViewModel ViewModel { set; get; }
    }
}
