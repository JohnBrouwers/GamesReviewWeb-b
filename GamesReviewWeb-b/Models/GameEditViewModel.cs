using System.ComponentModel.DataAnnotations;

namespace GamesReviewWeb_b.Models
{
    public class GameEditViewModel
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false,  ErrorMessage = ValidationMessages.Required)]
        [StringLength(100, ErrorMessage = ValidationMessages.MaxLength)]
        public string Title { get; set; }

        [StringLength(500, ErrorMessage = ValidationMessages.MaxLength)]
        public string Description { get; set; }

    }
}
