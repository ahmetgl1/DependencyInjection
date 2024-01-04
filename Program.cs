
using DependencyInjection.Context;
using DependencyInjection.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DependencyInjection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.





            builder.Services.AddScoped<IProductService>();
            builder.Services.AddScoped<IProductService>();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {

                options.UseSqlServer("Data Source=DESKTOP-3O4V1S5;Initial Catalog=ExampleDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            });





            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}