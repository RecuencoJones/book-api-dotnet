using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
  public class Tag {
    [Key]
    public string Name { get; set; }
  }
}
