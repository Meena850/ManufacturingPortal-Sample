using ManufacturingPortal.Services;
using Microsoft.AspNetCore.Mvc;

namespace ManufacturingPortal.Controllers;

/// <summary>
/// User Management module: lists portal users and their roles.
/// </summary>
public class UserController : Controller
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    public IActionResult List() => View(_userService.GetAll());
}
