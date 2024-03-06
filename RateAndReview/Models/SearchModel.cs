using System.ComponentModel.DataAnnotations;

namespace RateAndReview.Models
{
    public class SearchModel
    {
        [Required]
        [StringLength(70)]
        public string SearchQuery { get; set; }
    }
}
