using Entities.DataTransferObject;
using Entities.Models;

namespace Services.Abstract
{
    public interface IBookService
    {
        IEnumerable<BookDto> GetAllBooks(bool trackChanges);
        BookDto GetBookById(int id, bool trackChanges);
        BookDto CreateBook(BookDtoForInsertion bookDto);
        void UpdateBook(int id, BookDtoUpdate bookDto, bool trackChanges);
        void DeleteBook(int id, bool trackChanges);
        (BookDtoUpdate bookDtoForUpdate, Book book) GetBookForPatch(int id, bool trackChanges);
        void SaveChangesForPatch(BookDtoUpdate bookDtoForUpdate, Book book);
    }
}
