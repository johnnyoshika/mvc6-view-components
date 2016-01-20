using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web
{
    public static class AutofacConfig
    {
        public static IServiceProvider Register(IServiceCollection services)
        {
            var builder = new ContainerBuilder();
            builder.Populate(services);

            var container = builder.Build();

            return container.ResolveOptional<IServiceProvider>();
        }
    }
}
