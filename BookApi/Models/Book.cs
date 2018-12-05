using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace BookApi.Models
{
  public class Book
  {
    [Key]
    public string ISBN { get; set; }
    public string Name { get; set; }

    [NotMapped]
    public List<string> Tags { get; set; }

    public Book()
    {
      Tags = new string[] { }.ToList();
    }
  }
}
