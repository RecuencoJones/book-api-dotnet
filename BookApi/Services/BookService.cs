using System.Collections.Generic;
using System.Linq;
using BookApi.Models;
using BookApi.Repositories;

namespace BookApi.Services
{
  public class BookService : IBookService
  {
    private readonly IBookRepository _repository;

    public BookService(IBookRepository Repository)
    {
      _repository = Repository;
    }

    public List<Book> GetAll() => _repository.FindAll();

    public Book GetByISBN(string isbn) => _repository.FindById(isbn);

    public string Add(Book book) => _repository.Add(book);
  }
}
