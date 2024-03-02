using MongoDB.Bson;

namespace RateAndReview.Models
{
    public class Review
    {
        public ObjectId _id { get; set; }
        public string mediaId { get; set; }
        public string author { get; set; }
        public string review { get; set; }
        public float rating { get; set; }
        public DateTime date { get; set; }
        public int votes { get; set; }
    }
}
