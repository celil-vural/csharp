using Entities.Models;
using Repositories.Abstract;

namespace Repositories.Concrete.EntityFramework
{
    public class BookRepository : EfEntityRepositoryBase<Book>, IBookRepository
    {
        public BookRepository(EfRepositoryContext context) : base(context)
        {
        }
        public List<Book> GetAllBooks(bool trackChanges) => GetList(trackChanges: trackChanges);
        public Book GetOneBookById(int id, bool trackChanges)
        {
            return Get(expression: (b) => b.Id.Equals(id), trackChanges: trackChanges);
        }

        public void CreateOneBook(Book book) => Add(book);
        public void UpdateOneBook(Book book) => Update(book);

        public void DeleteOneBook(Book book) => Delete(book);
    }
}
