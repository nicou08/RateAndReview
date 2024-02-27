using MongoDB.Driver;

namespace RateAndReview.Services
{
    public class Show
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Rating { get; set; }
    }
    public class MongoDBContext
    {
        private readonly IMongoDatabase _database;

        public MongoDBContext(string connectionString, string databaseName)
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }

        public IMongoCollection<Show> Shows
        {
            get { return _database.GetCollection<Show>("shows"); }
        }
    }
}
