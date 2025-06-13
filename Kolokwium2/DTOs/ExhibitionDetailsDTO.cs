namespace Kolokwium2.DTOs;

public class ExhibitionDetailsDTO
{
    public int galleryId { get; set; }
    public string name { get; set; }
    public DateTime extablishedDate { get; set; }
    public ICollection<ArtworkRequestDTO> Artworks { get; set; } = new List<ArtworkRequestDTO>();
}