using System.Collections.Generic;

namespace GamesReviewWeb_b.Data.Entities
{
    public class Publisher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}