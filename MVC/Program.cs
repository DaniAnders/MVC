var builder = WebApplication.CreateBuilder(args);

/* services mvc */
builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "index",
    pattern: "index",
    defaults: new {controller = "Home", action = "Index" });


app.MapControllerRoute(
    name: "about",
    pattern: "about",
    defaults: new { controller = "Home", action = "About" });


app.MapControllerRoute(
    name: "projects",
    pattern: "projects",
    defaults: new { controller = "Home", action = "Projects" });


app.MapControllerRoute(
    name: "contact",
    pattern: "contact",
    defaults: new { controller = "Home", action = "contact" });


app.Run();

