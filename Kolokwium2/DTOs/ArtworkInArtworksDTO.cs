namespace Kolokwium2.DTOs;

public class ArtworkInArtworksDTO
{
    public string title { get; set; }
    public int yearCreated { get; set; }
    public decimal insuranceValue { get; set; }
    public ArtistDTO artist { get; set; }
}