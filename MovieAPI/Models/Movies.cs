

namespace MovieAPI.Models
{
    public class Movies
    {
        public int Id{ get; set; }
        public int Year { get; set; }
        public string Title { get; set; } = "Titl";
        public string Genre { get; set; } = "Genr";
        public TimeSpan Duration { get; set; } = TimeSpan.FromMinutes(Random.Shared.Next(80,240));

        public List<Review> Reviews { get; set; } = [];

        public List<Actor> Actors { get; set; } = [];






        //1:1 Relations need to define Parent and child!
        //Navigation on both ends and FK in Dependent => EF magic
        //Navigation in parent and FK in child => EF magic
        //Navigation in both without FK => Mapping required

        //Navigation property
        public MovieDetails MovieDetails { get; set; }

        
    }
}
