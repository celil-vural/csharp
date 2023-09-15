using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Concrete.EntityFramework.Config;

namespace Repositories.Concrete.EntityFramework
{
    public class EfRepositoryContext : DbContext
    {
        public EfRepositoryContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
