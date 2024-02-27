using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace RateAndReview.Services
{
    public class MongoDBService
    {
        private readonly IMongoCollection<Show> _shows;

        public MongoDBService(MongoDBContext context)
        {
            _shows = context.Shows;
        }

        public async Task<List<Show>> GetAllShowsAsync()
        {
            return await _shows.Find(show => true).ToListAsync();
        }
    }
}
