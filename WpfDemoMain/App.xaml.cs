using System.Windows;

namespace Wams.UI.WpfAutomation
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            MefBootstrapper bootstrapper = new MefBootstrapper();
            bootstrapper.Run();
        }
    }
}
