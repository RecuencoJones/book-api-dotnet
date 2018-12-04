using System.Collections.Generic;
using BookApi.Models;

namespace BookApi.Repositories
{
  public interface IBookRepository
  {
    List<Book> FindAll();
    Book FindById(string id);
    string Add(Book book);
  }
}
