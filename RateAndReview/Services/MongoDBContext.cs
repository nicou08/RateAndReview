namespace RateAndReview.Services
{
    using MongoDB.Driver;
    using RateAndReview.Models;
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<Media> MediaInfo
        {
            get { return _database.GetCollection<Media>("media"); }
        }

        public IMongoCollection<Review> Reviews
        {
            get { return _database.GetCollection<Review>("reviews"); }
        }
    }
}
