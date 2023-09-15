using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            /*ProductValidator validator = new ProductValidator();
            var result = validator.Validate(product);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors.ToString());
            }*/
            _productDal.Add(product);
        }
        public void Delete(int productId)
        {
            try
            {
                _productDal.Delete(p => p.ProductId == productId);
            }
            catch (Exception e)
            {
                throw new Exception("The delete is failed");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByName(string text)
        {
            return string.IsNullOrEmpty(text) ? _productDal.GetAll() : _productDal.GetAll(p => p.ProductName.ToLower().Contains(text.ToLower()));
        }

        public void Update(Product product)
        {
            ValidationTool.Validate<Product>(new ProductValidator(), product);
            _productDal.Update(product);
        }
    }
}
