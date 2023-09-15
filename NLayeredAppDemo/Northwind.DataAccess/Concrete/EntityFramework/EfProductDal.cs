using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {

    }
}
