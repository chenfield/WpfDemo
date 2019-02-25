using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Prism.Mef.Modularity;

namespace WpfDemo.Business
{
    /// <summary>
    /// 业务层注册类
    /// </summary>
    public class ModuleBusinessConfiguration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<UserBll>().As<IUserBll>().SingleInstance();
        }
    }
}
