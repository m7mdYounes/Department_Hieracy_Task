using DeptHieracy.Models;
using DeptHieracy.Repository;
using Microsoft.EntityFrameworkCore;

namespace DeptHieracy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<DepartmentContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cn"));
            });
            builder.Services.AddScoped<Idept,dept>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Dept}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
