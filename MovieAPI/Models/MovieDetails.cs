

using Microsoft.CodeAnalysis;

namespace MovieAPI.Models
{
    public class MovieDetails
    {
        

        public int      Id{ get; set; }
        public int      Budget { get; set; }
        public string   Synopsis { get; set; }
        public  string  Language { get; set; }

        //ForeignKey
        public int MoviesID { get; set; }

        //Navigation property
        //[JsonIgnore]
        //public Movie Movie{ get; set; } = null!;

    }
}
