namespace Kolokwium2.DTOs;

public class AddArtworkRequestDTO
{
    public ExhibitionRequestDTO Exhibition { get; set; } = null!;
    public ICollection<ArtworkRequestDTO> Artworks { get; set; } = new List<ArtworkRequestDTO>();
}