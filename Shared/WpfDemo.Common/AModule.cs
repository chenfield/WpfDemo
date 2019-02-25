using System;
using System.Windows.Controls;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;
using System.ComponentModel.Composition;

namespace WpfDemo.Common
{
    public abstract class AModule : IModule
    {
        [Import]
        protected IEventAggregator EventAggregator;
        [Import]
        protected IRegionManager RegionManager;



        //protected AModule(IEventAggregator eventAggregator, IRegionManager regionManager)

        //{

        //    RegionManager = regionManager;

        //    EventAggregator = eventAggregator;

        //}



        public void ReplaceMainRegion(ContentControl newCtrl)

        {

            ReplaceRegion(newCtrl, "MainRegion");

        }



        public void ReplaceRegion(ContentControl newCtrl, string regionName)

        {

            if (RegionManager == null) return;

            if (!RegionManager.Regions.ContainsRegionWithName(regionName)) return;



            var region = RegionManager.Regions[regionName];

            region.RemoveAll();



            RegionManager.RegisterViewWithRegion(regionName, () => newCtrl);

            region.Activate(newCtrl);

        }



        public abstract void Initialize();
    }
}
