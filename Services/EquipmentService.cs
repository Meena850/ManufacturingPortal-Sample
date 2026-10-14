using ManufacturingPortal.Models;

namespace ManufacturingPortal.Services;

/// <summary>
/// Business purpose: provides equipment data to the portal.
/// </summary>
public interface IEquipmentService
{
    List<Equipment> GetAll();
    Equipment? GetById(int id);
}

/// <summary>
/// In-memory equipment registry used for the Equipment Management and Dashboard modules.
/// </summary>
public class EquipmentService : IEquipmentService
{
    private readonly List<Equipment> _equipment = new()
    {
        new() { Id = 1, Name = "CNC Milling Machine", AssetTag = "EQ-1001", ProductionLine = "Line A", Status = "Running",
                LastMaintenanceDate = new DateTime(2026, 8, 12), NextMaintenanceDate = new DateTime(2026, 11, 12), Notes = "Precision machining of engine parts." },
        new() { Id = 2, Name = "Hydraulic Press", AssetTag = "EQ-1002", ProductionLine = "Line A", Status = "Maintenance",
                LastMaintenanceDate = new DateTime(2026, 10, 10), NextMaintenanceDate = new DateTime(2027, 1, 10), Notes = "Seal replacement in progress." },
        new() { Id = 3, Name = "Robotic Welding Arm", AssetTag = "EQ-1003", ProductionLine = "Line B", Status = "Running",
                LastMaintenanceDate = new DateTime(2026, 9, 1), NextMaintenanceDate = new DateTime(2026, 12, 1), Notes = "Chassis welding station." },
        new() { Id = 4, Name = "Conveyor System", AssetTag = "EQ-1004", ProductionLine = "Line B", Status = "Offline",
                LastMaintenanceDate = new DateTime(2026, 6, 20), NextMaintenanceDate = new DateTime(2026, 10, 20), Notes = "Motor fault, awaiting spare part." },
        new() { Id = 5, Name = "Packaging Machine", AssetTag = "EQ-1005", ProductionLine = "Line C", Status = "Running",
                LastMaintenanceDate = new DateTime(2026, 7, 30), NextMaintenanceDate = new DateTime(2026, 10, 30), Notes = "Final product packaging." }
    };

    public List<Equipment> GetAll() => _equipment;

    public Equipment? GetById(int id) => _equipment.FirstOrDefault(e => e.Id == id);
}
