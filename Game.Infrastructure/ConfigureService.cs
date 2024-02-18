using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Infrastructure
{
    public static class ConfigureService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Scan(
              scan =>
                  scan.FromAssemblies(typeof(IInfrastructureAssemblyMarker).Assembly)
                      .AddClasses(
                          @class =>
                              @class.Where(
                                  type => !type.Name.StartsWith('I') && type.Name.EndsWith("Repository")))
                      .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                      .AsImplementedInterfaces()
                      .WithScopedLifetime());

            return services;
        }
    }
}
