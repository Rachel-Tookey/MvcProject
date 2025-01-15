using Microsoft.AspNetCore.Mvc;
using MvcProject.Models.Entity;
using MvcProject.Services;

namespace MvcProject.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class BooksController : Controller
    {
        private readonly BooksService _booksService;

        public BooksController(BooksService booksService)
        {
            _booksService = booksService;
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(_booksService.GetAllBooks());
        }

        [HttpPost]
        public IActionResult PostBook(Book book)
        {
            _booksService.AddBook(book);
            return Ok();
        }


        [HttpGet("author/{id}")]
        public IActionResult GetBooksByAuthor(int id)
        {
            return Ok(_booksService.GetBooksByAuthor(id));
        }

    }
}
