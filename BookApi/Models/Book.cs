using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
  public class Book
  {
    [Key]
    public string ISBN { get; set; }
    public string Name { get; set; }
    public List<Tag> Tags { get; set; }
  }
}
