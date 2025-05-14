using CharityMVC.BL.Services;

namespace CharityMVC.MVC;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddScoped<ICauseService,CauseService>();

        var app = builder.Build();
        app.UseStaticFiles();

        app.MapControllerRoute(
        name: "areas",
        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
      );

        app.MapControllerRoute(
            name: "Default",
            pattern: "{Controller=Home}/{Action=Index}"
            );
        app.Run();
    }
}
