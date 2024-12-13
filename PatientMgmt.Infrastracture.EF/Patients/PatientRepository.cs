using Microsoft.EntityFrameworkCore;
using PatientMgmt.Infrastracture.Abstractions;
using PatientMgmt.Models;

namespace PatientMgmt.Infrastracture.EF.Patients;

public class PatientRepository : IPatientRepository
{
    private readonly ApplicationDbContext _context;

    public PatientRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<Patient?> GetPatientByEmailAsync(string email)
    {
        return await _context.Patients
            .FirstOrDefaultAsync(p => p.Email == email);
    }
    public async Task AddAsync(Patient patient)
    {
        await _context.Patients.AddAsync(patient);
        await _context.SaveChangesAsync();
    }

    public async Task<Patient> GetByIdAsync(int id)
    {
        return await _context.Patients
            .FindAsync(id) ?? throw new KeyNotFoundException("Patient not found.");
    }

    public async Task<IEnumerable<Patient>> GetAllAsync()
    {
        return await _context.Patients.ToListAsync();
    }

    public async Task UpdateAsync(Patient patient)
    {
        _context.Patients.Update(patient);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Patient patient)
    {
        _context.Patients.Remove(patient);
        await _context.SaveChangesAsync();
    }
}
