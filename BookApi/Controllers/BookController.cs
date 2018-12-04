using System.Collections.Generic;
using System.Linq;
using BookApi.Models;
using BookApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
  [Produces("application/json")]
  [Route("api/[controller]")]
  [ApiController]
  public class BooksController : ControllerBase
  {
    private readonly IBookService _bookService;

    public BooksController(IBookService bookService)
    {
      _bookService = bookService;
    }

    [HttpGet]
    public ActionResult<List<Book>> GetAll() => _bookService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Book> GetByISBN(string id)
    {
      var book = _bookService.GetByISBN(id);

      if (book == null)
      {
        return NotFound();
      }

      return book;
    }

    [HttpPost]
    public ActionResult<Book> Create(Book book)
    {
      var id = _bookService.Add(book);

      return CreatedAtAction(nameof(GetByISBN), new { id = id }, book);
    }
  }
}
