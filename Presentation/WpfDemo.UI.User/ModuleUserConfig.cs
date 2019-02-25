using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace WpfDemo.UI.User
{
    public class ModuleUserConfig : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
            //builder.RegisterType<ModuleUser>();
            builder.RegisterType<UserListView>().As<IUserListView>().OwnedByLifetimeScope();
            builder.RegisterType<UserListViewModel>().As<IUserListViewModel>().OwnedByLifetimeScope();
        }

    }
}
