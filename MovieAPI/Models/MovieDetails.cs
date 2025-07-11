

using Microsoft.CodeAnalysis;

namespace MovieAPI.Models
{
    public class MovieDetails
    {
        

        public int      Id{ get; set; }
        public int Budget { get; set; } = 123;
        public string Synopsis { get; set; } = $"Synopsis...";
        public string Language { get; set; } = "xxx...";

        //ForeignKey
        public int MovieID { get; set; }

        //Navigation property
        //[JsonIgnore]
        //public Movie Movie{ get; set; } = null!;

    }
}
