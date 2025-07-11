
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.Extensions.DependencyInjection;
using MovieAPI.Data;
using MovieAPI.Models;




namespace MovieAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDbContext<MovieAPIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MovieAPIContext") ?? throw new InvalidOperationException("Connection string 'MovieAPIContext' not found.")));

           
            // Add services to the container.


            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();
           MovieAPIContext _c= app.Services.CreateScope().ServiceProvider.GetRequiredService<MovieAPIContext>();
            Insertn();

            void Insertn()
            {
                Movies mov = new Movies
                {
                    

                    Duration = TimeSpan.FromMinutes(90),
                    Genre = "GG",
                    Title = "Titl",
                    Year = 1999,


                };
                mov.Reviews.Add(new Review
                {
                    
                    Comment = "Com",
                    Rating = 2,
                    ReviewerName = "rnam",
                    MoviesId = 1
                });
                _c.Add(mov);
                _c.SaveChanges();
            }



            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                //app.UseSwagger();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        
    }
}
