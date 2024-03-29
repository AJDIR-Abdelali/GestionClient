
using API.Repository;
using API.Service;
using Microsoft.EntityFrameworkCore;



namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();


            builder.Services.AddDbContext<MyDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
               );

            builder.Services.AddScoped<IClientService, ClientService>();
            builder.Services.AddTransient<IClientRepos, ClientRepos>();

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

            app.MapGet("/Get",()=> "Hello MICDA");
            app.MapGet("All", () => GetAll());
            app.MapPost("/Create", (string db) =>
            {

            });
            app.MapPut("/Update", (string db) =>
            {

            });
            app.MapDelete("/Delete", () =>
            {

            });


            //    var summaries = new[]
            //    {
            //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            //};

            //app.MapGet("/weatherforecast", (HttpContext httpContext) =>
            //{
            //    var forecast = Enumerable.Range(1, 5).Select(index =>
            //        new WeatherForecast
            //        {
            //            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //            TemperatureC = Random.Shared.Next(-20, 55),
            //            Summary = summaries[Random.Shared.Next(summaries.Length)]
            //        })
            //        .ToArray();
            //    return forecast;
            //})
            //.WithName("GetWeatherForecast")
            //.WithOpenApi();

            List<string> GetAll()
            {
                var result = new List<string>();

                result.Add("samia");
                result.Add("Said");
                result.Add("chaime");
                result.Add("Abdelali");

                return result;
            }

            app.Run();
        }
    }
}