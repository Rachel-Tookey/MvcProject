using MvcProject.Models;
using MvcProject.Models.Entity;

namespace MvcProject.Services
{
    public class AuthorsService
    {

        private readonly AuthorsModel _authorModel; 

        public AuthorsService(AuthorsModel authorModel)
        {
            _authorModel = authorModel;
        }

        public Author GetAuthorById(int id)
        {
            return _authorModel.FetchAuthorById(id);
        }

        public List<Author> GetAllAuthors()
        {
            return _authorModel.FetchAuthors(); 
        }

        public void AddAuthor(Author author)
        {
            _authorModel.AddAuthor(author);   
        }

        public void DeleteAuthor(int id)
        {
            _authorModel.DeleteAuthor(id);
        }

        public Author GetBooksByAuthor(int id)
        {
            return _authorModel.GetBooksByAuthor(id);
        }


    }
}
