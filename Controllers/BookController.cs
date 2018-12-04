using System.Collections.Generic;
using System.Linq;
using BookApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
  [Produces("application/json")]
  [Route("api/books")]
  [ApiController]
  public class BookController : ControllerBase
  {
    private readonly BookContext _context;

    public BookController(BookContext context)
    {
      _context = context;
    }

    [HttpGet]
    public ActionResult<List<Book>> GetAll()
    {
      return _context.Books.ToList();
    }

    [HttpGet("{id}")]
    public ActionResult<Book> GetByISBN(string id)
    {
      var book = _context.Books.Find(id);

      if (book == null)
      {
        return NotFound();
      }

      return book;
    }

    [HttpPost]
    public ActionResult<Book> Create(Book book)
    {
      _context.Books.Add(book);
      _context.SaveChanges();

      return CreatedAtAction(nameof(GetByISBN), new { id = book.ISBN }, book);
    }
  }
}
