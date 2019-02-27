using System.Windows;

namespace WpfDemoMain
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// 起动方法
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MefBootstrapper bootstrapper = new MefBootstrapper();
            bootstrapper.Run();
        }
    }
}
