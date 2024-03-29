﻿using MongoDB.Bson;

namespace RateAndReview.Models
{
    public class Media
    {
        public ObjectId _id { get; set; }
        public string imdbID { get; set; }
        public string mediaTitle { get; set; }
        public string mediaType { get; set; }
        public string mediaPoster { get; set; }
        public string releaseDate { get; set; }
        public string endDate { get; set; }
        public float rating { get; set; }
        public int numberOfReviews { get; set; }
        public int number5Stars { get; set; }
        public int number4Stars { get; set; }
        public int number3Stars { get; set; }
        public int number2Stars { get; set; }
        public int number1Stars { get; set; }
    }
}
