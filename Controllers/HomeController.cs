using ManufacturingPortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace ManufacturingPortal.Controllers;

/// <summary>
/// Dashboard module: gives plant managers a summary of equipment health and user counts.
/// </summary>
public class HomeController : Controller
{
    private readonly IEquipmentService _equipmentService;
    private readonly IUserService _userService;

    public HomeController(IEquipmentService equipmentService, IUserService userService)
    {
        _equipmentService = equipmentService;
        _userService = userService;
    }

    public IActionResult Index()
    {
        var equipment = _equipmentService.GetAll();
        var users = _userService.GetAll();

        ViewBag.TotalEquipment = equipment.Count;
        ViewBag.RunningEquipment = equipment.Count(e => e.Status == "Running");
        ViewBag.MaintenanceEquipment = equipment.Count(e => e.Status == "Maintenance");
        ViewBag.OfflineEquipment = equipment.Count(e => e.Status == "Offline");
        ViewBag.ActiveUsers = users.Count(u => u.IsActive);

        return View(equipment.Where(e => e.Status != "Running").ToList());
    }
}
