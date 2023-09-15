using Entities.Abstract;
using System.Linq.Expressions;

namespace Repositories.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> expression = null, bool trackChanges = true);
        T? Get(Expression<Func<T?, bool>> expression, bool trackChanges = true);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
