namespace ManufacturingPortal.Models;

/// <summary>
/// Business purpose: a machine or asset on the factory floor that is tracked for status and maintenance.
/// </summary>
public class Equipment
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string AssetTag { get; set; } = string.Empty;
    public string ProductionLine { get; set; } = string.Empty;
    public string Status { get; set; } = "Running"; // Running, Maintenance, Offline
    public DateTime LastMaintenanceDate { get; set; }
    public DateTime NextMaintenanceDate { get; set; }
    public string Notes { get; set; } = string.Empty;
}
