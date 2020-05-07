using System.Data;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProductCatalogService.Application.Interfaces.Persistence;
using ProductCatalogService.Infrastructure.Persistence;

namespace ProductCatalogService.Infrastructure
{
    public static class IocBootstrapper
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddTransient<IDbConnection>(connection =>
                new SqliteConnection(configuration.GetValue<string>("ConnectionStrings:SqliteConnection")));
        }
    }
}