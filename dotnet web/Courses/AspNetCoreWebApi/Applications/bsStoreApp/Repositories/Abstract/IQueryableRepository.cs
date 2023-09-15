using Entities.Abstract;

namespace Repositories.Abstract
{
    public interface IQueryableRepository<out T> where T : class, IEntity, new()
    {
        IQueryable<T> Table { get; }
    }
}
