using Autofac;
using Revise.web.Areas.Admin.Models;

namespace Revise.web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Add>().As<IAdd>()
                .InstancePerLifetimeScope();
            builder.RegisterType<Remove>().As<IRemove>()
                .InstancePerLifetimeScope();

            
            base.Load(builder);
        }
    }
}
