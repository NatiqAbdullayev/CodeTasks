using Microsoft.EntityFrameworkCore;
using VillaMVC.BL.Services.Abstract;
using VillaMVC.BL.Services.Concrete;
using VillaMVC.DAL.Context;

namespace VillaMVC.PL;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<AppDbContext>(op =>
        {
            op.UseSqlServer(builder.Configuration.GetConnectionString("localdb"));
        });

        builder.Services.AddScoped<IVillaService, VillaService>();


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
