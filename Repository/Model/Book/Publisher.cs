namespace Repository.Model.Book;

public class Publisher
{
    public int Id { get; set; }
    public string PublisherName { get; set; } = null!;
    public IEnumerable<Book> Books { get; set; }
}