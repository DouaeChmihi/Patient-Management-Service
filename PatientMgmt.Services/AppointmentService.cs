using System.Net.Http.Json;
using Microsoft.Extensions.Configuration;
using PatientMgmt.DTO;
using PatientMgmt.Services.Abstractions;

namespace PatientMgmt.Services;

public class AppointmentService : IAppointmentService
{
    private readonly HttpClient _HttpClient;
    private string _AppointmentServiceUrl;


    public AppointmentService(HttpClient httpClient, IConfiguration configuration)
    {
        _HttpClient = httpClient;
        _AppointmentServiceUrl= configuration["AppointmentService:BaseUrl"];
    }

    public async Task<List<AppointmentDto>> GetAppointmentsByPatientIdAsync(int patientId)
    {
        var response = await _HttpClient.GetAsync($"{_AppointmentServiceUrl}/appointments/{patientId}");
        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<List<AppointmentDto>>();
    }
}

