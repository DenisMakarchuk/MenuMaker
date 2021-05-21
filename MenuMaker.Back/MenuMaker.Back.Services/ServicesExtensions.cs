using MenuMaker.Back.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MenuMaker.Back.Services
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDataServices(config);
            return services;
        }
    }
}
