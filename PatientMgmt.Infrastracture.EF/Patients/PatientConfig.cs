using PatientMgmt.Models;

namespace PatientMgmt.Infrastracture.EF.Patients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

internal class PatientConfig
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).ValueGeneratedOnAdd();
        builder.Property(p => p.Name).HasMaxLength(50);
        builder.Property(p => p.Email).HasMaxLength(50);
        builder.HasIndex(p => p.Email).IsUnique();
        builder.Property(p => p.PhoneNumber).HasMaxLength(50);
        builder.Property(p => p.Gender).HasMaxLength(50);
        builder.Property(p => p.DateOfBirth).HasMaxLength(50);
        
    }
    
}