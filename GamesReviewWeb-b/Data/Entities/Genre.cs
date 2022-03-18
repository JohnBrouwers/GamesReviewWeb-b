namespace GamesReviewWeb_b.Data.Entities
{
    public class Genre
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }


    public class GameGenre 
    {
        public int GameId { get; set; }
        public int GenreId { get; set; }

        public Game Game { get; set; }
        public Genre Genre { get; set; }


    }
}
