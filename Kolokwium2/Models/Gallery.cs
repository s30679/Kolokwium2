using System.ComponentModel.DataAnnotations;

namespace Kolokwium2.Models;

public class Gallery
{
    [Key]
    public int GalleryId { get; set; }
    
    [Required, MaxLength(50)]
    public string Name { get; set; }
    
    [Required]
    public DateTime EstablishedDate { get; set; }
}