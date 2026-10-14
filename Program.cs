using ManufacturingPortal.Services;

var builder = WebApplication.CreateBuilder(args);

// MVC with Razor views
builder.Services.AddControllersWithViews();

// Business services registered for dependency injection.
// Singleton because data is held in memory for this sample.
builder.Services.AddSingleton<IEquipmentService, EquipmentService>();
builder.Services.AddSingleton<IUserService, UserService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

// Default route: Dashboard (Home/Index)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
