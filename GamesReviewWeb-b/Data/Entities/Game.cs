using System;
using System.Collections.Generic;

namespace GamesReviewWeb_b.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<Review> Reviews { get; set; }


    }
}
