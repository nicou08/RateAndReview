namespace RateAndReview.Services
{
    using MongoDB.Driver;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Hosting;
    using RateAndReview.Models;
    public class MongoDBService
    {
        private readonly IMongoCollection<Media> _mediaInfo;
        private readonly IMongoCollection<Review> _reviews;

        public MongoDBService(MongoDBContext context)
        {
            _mediaInfo = context.MediaInfo;
            _reviews = context.Reviews;
        }

        public async Task<Media> GetMediaDataAsync(string imdbId)
        {
            return await _mediaInfo.Find(show => show.imdbID == imdbId).FirstOrDefaultAsync();
        }

        public async Task<List<Media>> GetTop5ShowsAsync()
        {
            var filter = Builders<Media>.Filter.Eq(m => m.mediaType, "TV Series");
            return await _mediaInfo.Find(filter)
                                   .Sort(Builders<Media>.Sort.Descending(m => m.numberOfReviews))
                                   .Limit(5)
                                   .ToListAsync();
        }

        public async Task<List<Media>> GetTop10ShowsAsync()
        {
            var filter = Builders<Media>.Filter.Eq(m => m.mediaType, "TV Series");
            return await _mediaInfo.Find(filter)
                                   .Sort(Builders<Media>.Sort.Descending(m => m.numberOfReviews))
                                   .Limit(10)
                                   .ToListAsync();
        }

        public async Task<List<Media>> GetTop5MoviesAsync()
        {
            var filter = Builders<Media>.Filter.Eq(m => m.mediaType, "Movie");
            return await _mediaInfo.Find(filter)
                                   .Sort(Builders<Media>.Sort.Descending(m => m.numberOfReviews))
                                   .Limit(5)
                                   .ToListAsync();
        }

        public async Task<List<Media>> GetTop10MoviesAsync()
        {
            var filter = Builders<Media>.Filter.Eq(m => m.mediaType, "Movie");
            return await _mediaInfo.Find(filter)
                                   .Sort(Builders<Media>.Sort.Descending(m => m.numberOfReviews))
                                   .Limit(10)
                                   .ToListAsync();
        }

        public async Task AddMediaAsync(Media media)
        {
            await _mediaInfo.InsertOneAsync(media);
        }

        public async Task UpdateMediaAsync(Media media)
        {
            var filter = Builders<Media>.Filter.Eq(m => m._id, media._id);
            var update = Builders<Media>.Update
                .Set(m => m.rating, media.rating)
                .Set(m => m.numberOfReviews, media.numberOfReviews)
                .Set(m => m.number5Stars, media.number5Stars)
                .Set(m => m.number4Stars, media.number4Stars)
                .Set(m => m.number3Stars, media.number3Stars)
                .Set(m => m.number2Stars, media.number2Stars)
                .Set(m => m.number1Stars, media.number1Stars);
 
            await _mediaInfo.UpdateOneAsync(filter, update);
        }

        public async Task AddReviewAsync(Review review)
        {
            Console.WriteLine("Adding review: ", review);
            await _reviews.InsertOneAsync(review);
        }

        public async Task<List<Review>> GetReviewsByMediaIdAsync(string mediaId)
        {
            return await _reviews.Find(review => review.mediaId == mediaId).ToListAsync();
        }

    }
}
