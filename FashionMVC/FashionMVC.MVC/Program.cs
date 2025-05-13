using FashionMVC.BL.Services;

namespace FashionMVC.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IProductService, ProductService>();

            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

            app.MapControllerRoute(name: "Default", pattern: "{Controller=Home}/{Action=Index}");

            app.Run();
        }
    }
}
