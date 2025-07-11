using Microsoft.EntityFrameworkCore;
using MovieAPI.Models;

namespace MovieAPI.Data
{
    public class MovieAPIContext : DbContext
    {
        public MovieAPIContext(DbContextOptions<MovieAPIContext> options)
            : base(options)
        {
        }

     
        public DbSet<Movies> Movies { get; set; } = default!;

        public DbSet<MovieAPI.Models.Review> Review { get; set; } = default!;

        /*
                protected override void OnModelCreating(ModelBuilder modelBuilder)
                {


                    Movies mov = new Movies
                    {
                        MoviesId = 1,


                        Duration = TimeSpan.FromMinutes(90),
                        Genre = "GG",
                        Title = "Titl",
                        Year = 1999,


                    };
                    //mov.Reviews.Add(r);

                    modelBuilder.Entity<Movies>().HasData(mov);

                    Review r = new Review
                    {
                        ReviewId = 1,
                        Comment = "Com",
                        Rating = 2,
                        ReviewerName = "rnam",
                        MoviesId = 1
                    };
                    modelBuilder.Entity<Review>().HasData(r);
        */


        /*  
          modelBuilder.Entity<MovieDetails>().HasData(new MovieDetails
          {
              Id = 1,
              Budget = 928,
              Language = "en",
              Synopsis = "Synop",
              MoviesID = 1
          });

          modelBuilder.Entity<Review>().HasData(new Actor
          {
              Id = 1,
              Name = "A",
              BirthYear = 11,
              Movies = new List<Movies> {
                  mov,

          }
          });*/

    }



}

