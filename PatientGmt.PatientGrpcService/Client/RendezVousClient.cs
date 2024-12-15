using PatientMgmt.DTO;

namespace PatientMgmt.PatientGrpcService.Client;

public class RendezVousClient
{
    private readonly HttpClient _httpClient;

    public RendezVousClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
        public async Task<List<AppointmentDto>> GetRendezVousAsync(int patientId)
        {
            var response = await _httpClient.GetAsync($"http://localhost:5000/api/rendezvous/{patientId}");
            response.EnsureSuccessStatusCode();
            var rendezvous = await response.Content.ReadFromJsonAsync<List<AppointmentDto>>();
            return rendezvous;
        }
    
}