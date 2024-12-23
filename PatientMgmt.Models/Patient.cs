using System.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using PatientMgmt.DTO;
using PatientMgmt.SDK.Domain;

namespace PatientMgmt.Models;

public class Patient : TrackedEntity<int>
{
    public string Name { get; set; }
    public string Address { get; set; }
    [EmailAddress] // Optionally, use Data Annotation to validate email format
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Gender { get; set; }
    
 
    
}