using PatientMgmt.Models;

namespace PatientMgmt.Infrastracture.Abstractions;

public interface IPatientRepository 
{
    Task<Patient?> GetPatientByEmailAsync(string email);
    Task AddAsync(Patient patient);
    Task<Patient> GetByIdAsync(int id);
    Task<IEnumerable<Patient>> GetAllAsync();
    Task UpdateAsync(Patient patient);
    Task DeleteAsync(Patient patient);
    
    
}