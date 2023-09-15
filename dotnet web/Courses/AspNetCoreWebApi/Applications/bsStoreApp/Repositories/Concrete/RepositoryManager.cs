using Repositories.Abstract;
using Repositories.Concrete.EntityFramework;
namespace Repositories.Concrete
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly EfRepositoryContext _context;
        private readonly Lazy<IBookRepository> _bookRepository;
        public RepositoryManager(EfRepositoryContext context)
        {
            _context = context;
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(_context));
        }
        public IBookRepository BookRepository => _bookRepository.Value;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
