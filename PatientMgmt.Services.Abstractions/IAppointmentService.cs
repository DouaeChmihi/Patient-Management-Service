using PatientMgmt.DTO;

namespace PatientMgmt.Services.Abstractions;

public interface IAppointmentService
{
    Task<List<AppointmentDto>> GetAppointmentsByPatientIdAsync(int patientId);

}