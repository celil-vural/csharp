using FluentValidation;
using Northwind.Entities.Abstract;

namespace Northwind.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate<T>(AbstractValidator<T> validator, T entity) where T : class, IEntity, new()
        {
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                foreach (var variable in result.Errors)
                {
                    throw new ValidationException(variable.ErrorMessage);
                }
            }
        }
    }
}
