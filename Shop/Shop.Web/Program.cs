using Microsoft.EntityFrameworkCore;
using Shop.DAL.Daos;
using Shop.DAL.Interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddDbContext<Shop.DAL.Context.ShopContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ShopDb")));


        builder.Services.AddScoped<IDaoProducts, DaoProduct>();
        builder.Services.AddScoped<IDaoEmployees, DaoEmployee>();
        builder.Services.AddScoped<IDaoCustomer, DaoCustomer>();


        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        using (var scope = app.Services.CreateScope())
        {
            var context = scope.ServiceProvider.GetRequiredService<Shop.DAL.Context.ShopContext>();
            if (context.Database.CanConnect())
            {
                Console.WriteLine("Conexión a la base de datos exitosa.");
            }
            else
            {
                Console.WriteLine("No se pudo conectar a la base de datos.");
            }
        }


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
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
