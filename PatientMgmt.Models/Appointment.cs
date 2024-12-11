using PatientMgmt.SDK.Domain;

namespace PatientMgmt.Models;

public class Appointment : TrackedEntity<int>
{
    //From Appointment service
    public DateTime AppointmentDate { get; set; }
    public string DoctorName { get; set; }
    public string Notes { get; set; }
    public Patient PatientId { get; set; }
    
}
