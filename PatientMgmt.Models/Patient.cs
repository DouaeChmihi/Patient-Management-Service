using System.Collections;
using PatientMgmt.SDK.Domain;

namespace PatientMgmt.Models;

public class Patient : TrackedEntity<int>
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Gender { get; set; }
    public DateTime DateOfBirth { get; set; }
    
    //Microservice de gestion des consultations médicales (MedecinService)
    public ICollection<Prescreption> Prescreptions { get; set; }
    public ICollection<Recommendation> Recommendations { get; set; }
    
    //Microservice de gestion des rendez-vous (SecretaireService)
    public ICollection<Appointment> Appointments { get; set; }
    
    
    
}