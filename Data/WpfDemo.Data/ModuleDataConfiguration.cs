using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Core;
using Prism.Mef.Modularity;

namespace WpfDemo.Data
{
    /// <summary>
    /// 数据层注册类
    /// </summary>
    [Export(typeof(IModule))]
    public class ModuleDataConfiguration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();
        }
    }
}
