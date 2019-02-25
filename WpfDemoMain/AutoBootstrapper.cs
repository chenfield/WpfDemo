﻿using System;
using System.Windows;
using Autofac;
using Prism.Autofac;
using Prism.Modularity;
using WpfDemo.Business;
using WpfDemo.Data;

namespace WpfDemoMain
{
    public class AutoBootstrapper : AutofacBootstrapper
    {
        protected override void ConfigureContainerBuilder(ContainerBuilder builder)
        {
            base.ConfigureContainerBuilder(builder);
            builder.RegisterType<Shell>();

            // register autofac module
            builder.RegisterModule<ModuleDataConfiguration>();
            builder.RegisterModule<ModuleBusinessConfiguration>();
        }


        protected override IModuleCatalog CreateModuleCatalog()
        {
            var uri = new Uri("/WpfDemoMain;Component/ModulesCatalog.xaml", UriKind.Relative);
            return Prism.Modularity.ModuleCatalog.CreateFromXaml(uri);
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }
    }
}
