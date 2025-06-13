using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.DAL;

public class ExhibitionDbContext : DbContext
{
    public DbSet<Exhibition> Exhibitions { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Artwork> Artworks { get; set; }
    public DbSet<Exhibition_Artwork> Exhibition_Artworks { get; set; }
    public DbSet<Gallery> Galleries { get; set; }

    protected ExhibitionDbContext()
    {
    }

    public ExhibitionDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Artist>()
    }
}