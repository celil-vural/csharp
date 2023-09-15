using FluentValidation;
using Northwind.Entities.Concrete;
namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Product name can't empty");
            RuleFor(p => p.CategoryId).NotEmpty().WithMessage("Product category can't empty");
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage("Product price can't empty");
            RuleFor(p => p.UnitPrice).GreaterThan(0).WithMessage("Product price must greater then 0");
            RuleFor(p => p.QuantityPerUnit).NotEmpty().WithMessage("Product quantity can't empty");
            RuleFor(p => p.UnitsInStock).NotEmpty().WithMessage("Product stock can't empty");
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
        }
    }
}
