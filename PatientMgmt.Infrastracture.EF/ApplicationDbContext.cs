using Microsoft.EntityFrameworkCore;
using PatientMgmt.Models;

namespace PatientMgmt.Infrastracture.EF;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Patient> Patients { get; set; }
    // Ajoutez d'autres DbSet pour vos entités ici
}
