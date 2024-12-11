using PatientMgmt.Infrastracture.Abstractions;
using PatientMgmt.Models;

namespace PatientMgmt.Infrastracture.EF.Patients;

public class PatientRepository : IPatientRepository
{
    public Task<Patient?> GetPatientByEmailAsync(Guid patientId)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Patient patient)
    {
        throw new NotImplementedException();
    }

    public Task<Patient> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Patient>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Patient patient)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Patient patient)
    {
        throw new NotImplementedException();
    }
}