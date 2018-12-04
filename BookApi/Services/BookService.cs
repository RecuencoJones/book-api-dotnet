using System.Collections.Generic;
using System.Linq;
using BookApi.Models;

namespace BookApi.Services
{
  public class BookService
  {
    private readonly BookContext _context;

    public BookService(BookContext context)
    {
      this._context = context;
    }

    public List<Book> FindAll() => _context.Books.ToList();

    public Book FindById(string isbn) => _context.Books.Find(isbn);

    public string Add(Book book)
    {
      _context.Books.Add(book);
      _context.SaveChanges();

      return book.ISBN;
    }
  }
}
