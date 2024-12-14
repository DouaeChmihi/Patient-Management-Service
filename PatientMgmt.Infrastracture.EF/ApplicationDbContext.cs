using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
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
//tester 
   // private DatabaseFacade Database { get; }
}
