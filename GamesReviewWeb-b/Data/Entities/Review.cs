namespace GamesReviewWeb_b.Data.Entities
{
    public class Review
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Rating Rating { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }
    }

    public enum Rating
    {
        Excellent,
        Good,
        Moderate,
        Bad,
        Garbage
    }
}
