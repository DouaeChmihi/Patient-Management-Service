using Grpc.Core;
using PatientGmt.PatientGrpcService;
using PatientMgmt.DTO;
using PatientMgmt.Services.Abstractions;

public class PatientServiceGrpc : PatientProto.PatientProtoBase
{
    private readonly IPatientService _patientService;
    private readonly IAppointmentService _appointmentService;
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

        // Check if the email already exists
        var existingPatient = await _patientService.GetPatientByEmailAsync(request.Patient.Email);
        if (existingPatient != null)
        {
            // Throwing a gRPC Status Exception with a custom error message for the email already being used
            throw new RpcException(new Status(StatusCode.AlreadyExists, "Email is already in use. Please use a different email."));
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
        var generatedId = patient.Id; // Ensure the ID is updated after adding the patient
        
        return new AddPatientResponse
        {
            Message = "Create success",
            PatientId = generatedId
        };
    }

    public override async Task<GetPatientByEmailResponse> GetPatientByEmail(GetPatientByEmailRequest request, ServerCallContext context)
    {
        // Recherche du patient dans la base de données par email
        var patient = await _patientService.GetPatientByEmailAsync(request.Email);

        // Si le patient n'existe pas, retourner une réponse vide
        if (patient == null)
        {
            return new GetPatientByEmailResponse();
        }

        // Retourner les informations du patient si trouvé
        return new GetPatientByEmailResponse
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
    }

    public override async Task<PatientExistsResponse> CheckPatientExists(PatientEmail request, ServerCallContext context)
    {
        // Vérifier si le patient existe en utilisant l'email
        var existingPatient = await _patientService.GetPatientByEmailAsync(request.Email);

        // Retourner la réponse en fonction de l'existence du patient
        var response = new PatientExistsResponse
        {
            Exists = existingPatient != null
        };

        return response;
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

   

    public override async Task<GetPatientRendezVousResponse> GetPatientRendezVous(GetPatientRendezVousRequest request, ServerCallContext context)
    {
        // Retrieve the list of appointments for the specified patient ID
        var appointments = await _appointmentService.GetAppointmentsByPatientIdAsync(request.PatientId);

        // Create the response
        var response = new GetPatientRendezVousResponse();
        foreach (var appointment in appointments)
        {
            response.RendezVous.Add(new RendezVousDto
            {
                Id = appointment.Id,                                                                 // Appointment ID
                PatientId = appointment.PatientId,                                                  // Patient ID
                DoctorId = appointment.DoctorId,                                                    // Doctor ID
                StartTime = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(appointment.StartTime.ToUniversalTime()), // Start time
                EndTime = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(appointment.EndTime.ToUniversalTime()),     // End time
                Notes = appointment.Notes ?? string.Empty,                                          // Notes (optional)
                Status = appointment.Status                                                                        // Doctor's name
            });
        }

        return response;
    }



}
