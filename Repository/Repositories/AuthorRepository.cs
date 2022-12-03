using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Repository.Model.Book;

namespace Repository.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly BookStoreDbContext _dbContext;

    public AuthorRepository(BookStoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Author>> GetAuthorsAsync(Expression<Func<Author, bool>>? expression)
    {
        if (expression == null)
        {
            return await _dbContext.Authors!.ToArrayAsync();
        }

        return await _dbContext.Authors!.Where(expression).ToArrayAsync();
    }

    public async Task<Author?> GetById(int id)
    {
        return await _dbContext.Authors!.Where(x => x.Id == id).FirstOrDefaultAsync();
    }
}