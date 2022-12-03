using System.ComponentModel;

namespace Repository.Model.Book;

public class BookAuthor
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int AuthorId { get; set; }
    public Book Book { get; set; }
    public Author Author { get; set; }
}