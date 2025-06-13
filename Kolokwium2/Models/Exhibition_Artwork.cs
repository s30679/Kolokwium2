using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kolokwium2.Models;

public class Exhibition_Artwork
{
    [Key,ForeignKey(nameof(ExhibitionId))]
    public int ExhibitionId { get; set; }
    [Key,ForeignKey(nameof(ArtworkId))]
    public int ArtworkId { get; set; }
    [Required]
    public Decimal InsuranceValue { get; set; }
    public ICollection<Artwork> Artworks { get; set; } = new List<Artwork>();
    public ICollection<Exhibition> Exhibitions { get; set; } = new List<Exhibition>();
}