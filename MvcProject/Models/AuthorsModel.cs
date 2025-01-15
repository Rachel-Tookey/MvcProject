using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using MvcProject.Models.Entity;
using MvcProject.Repositories;

namespace MvcProject.Models
{
    public class AuthorsModel
    {
        private MyDbContext _db;

        public AuthorsModel(MyDbContext db)
        {
            _db = db; 
        }


        public List<Author> FetchAuthors()
        {
            return _db.Authors.ToList(); 
        }

        public Author? FetchAuthorById(int id)
        {
            return _db.Authors.Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddAuthor(Author author)
        {
            _db.Authors.Add(author);
            _db.SaveChanges(); 
        }

        public void DeleteAuthor(int id)
        {
            Author? authorToRemove = _db.Authors.Where(x => x.Id == id).FirstOrDefault();
            
            if (authorToRemove != null)
            {
                _db.Authors.Remove(authorToRemove);
                _db.SaveChanges();
            }
        }

        public Author GetBooksByAuthor(int id)
        {
            var test = _db.Authors.Where(x => x.Id == id).Include(x => x.Books).First();
            return test; 
        }


    }
}
