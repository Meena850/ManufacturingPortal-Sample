using ManufacturingPortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace ManufacturingPortal.Controllers;

/// <summary>
/// Equipment Management module: lists machines and shows maintenance details.
/// </summary>
public class EquipmentController : Controller
{
    private readonly IEquipmentService _equipmentService;

    public EquipmentController(IEquipmentService equipmentService)
    {
        _equipmentService = equipmentService;
    }

    public IActionResult List() => View(_equipmentService.GetAll());

    public IActionResult Details(int id)
    {
        var equipment = _equipmentService.GetById(id);
        if (equipment == null) return NotFound();
        return View(equipment);
    }
}
