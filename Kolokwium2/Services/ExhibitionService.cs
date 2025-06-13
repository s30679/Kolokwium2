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
        var exhebition=await _context.Exhibitions.Include(p => p.GalleryId)
            .ThenInclude(pr => pr.Doctor)
            .Include(p => p.Prescriptions)
            .ThenInclude(pr => pr.PrescriptionMedicaments)
            .ThenInclude(pm => pm.Medicament).Where(p => p.IdPatient == patientId)
            .FirstOrDefaultAsync();
        if(exhebition==null)
        {
            return null;
        }
        var exhebitionDTO=new ExhibitionDetailsDTO
        {
            galleryId = exhebition.GalleryId,
            name = exhebition.Name,
            extablishedDate = exhebition.ExtablishedDate,
            Artworks = exhebition.Galleries.OrderBy(g => g.Name).ThenBy(g => g.Extension).Select(pr => new PrescriptionDetailsDTO
            
        }
            IdPatient=gallery.IdPatient, 
            FirstName=gallery.FirstName,
            LastName=gallery.LastName,
            Birthdate=gallery.Birthdate,
            Prescriptions=gallery.Prescriptions.OrderByDescending(p => p.DueDate).Select(pr => new PrescriptionDetailsDTO
            {
                IdPrescription=pr.IdPrescription,
                Date=pr.Date,
                DueDate=pr.DueDate,
                Doctor=new DoctorDetailsDTO
                {
                    IdDoctor=pr.Doctor.IdDoctor,
                    FirstName=pr.Doctor.FirstName,
                    LastName=pr.Doctor.LastName
                },
                Medicaments=pr.PrescriptionMedicaments.Select(pm => new MedicamentDetailsDTO
                {
                    IdMedicament=pm.Medicament.IdMedicament,
                    Name=pm.Medicament.Name,
                    Dose=pm.Dose,
                    Details=pm.Details }).ToList()
            }).ToList()
        };
        return pacjentDTO;
    }
}