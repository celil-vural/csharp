using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }
        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                Product product = context.Products.FirstOrDefault(item => item.Id == id);
                return product;
            }
        }
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(item => item.Name.Contains(key)).ToList();
            }
        }
        public List<Product> GetByUnitPrice(decimal minPrice, decimal maxPrice)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(item => item.UnitPrice >= minPrice && item.UnitPrice <= maxPrice).ToList();
            }
        }
        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
