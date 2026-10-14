namespace ManufacturingPortal.Models;

/// <summary>
/// Business purpose: a portal user (operator, technician, supervisor) who works with plant operations.
/// </summary>
public class User
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty; // Operator, Technician, Supervisor, Admin
    public string Department { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
}
