

namespace PatientMgmt.DTO;

public class PrescreptionDto 
{
    public int PrescreptionId { get; set; }
    public string Medication { get; set; }
    public string Dosage { get; set; }
    public DateTime DateIssued { get; set; }
    public int PatientId { get; set; } // Identifiant du patient (pas l'objet complet)
}