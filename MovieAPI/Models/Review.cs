namespace MovieAPI.Models

{
    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewerName { get; set; }
        public int Rating { get; set; } = Random.Shared.Next(1,6);
        public string Comment { get; set; }

        public int MoviesId { get; set; }

    }
}