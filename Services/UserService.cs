using ManufacturingPortal.Models;

namespace ManufacturingPortal.Services;

/// <summary>
/// Business purpose: provides portal user data.
/// </summary>
public interface IUserService
{
    List<User> GetAll();
}

/// <summary>
/// In-memory user directory used for the User Management and Dashboard modules.
/// </summary>
public class UserService : IUserService
{
    private readonly List<User> _users = new()
    {
        new() { Id = 1, FullName = "Maria Lopez", Email = "maria.lopez@contoso-mfg.com", Role = "Admin", Department = "IT", IsActive = true },
        new() { Id = 2, FullName = "James Carter", Email = "james.carter@contoso-mfg.com", Role = "Supervisor", Department = "Production", IsActive = true },
        new() { Id = 3, FullName = "Aiko Tanaka", Email = "aiko.tanaka@contoso-mfg.com", Role = "Technician", Department = "Maintenance", IsActive = true },
        new() { Id = 4, FullName = "Liam O'Brien", Email = "liam.obrien@contoso-mfg.com", Role = "Operator", Department = "Production", IsActive = true },
        new() { Id = 5, FullName = "Fatima Khan", Email = "fatima.khan@contoso-mfg.com", Role = "Operator", Department = "Quality", IsActive = false }
    };

    public List<User> GetAll() => _users;
}
