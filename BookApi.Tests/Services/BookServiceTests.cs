using NUnit.Framework;
using Moq;
using BookApi.Services;
using BookApi.Models;
using Microsoft.EntityFrameworkCore;
using BookApi.Repositories;
using System.Linq;

namespace BookApi.UnitTests.Services
{
  [TestFixture]
  public class BookServiceTests
  {
    private readonly IBookService _bookService;
    private readonly Mock<IBookRepository> _bookRepositoryMock;

    public BookServiceTests() {
      _bookRepositoryMock = new Mock<IBookRepository>();
      _bookService = new BookService(_bookRepositoryMock.Object);
    }

    [SetUp]
    public void Setup()
    {
      _bookRepositoryMock.Reset();
    }

    [Test]
    public void ReturnNullIfBookDoesNotExist()
    {
      var result = _bookService.GetByISBN("000-ASD-1");

      Assert.IsNull(result);
    }

    [Test]
    public void ReturnBookIfBookExists()
    {
      var isbn = "000-ASD-1";

      _bookRepositoryMock.Setup(r => r.FindById(isbn)).Returns(new Book { ISBN = isbn });

      var result = _bookService.GetByISBN(isbn);

      Assert.AreEqual(result.ISBN, isbn);
    }

    [Test]
    public void ReturnAllBooks()
    {
      var books = new Book[] {
        new Book { ISBN = "000-ASD-1" },
        new Book { ISBN = "000-ASD-2" }
      }.ToList();

      _bookRepositoryMock.Setup(r => r.FindAll()).Returns(books);

      var result = _bookService.GetAll();

      Assert.AreEqual(result, books);
    }
  }
}
