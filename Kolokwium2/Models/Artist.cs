using System.ComponentModel.DataAnnotations;

namespace Kolokwium2.Models;

public class Artist
{
    [Key]
    public int ArtistId { get; set; }
    [Required, MaxLength(100)]
    public string FirstName { get; set; }
    [Required, MaxLength(100)]
    public string LastName { get; set; }
    [Required]
    private DateTime BirthDate { get; set; }
}