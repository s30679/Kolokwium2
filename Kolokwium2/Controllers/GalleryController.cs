using Kolokwium2.DTOs;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers;

[ApiController]
[Route("api")]
public class GalleryController
{
    private readonly IExhibitionService _exhibitionService;
    [HttpPost]
    public async Task<IActionResult> AddE([FromBody] AddArtworkRequestDTO request)
    {
        try
        {
            var galleryId = await _exhibitionService.AddExhibitionAsync(request);
            return CreatedAtActionResult(nameof(GetGalleryExhibitions), new { galleryId = request.Exhibition.gallery },
                galleryId);
        }
        catch (System.Exception ex)
        {
            
        }
    }

    [HttpGet("galleries/{Id}/exhibitions")]
    public async Task<IActionResult> GetGalleryExhibitions(int Id)
    {
        var gallery = await _exhibitionService.GetExhibitionsDetailsAsync(Id);
        if (gallery == null)
        {
            return NotFound($"Galleria o Id {Id} nie istnieje.");
        }
        return Ok(gallery);
    }
}