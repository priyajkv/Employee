using System.ComponentModel.DataAnnotations;

namespace Employee.Models;

public class Employer
{
    public int Id { get; set; }
    public string Name { get; set; }
    [Required]
    public string Gender { get; set; } = "";
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Country { get; set; }
    public string State { get; set; }
    public string City { get; set; }
}
