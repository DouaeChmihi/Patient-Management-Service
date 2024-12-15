using PatientMgmt.Models;

namespace PatientMgmt.Services.Abstractions;

public interface IPatientService
{
    Task<Patient?> GetPatientByEmailAsync(string email);
    Task AddPatientAsync(Patient patient);
    Task<Patient> GetPatientByIdAsync(int id);
    Task<IEnumerable<Patient>> GetAllPatientsAsync();
    Task UpdatePatientAsync(Patient patient);
    Task DeletePatientAsync(int patientId);
}