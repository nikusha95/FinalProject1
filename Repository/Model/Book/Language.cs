namespace Repository.Model.Book;

public class Language
{
    public int Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public IEnumerable<Book> Books { get; set; }
}