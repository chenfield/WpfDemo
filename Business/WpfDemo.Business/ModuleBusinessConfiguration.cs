using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using Autofac;
using Autofac.Core;

namespace WpfDemo.Business
{
    /// <summary>
    /// 业务层注册类
    /// </summary>
    [Export(typeof(IModule))]
    public class ModuleBusinessConfiguration : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<UserBll>().As<IUserBll>().SingleInstance();
        }
    }
}
