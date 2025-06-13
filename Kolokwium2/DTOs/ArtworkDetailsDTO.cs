using Kolokwium2.Models;

namespace Kolokwium2.DTOs;

public class ArtworkDetailsDTO
{
    public string title { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public int numberOfArtworks { get; set; }
    public ICollection<ArtworkInArtworksDTO> Artworks { get; set; } = new List<ArtworkInArtworksDTO>();
}