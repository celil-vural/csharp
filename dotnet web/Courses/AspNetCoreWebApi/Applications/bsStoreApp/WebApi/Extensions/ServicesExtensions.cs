using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Concrete;
using Repositories.Concrete.EntityFramework;
using Services;
using Services.Abstract;

namespace WebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EfRepositoryContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("sqlConnection")
                )
            );
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        }

        public static void ConfigureServiceManager(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerService, LoggerManager>();
        }
    }
}
