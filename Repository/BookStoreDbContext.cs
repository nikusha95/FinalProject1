using Microsoft.EntityFrameworkCore;
using Repository.Configurations;
using Repository.Model;
using Repository.Model.Book;

namespace Repository;

public class BookStoreDbContext : DbContext
{
    public DbSet<Book>? Books { get; set; }
    public DbSet<Author>? Authors { get; set; }
    public DbSet<BookAuthor>? BookAuthors { get; set; }
    public DbSet<Language>? Languages { get; set; }
    public DbSet<Publisher>? Publishers { get; set; }
    
    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
    {
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BookConfiguration).Assembly);
    }
}