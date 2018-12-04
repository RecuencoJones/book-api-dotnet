using System.Collections.Generic;
using BookApi.Models;

namespace BookApi.Services
{
  public interface IBookService
  {
    List<Book> GetAll();
    Book GetByISBN(string id);
    string Add(Book book);
  }
}
