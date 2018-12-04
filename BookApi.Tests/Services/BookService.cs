using NUnit.Framework;
using BookApi.Services;

namespace BookApi.UnitTests.Services
{
  [TestFixture]
  public class BookServiceTests
  {
    private readonly BookService _bookService;

    public BookServiceTests() {
      var context = new { Books = null };

      this._bookService = new BookService(context);
    }

    [Test]
    public void ReturnNullIfBookDoesNotExist()
    {
      var result = _bookService.FindById("000-ASD-1");

      Assert.Equals(result, null);
    }
  }
}
