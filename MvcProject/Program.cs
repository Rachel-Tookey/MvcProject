using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcProject.Controllers;
using MvcProject.Models;
using MvcProject.Repositories;
using MvcProject.Services;
using System.Text.Json.Serialization;

namespace MvcProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); 

            builder.Services.AddDbContext<MyDbContext>(options =>
            options.UseSqlServer(connectionString));


            builder.Services.AddScoped<AuthorsService>();
            builder.Services.AddScoped<AuthorsModel>();

            builder.Services.AddScoped<BooksService>();
            builder.Services.AddScoped<BooksModel>();

            builder.Services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);


            var app = builder.Build();

            app.UseRouting(); 

            app.UseEndpoints( endpoints =>  { 
                
                _ = endpoints.MapControllers(); 
            
            });

            app.Run();
        }
    }
}
