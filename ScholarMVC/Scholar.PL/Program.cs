using Microsoft.EntityFrameworkCore;
using Scholar.BL.Services.Abstract;
using Scholar.BL.Services.Concrete;
using Scholar.DAL.Context;

namespace Scholar.PL
{
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
            builder.Services.AddScoped<ICourseService, CourseService>();

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
