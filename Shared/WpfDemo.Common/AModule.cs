using System.ComponentModel.Composition;
using Prism.Events;
using Prism.Regions;

namespace WpfDemo.Common
{
    public abstract class AModule
    {
        [Import]
        protected IEventAggregator EventAggregator;

        [Import]
        protected IRegionManager RegionManager;
    }
}
