using AutoMapper;
using Entities.DataTransferObject;
using Entities.Exceptions;
using Entities.Models;
using Repositories.Abstract;
using Services.Abstract;

namespace Services
{
    public class BookManager : IBookService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerService _loggerService;
        private readonly IMapper _mapper;

        public BookManager(IRepositoryManager repositoryManager, ILoggerService loggerService, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _loggerService = loggerService;
            _mapper = mapper;
        }

        public IEnumerable<BookDto> GetAllBooks(bool trackChanges)
        {
            var books = _repositoryManager.BookRepository.GetAllBooks(trackChanges);
            return _mapper.Map<IEnumerable<BookDto>>(books);
        }

        public BookDto GetBookById(int id, bool trackChanges)
        {
            var book = _repositoryManager.BookRepository.GetOneBookById(id, trackChanges);
            if (book is null) throw new BookNotFoundException(id);
            return _mapper.Map<BookDto>(book);
        }

        public BookDto CreateBook(BookDtoForInsertion bookDto)
        {
            var entity = _mapper.Map<Book>(bookDto);
            _repositoryManager.BookRepository.CreateOneBook(entity);
            _repositoryManager.Save();
            return _mapper.Map<BookDto>(entity);
        }

        public void UpdateBook(int id, BookDtoUpdate bookDto, bool trackChanges)
        {
            var entity = _repositoryManager.BookRepository.GetOneBookById(id, trackChanges);
            if (entity == null)
            {
                throw new BookNotFoundException(id);
            }
            if (bookDto is null)
            {
                string message = $"The bookDto is null.";
                throw new ArgumentNullException(nameof(bookDto));
            }
            //Mapping 
            //entity.Title = bookDto.Title;
            //entity.Price = bookDto.Price;
            _mapper.Map(bookDto, entity);
            _repositoryManager.BookRepository.Update(entity);
            _repositoryManager.Save();
        }

        public void DeleteBook(int id, bool trackChanges)
        {
            var entity = _repositoryManager.BookRepository.GetOneBookById(id, trackChanges);
            if (entity == null)
            {
                throw new BookNotFoundException(id);
            }
            _repositoryManager.BookRepository.DeleteOneBook(entity);
            _repositoryManager.Save();
        }

        public (BookDtoUpdate bookDtoForUpdate, Book book) GetBookForPatch(int id, bool trackChanges)
        {
            var book = _repositoryManager.BookRepository.GetOneBookById(id, trackChanges);
            if (book is null) throw new BookNotFoundException(id);
            var bookDtoForUpdate = _mapper.Map<BookDtoUpdate>(book);
            return (bookDtoForUpdate, book);
        }

        public void SaveChangesForPatch(BookDtoUpdate bookDtoForUpdate, Book book)
        {
            _mapper.Map(bookDtoForUpdate, book);
            _repositoryManager.Save();
        }
    }
}
