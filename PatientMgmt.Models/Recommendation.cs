using PatientMgmt.SDK.Domain;

namespace PatientMgmt.Models;

public class Recommendation : TrackedEntity<int>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateProvided { get; set; }
    public Patient PatientId { get; set; }
}