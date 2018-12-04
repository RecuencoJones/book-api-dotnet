using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Models
{
  public class BookContext : DbContext
  {
    private List<Book> initialBooks = new List<Book>() {
      new Book { ISBN = "000-ASD-0", Name = "Alice in Wonderland" },
      new Book { ISBN = "000-ASD-1", Name = "Cumbres Borrascosas" },
      new Book { ISBN = "000-ASD-2", Name = "Neverending Story" },
      new Book { ISBN = "000-ASD-3", Name = "Cosmos" },
      new Book { ISBN = "000-ASD-4", Name = "Billy Elliot" }
    };

    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {
      AddRange(initialBooks);
      SaveChanges();
    }

    public DbSet<Book> Books { get; set; }
  }
}
