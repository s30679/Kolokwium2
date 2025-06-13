using Kolokwium2.DAL;
using Kolokwium2.DTOs;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services;

public class ExhibitionService : IExhibitionService 
{
    private readonly ExhibitionDbContext _context;

    public ExhibitionService(ExhibitionDbContext context)
    {
        _context = context;
    }

    public async Task<int> AddExhibitionAsync(AddArtworkRequestDTO request)
    {
        return 1;
    }

    public async Task<ExhibitionDetailsDTO?> GetExhibitionsDetailsAsync(int galleryId)
    {
        var exhebition=await _context.Exhibition_Artworks.Include(p => p.Exhibitions)
            .ThenInclude(pr => pr.ExhibitionId).FirstOrDefaultAsync();
        if(exhebition==null)
        {
            return null;
        }

        var exhebitionDTO = new ExhibitionDetailsDTO
        {
            galleryId = exhebition.GalleryId,
            name = exhebition.Name,
            extablishedDate = exhebition.ExtablishedDate,
            Artworks = exhebition.Galleries.OrderBy(g => g.Name).Select(pr => new PrescriptionDetailsDTO
            {
                
            }).ToList()
            
        };
        return exhebitionDTO;
    }
}