using PatientMgmt.SDK.Domain;

namespace PatientMgmt.Models;

public class Prescreption : TrackedEntity<int>
{
    public string Medication { get; set; }
    public string Dosage { get; set; }
    public DateTime DateIssued { get; set; }
    public Patient PatientId { get; set; }
}