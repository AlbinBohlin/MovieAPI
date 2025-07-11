

namespace MovieAPI.Models
{
    public class Movies
    {
        public int Id{ get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; } = TimeSpan.FromMinutes(Random.Shared.Next(80,240));

        /* public List<Review> Reviews { get; set; } = [];

         public List<Actor> Actors { get; set; } = [];



         //Navigation property
         public MovieDetails MovieDetails { get; set; } = null!;*/

        //Foreign Key
        //public int MovieDetails { get; set; }

    }
}
