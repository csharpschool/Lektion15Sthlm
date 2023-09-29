using Lektion15.Exceptions;

namespace Lektion15.Classes;

public class BookStore
{
    List<Book> _books = new();
    public List<Book> Books => _books.Select(b => (Book)b.Clone()).ToList();

    public void Add(Book book)
    {
        //if (book.Id < 1 || book.Title.Length < 3) return;
        if (book.Id < 1 || book.Title.Length < 3) 
            throw new BookException("Incorrect book info.", book);

        _books.Add(book);
    }
}
