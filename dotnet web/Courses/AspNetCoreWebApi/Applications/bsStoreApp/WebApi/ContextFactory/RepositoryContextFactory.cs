using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repositories.Concrete.EntityFramework;

namespace WebApi.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<EfRepositoryContext>
    {
        public EfRepositoryContext CreateDbContext(string[] args)
        {
            //configurationBuilder
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            //DbContextOptionsBuilder
            var builder = new DbContextOptionsBuilder<EfRepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
                    prj => prj.MigrationsAssembly("WebApi"));
            return new EfRepositoryContext(builder.Options);
        }
    }
}
