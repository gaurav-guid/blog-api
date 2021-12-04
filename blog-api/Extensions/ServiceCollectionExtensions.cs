using blog_dataHelper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog_api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureDb(this IServiceCollection services, Action<DBConfiguration> configure)
        {
            DBConfigurer.ConfigureDB(configure);
            return services;
        }
    }
}
