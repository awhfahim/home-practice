using Autofac;
using example2.web.Areas.Place.Models;

namespace example2.web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Add>().As<IAdd>()
                .InstancePerLifetimeScope();
            //builder.RegisterType<IndexModel>().AsSelf();
            base.Load(builder);
        }
    }
}
