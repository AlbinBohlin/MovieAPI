


namespace MovieAPI.Models
{
    public class Actor
    {
        public int Id{ get; set; }
        public int      BirthYear { get; set; }
        public string   Name { get; set; }
       
        public List<Movies> Movies{ get; set; } = [];

    }
}
