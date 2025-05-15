using GymMVC.BL.Services;
using GymMVC.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace GymMVC.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(@"server=DESKTOP-GTVND9D\SQLEXPRESS;database=CharityDB;Trusted_Connection=true;TrustServerCertificate=true;");
            });

            builder.Services.AddScoped<ProgramModelService>();


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
}
