using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

public class Exhibition
{
    [Key]
    public int ExhibitionId { get; set; }

    [ForeignKey(nameof(GalleryId))] 
    public int GalleryId{ get; set; }
    
    [Required, MaxLength(100)]
    public string Title { get; set; }
    
    [Required]
    public DateTime StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    [Required]
    public int NumberOfArtworks { get; set; }
    
    public ICollection<Gallery> Galleries { get; set; } = new List<Gallery>();
}