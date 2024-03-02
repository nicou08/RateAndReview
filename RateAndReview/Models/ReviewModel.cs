using System.ComponentModel.DataAnnotations;

namespace RateAndReview.Models
{
    public class ReviewModel
    {
        [Required]
        [StringLength(300)]
        public string ReviewMessage { get; set; }
    }
}
