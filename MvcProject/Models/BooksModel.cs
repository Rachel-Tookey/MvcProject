using Microsoft.EntityFrameworkCore;
using MvcProject.Models.Entity;
using MvcProject.Repositories;

namespace MvcProject.Models
{
    public class BooksModel
    {

        private MyDbContext _db;

        public BooksModel(MyDbContext db)
        {
            _db = db;
        }

        public List<Book> FetchBooks()
        {
            return _db.Books.Include(x => x.Author).ToList();
        }

        public List<Book> FetchBooksByAuthor(int id)
        {
            return _db.Books.Where(x => x.AuthorId == id).ToList();
        }

        public void AddBook(Book book)
        {
            _db.Books.Add(book);
        }
    }
}
