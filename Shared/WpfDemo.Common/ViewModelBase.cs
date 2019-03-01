using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Prism.Mvvm;
using Prism.Regions;

namespace WpfDemo.Common
{
    /// <summary>
    /// 基类
    /// </summary>
    public class ViewModelBase : BindableBase
    {
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

            //RegionManager.RegisterViewWithRegion(regionName, () => newCtrl);
            region.Activate(newCtrl);
        }
    }
}
