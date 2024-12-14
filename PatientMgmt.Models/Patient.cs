using System.Collections;
using PatientMgmt.DTO;
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
    
 
    
}