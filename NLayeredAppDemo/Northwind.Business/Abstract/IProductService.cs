using Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(int productId);
        List<Product> GetAll();
        List<Product> GetProductsByCategory(int categoryId);
        List<Product> GetProductsByName(string text);
        void Update(Product product);
    }
}
