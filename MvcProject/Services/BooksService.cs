using MvcProject.Models;
using MvcProject.Models.Entity;

namespace MvcProject.Services
{
    public class BooksService
    {
        private readonly BooksModel _booksModel;

        public BooksService(BooksModel booksModel)
        {
            _booksModel = booksModel;
        }

        public List<Book> GetAllBooks()
        {
            return _booksModel.FetchBooks();
        }

        public List<Book> GetBooksByAuthor(int authorId)
        {
            return _booksModel.FetchBooksByAuthor(authorId);
        }

        public void AddBook(Book book)
        {
            _booksModel.AddBook(book);
        }
    }
}
