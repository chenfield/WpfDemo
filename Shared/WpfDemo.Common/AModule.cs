using System.Windows.Controls;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace WpfDemo.Common
{
    /// <summary>
    /// Module基类
    /// </summary>
    public abstract class AModule : IModule
    {
        /// <summary>
        /// 调入EventAggregator
        /// </summary>
        [Import]
        protected IEventAggregator EventAggregator;

        /// <summary>
        /// 调入RegionManager
        /// </summary>
        [Import]
        protected IRegionManager RegionManager;

        /// <summary>
        /// 替换页面主区域
        /// </summary>
        /// <param name="newCtrl"></param>
        public void ReplaceMainRegion(ContentControl newCtrl)
        {
            ReplaceRegion(newCtrl, "MainRegion");
        }
        
        /// <summary>
        /// 替换页面区域
        /// </summary>
        /// <param name="newCtrl"></param>
        /// <param name="regionName"></param>
        public void ReplaceRegion(ContentControl newCtrl, string regionName)
        {
            if (RegionManager == null) return;
            if (!RegionManager.Regions.ContainsRegionWithName(regionName)) return;
            
            var region = RegionManager.Regions[regionName];
            //region.RemoveAll();

            if (!region.Views.Contains(newCtrl))
                RegionManager.AddToRegion(regionName, newCtrl);

            RegionManager.RegisterViewWithRegion(regionName, () => newCtrl);
            region.Activate(newCtrl);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public abstract void Initialize();
    }
}
