namespace RateAndReview.Client.Models
{
    public class Show
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Rating { get; set; }
        public List<string> Reviews { get; set; }
    }
}
