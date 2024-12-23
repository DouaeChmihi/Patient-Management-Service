using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using PatientMgmt.Infrastracture.EF.Patients;
using PatientMgmt.Models;

namespace PatientMgmt.Infrastracture.EF;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() {}
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
 
//table Patients 
    public DbSet<Patient> Patients { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Apply PatientConfig to configure the Patient entity
        modelBuilder.ApplyConfiguration<Patient>(new PatientConfig());
    }

//tester 
   // private DatabaseFacade Database { get; }
}
