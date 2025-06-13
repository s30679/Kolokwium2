using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

public class Artwork
{
    [Key]
    public int ArtworkId { get; set; }
    
    [ForeignKey(nameof(ArtistId))]
    public int ArtistId { get; set; }
    
    [Required, MaxLength(100)]
    public string Title { get; set; }
    
    [Required]
    public int YearCreated { get; set; }
    
    public ICollection<Artist> Artists { get; set; } = new List<Artist>();
}