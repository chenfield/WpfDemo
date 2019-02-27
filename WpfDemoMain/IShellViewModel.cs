
namespace WpfDemoMain
{
    /// <summary>
    /// Shell页面操作类
    /// </summary>
    public interface IShellViewModel
    {
        /// <summary>
        /// 页面
        /// </summary>
        IShellView View { set; get; }
    }
}
