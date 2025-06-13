using Kolokwium2.DTOs;

namespace Kolokwium2.Services;

public interface IExhibitionService
{
    Task<int> AddExhibitionAsync(AddArtworkRequestDTO request);
    Task<ExhibitionDetailsDTO?> GetExhibitionsDetailsAsync(int galleryId);
}