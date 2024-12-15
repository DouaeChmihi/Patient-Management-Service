using PatientMgmt.Infrastracture.Abstractions;
using PatientMgmt.Models;
using PatientMgmt.Services.Abstractions;

namespace PatientMgmt.Services;

public class PatientService : IPatientService
{
    
    private readonly IPatientRepository _patientRepository;
    
    public PatientService(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }
    
    
    public async Task<Patient?> GetPatientByEmailAsync(string email)
    {
        return await _patientRepository.GetPatientByEmailAsync(email);
    }
    public async Task AddPatientAsync(Patient patient)
    {
        await _patientRepository.AddAsync(patient);
    }
    public async Task<Patient> GetPatientByIdAsync(int id)
    {
        return await _patientRepository.GetByIdAsync(id);
    }
    public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
    {
        return await _patientRepository.GetAllAsync();
    }
    public async Task UpdatePatientAsync(Patient patient)
    {
        await _patientRepository.UpdateAsync(patient);
    }
    public async Task DeletePatientAsync(int patientId)
    {
        var patient = await _patientRepository.GetByIdAsync(patientId);
        await _patientRepository.DeleteAsync(patient);
    }
}