using Entities.DataTransferObject;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;
namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IServiceManager _manager;

        public BooksController(IServiceManager manager)
        {
            _manager = manager;
        }


        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _manager.BookService.GetAllBooks(false);
            return Ok(books);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetBookById([FromRoute(Name = "id")] int id)
        {
            var book = _manager.BookService.GetBookById(id, false);
            return Ok(book);
        }
        [HttpPost]
        public IActionResult CreateBook([FromBody] BookDtoForInsertion bookDto)
        {
            if (bookDto is null) return BadRequest();
            if (!ModelState.IsValid) return UnprocessableEntity(ModelState);
            var book = _manager.BookService.CreateBook(bookDto);
            return StatusCode(201, book);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] BookDtoUpdate bookDto)
        {
            if (bookDto is null) return BadRequest();
            if (!ModelState.IsValid) return UnprocessableEntity(ModelState);
            _manager.BookService.UpdateBook(id, bookDto, false);
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteOneBooks([FromRoute(Name = "id")] int id)
        {
            _manager.BookService.DeleteBook(id, false);
            return NoContent();
        }
        [HttpPatch("{id:int}")]
        public IActionResult PartiallyUpdateOneBook(
            [FromRoute(Name = "id")] int id,
            [FromBody] JsonPatchDocument<BookDtoUpdate> bookPatch
            )
        {
            if (bookPatch is null) return BadRequest();
            var result = _manager.BookService.GetBookForPatch(id, true);
            bookPatch.ApplyTo(result.bookDtoForUpdate, ModelState);
            TryValidateModel(result.bookDtoForUpdate);
            if (!ModelState.IsValid) return UnprocessableEntity(ModelState);
            _manager.BookService.SaveChangesForPatch(result.bookDtoForUpdate, result.book);
            return NoContent();
        }
    }
}
