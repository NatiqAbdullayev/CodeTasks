using Microsoft.EntityFrameworkCore;
using NFTMarketMVC.BL.Services.Abstract;
using NFTMarketMVC.BL.Services.Concrete;
using NFTMarketMVC.DAL.Context;

namespace NFTMarketMVC.PL;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<AppDbContext>(op =>
        {
            op.UseSqlServer(builder.Configuration.GetConnectionString("localDB"));
        });

        builder.Services.AddScoped<IProductServices, ProductService>();

        var app = builder.Build();
        app.UseStaticFiles();

        app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

        app.MapControllerRoute(
            name: "Default", pattern: "{Controller=Home}/{Action=Index}"
            );

        app.Run();
    }
}
