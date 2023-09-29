using Lektion15.Classes;

namespace Lektion15.Exceptions;

public class BookException : Exception
{
    public Book? Book { get; init; } = null;
    public BookException(string message) : base(message) { }
    public BookException(string message, Book book) : base(message)
    {
        Book = book;
    }
}