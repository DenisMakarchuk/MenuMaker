using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MenuMaker.Back.Data
{
    public static class DataExtensions
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services, IConfiguration config)
        {
            return services;
        }
    }
}
