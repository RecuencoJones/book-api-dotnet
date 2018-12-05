using System;
using System.Collections.Generic;
using System.Linq;
using BookApi.Models;

namespace BookApi.Repositories
{
  public class BookRepository : IBookRepository
  {
    private readonly BookContext _context;

    public BookRepository(BookContext context)
    {
      _context = context;
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
