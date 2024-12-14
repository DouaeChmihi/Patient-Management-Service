using Grpc.Core;
using PatientMgmt.Infrastracture.EF;
using PatientMgmt.Infrastracture.EF.Patients;
using PatientMgmt.PatientGrpcService;

namespace PatientMgmt.PatientGrpcService.Services;

public class PatientService : PatientProto.PatientProtoBase
{
    private readonly PatientRepository _patientRepository;

    // Constructor should properly assign the repository
    public PatientService(PatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public override async Task<GetPatientByIdResponse> GetPatientById(GetPatientByIdRequest request, ServerCallContext context)
    {
        var patient = await _patientRepository.GetByIdAsync(request.Id);

        // Map the entity to the response message
        var patientResponse = new GetPatientByIdResponse
        {
            Patient = new Patient
            {
                Id = patient.Id,
                Name = patient.Name,
                Email = patient.Email
            }
        };

        return patientResponse;
    }

    public override async Task<GetAllPatientsResponse> GetAllPatients(Empty request, ServerCallContext context)
    {
        var patients = await _patientRepository.GetAllAsync();

        // Map the list of entities to the response message
        var response = new GetAllPatientsResponse();
        foreach (var patient in patients)
        {
            response.Patients.Add(new Patient
            {
                Id = patient.Id,
                Name = patient.Name,
                Email = patient.Email
            });
        }

        return response;
    }

    public override async Task<Empty> AddPatient(AddPatientRequest request, ServerCallContext context)
    {
        var patient = new PatientMgmt.Models.Patient
        {
            Name = request.Patient.Name,
            Email = request.Patient.Email
        };

        await _patientRepository.AddAsync(patient);
        return new Empty();
    }

    public override async Task<Empty> UpdatePatient(UpdatePatientRequest request, ServerCallContext context)
    {
        var patient = new PatientMgmt.Models.Patient
        {
            Id = request.Patient.Id,
            Name = request.Patient.Name,
            Email = request.Patient.Email
        };

        await _patientRepository.UpdateAsync(patient);
        return new Empty();
    }

    public override async Task<Empty> DeletePatient(DeletePatientRequest request, ServerCallContext context)
    {
        var patient = await _patientRepository.GetByIdAsync(request.Id);
        await _patientRepository.DeleteAsync(patient);
        return new Empty();
    }
}
