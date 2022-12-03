using System.Linq.Expressions;
using Repository.Model.Book;

namespace Repository.Repositories;

public interface IAuthorRepository
{
    Task<IEnumerable<Author>> GetAuthorsAsync(Expression<Func<Author, bool>>? expression);
    Task<Author?> GetById(int id);
}