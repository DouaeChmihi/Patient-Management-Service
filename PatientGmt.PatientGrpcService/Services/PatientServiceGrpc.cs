using Grpc.Core;
using PatientGmt.PatientGrpcService;
using PatientMgmt.Services.Abstractions;

public class PatientServiceGrpc : PatientProto.PatientProtoBase
{
    private readonly IPatientService _patientService;

    public PatientServiceGrpc(IPatientService patientService)
    {
        _patientService = patientService;
    }

    public override async Task<GetPatientByIdResponse> GetPatientById(GetPatientByIdRequest request, ServerCallContext context)
    {
        var patient = await _patientService.GetPatientByIdAsync(request.Id);

        var patientResponse = new GetPatientByIdResponse
        {
            Patient = new Patient
            {
                Id = patient.Id,
                Name = patient.Name,
                Address = patient.Address,
                Email = patient.Email,
                PhoneNumber = patient.PhoneNumber,
                Gender = patient.Gender
            }
        };
        return patientResponse;
    }

    public override async Task<GetAllPatientsResponse> GetAllPatients(Empty request, ServerCallContext context)
    {
        var patients = await _patientService.GetAllPatientsAsync();

        var response = new GetAllPatientsResponse();
        foreach (var patient in patients)
        {
            response.Patients.Add(new Patient
            {
                Id = patient.Id,
                Name = patient.Name,
                Address = patient.Address,
                Email = patient.Email,
                PhoneNumber = patient.PhoneNumber,
                Gender = patient.Gender
            });
        }
        return response;
    }

    public override async Task<AddPatientResponse> AddPatient(AddPatientRequest request, ServerCallContext context)
    {
        if (request?.Patient == null)
        {
            throw new ArgumentNullException(nameof(request.Patient), "Patient data is missing.");
        }

        var patient = new PatientMgmt.Models.Patient
        {
            Name = request.Patient.Name,
            Address = request.Patient.Address,
            Email = request.Patient.Email,
            PhoneNumber = request.Patient.PhoneNumber,
            Gender = request.Patient.Gender,
        };

        
        await _patientService.AddPatientAsync(patient);
        var generatedId = patient.Id; // Assurez-vous que l'ID est bien mis à jour
        return new AddPatientResponse
        {
            Message = "Create success",
            PatientId = generatedId
        };
    }

    public override async Task<UpdatePatientResponse> UpdatePatient(UpdatePatientRequest request, ServerCallContext context)
    {
        var patient = new PatientMgmt.Models.Patient
        {
            Id = request.Patient.Id,
            Name = request.Patient.Name,
            Address = request.Patient.Address,
            Email = request.Patient.Email,
            PhoneNumber = request.Patient.PhoneNumber,
            Gender = request.Patient.Gender
        };

        await _patientService.UpdatePatientAsync(patient);

        return new UpdatePatientResponse
        {
            Message = "Update success"
        };
    }

    public override async Task<DeletePatientResponse> DeletePatient(DeletePatientRequest request, ServerCallContext context)
    {
        await _patientService.DeletePatientAsync(request.Id);

        return new DeletePatientResponse
        {
            Message = "Delete success"
        };
    }

    public override Task<GetPatientRendezVousResponse> GetPatientRendezVous(GetPatientRendezVousRequest request, ServerCallContext context)
    {
        return base.GetPatientRendezVous(request, context);
    }
}
