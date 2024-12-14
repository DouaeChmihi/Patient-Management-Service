
namespace PatientMgmt.DTO;

public class AppointmentDto{
    
    //From AppointmentDto service
    public int AppointmentId { get; set; }
    public DateTime AppointmentDate { get; set; }
    public string DoctorName { get; set; }
    public string Notes { get; set; }
    public int PatientId { get; set; } // Identifiant du patient (pas l'objet complet)
    
}
