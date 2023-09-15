using Entities.Models;

namespace Repositories.Abstract
{
    public interface IBookRepository : IEntityRepository<Book>
    {
        List<Book> GetAllBooks(bool trackChanges);
        Book? GetOneBookById(int id, bool trackChanges);
        void CreateOneBook(Book book);
        void UpdateOneBook(Book book);
        void DeleteOneBook(Book book);
    }
}
