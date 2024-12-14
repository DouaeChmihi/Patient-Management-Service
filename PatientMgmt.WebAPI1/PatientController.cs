using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using PatientMgmt.PatientGrpcService;
using PatientMgmt.PatientGrpcService.Services;

namespace PatientMgmt.WebAPI1;

[Route("api/[controller]")]
[ApiController]
public class PatientController : ControllerBase
{
   private readonly PatientProto.PatientProtoClient _patientClient;

        // Constructeur qui initialise le client gRPC
        public PatientController()
        {
            // Créer un canal gRPC pour se connecter au serveur gRPC à l'adresse spécifiée
            var channel = GrpcChannel.ForAddress("http://localhost:5000"); // Adresse de  serveur gRPC
            _patientClient = new PatientProto.PatientProtoClient(channel);
        }

        // Récupérer un patient par ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var request = new GetPatientByIdRequest { Id = id };
            var response = await _patientClient.GetPatientByIdAsync(request);

            if (response == null || response.Patient == null)
            {
                return NotFound("Patient not found.");
            }

            return Ok(response.Patient);
        }

        // Récupérer tous les patients
        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var response = await _patientClient.GetAllPatientsAsync(new Empty());

            if (response.Patients.Count == 0)
            {
                return NotFound("No patients found.");
            }

            return Ok(response.Patients);
        }

        // Ajouter un patient
        [HttpPost]
        public async Task<IActionResult> AddPatient([FromBody] AddPatientRequest request)
        {
            var response = await _patientClient.AddPatientAsync(request);

            return response == null ? StatusCode(500, "Error while adding the patient.") : Ok("Patient added successfully.");
        }

        // Mettre à jour un patient
        [HttpPut]
        public async Task<IActionResult> UpdatePatient([FromBody] UpdatePatientRequest request)
        {
            var response = await _patientClient.UpdatePatientAsync(request);

            return response == null ? StatusCode(500, "Error while updating the patient.") : Ok("Patient updated successfully.");
        }

        // Supprimer un patient
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            var request = new DeletePatientRequest { Id = id };
            var response = await _patientClient.DeletePatientAsync(request);

            return response == null ? StatusCode(500, "Error while deleting the patient.") : Ok("Patient deleted successfully.");
        }
    }
