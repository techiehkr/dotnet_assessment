using System.ComponentModel.DataAnnotations;

namespace BookApi.Models
{
    

public class Book
{
    [Key]
    public int Id { get; set; }
    [Required]
    
    public string Publisher { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string AuthorLastName { get; set; }
    [Required]
    public string AuthorFirstName { get; set; }
    [Required]
    
    public decimal Price { get; set; }

    public string MlaCitation => $"{AuthorLastName}, {AuthorFirstName}. {Title}. {Publisher}.";
    public string ChicagoCitation => $"{AuthorLastName}, {AuthorFirstName}. {Title}. {Publisher}.";
}
}