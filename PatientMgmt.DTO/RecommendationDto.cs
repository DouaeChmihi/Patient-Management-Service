
namespace PatientMgmt.DTO;

public class RecommendationDto
{
    public int RecommendationId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateProvided { get; set; }
    public int PatientId { get; set; } // Identifiant du patient (pas l'objet complet)
}