using System.Data.Entity;

namespace EntityFrameworkDemo
{
    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
