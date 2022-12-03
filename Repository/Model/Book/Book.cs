namespace Repository.Model.Book;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public int? LanguageId { get; set; }
    public int NumberPages { get; set; }
    public DateTime PublicationDate { get; set; }
    public int? PublisherId { get; set; }
    public Publisher Publisher { get; set; }
    public IEnumerable<BookAuthor> BookAuthors { get; set; }
    public Language? Language { get; set; }
}