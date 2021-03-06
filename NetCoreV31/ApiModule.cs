using Autofac;

using NetCoreV31.Interfaces;
using NetCoreV31.Services;

namespace NetCoreV31
{
    public class ApiModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RequestValidationService>().As<IRequestValidationService>();
        }
    }
}