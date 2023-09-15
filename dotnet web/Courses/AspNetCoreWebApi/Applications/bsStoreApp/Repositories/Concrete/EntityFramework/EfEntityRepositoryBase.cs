using Entities.Abstract;
using Repositories.Abstract;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Repositories.Concrete.EntityFramework
{
    public abstract class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        protected readonly EfRepositoryContext _context;
        protected EfEntityRepositoryBase(EfRepositoryContext context)
        {
            _context = context;
        }
        public List<TEntity> GetList(Expression<Func<TEntity, bool>>? expression = null, bool trackChanges = true)
        {
            if (expression is null)
            {
                return !trackChanges ? _context.Set<TEntity>().AsNoTracking().ToList() : _context.Set<TEntity>().ToList();
            }
            else
            {
                return !trackChanges ? _context.Set<TEntity>().Where(expression).AsNoTracking().ToList() : _context.Set<TEntity>().Where(expression).ToList();
            }
        }

        public TEntity? Get(Expression<Func<TEntity?, bool>> expression, bool trackChanges = true) =>
            !trackChanges
                ? _context.Set<TEntity>().AsNoTracking().SingleOrDefault(expression)
                : _context.Set<TEntity>().SingleOrDefault(expression);
        public TEntity Add(TEntity entity) => _context.Set<TEntity>().Add(entity).Entity;
        public TEntity Update(TEntity entity) => _context.Set<TEntity>().Update(entity).Entity;
        public void Delete(TEntity entity) => _context.Set<TEntity>().Remove(entity);
    }
}
