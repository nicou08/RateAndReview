//namespace RateAndReview.Client.Services
//{
//    using System;
//    using System.Net.Http;
//    using System.Threading.Tasks;
//    public class RapidApiService 
//    {
//        private readonly HttpClient _httpClient;

//        public RapidApiService(HttpClient httpClient)
//        {
//            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
//        }

//        public async Task<string> GetMediaDetails(string id)
//        {
//            var request = new HttpRequestMessage
//            {
//                Method = HttpMethod.Get,
//                RequestUri = new Uri($"https://moviesdatabase.p.rapidapi.com/titles/{id}"),
//                Headers =
//                {
//                    { "X-RapidAPI-Key", "f39f280d33msh277b97c1b9cad2cp1ee8c6jsneb2da34a7ef1" },
//                    { "X-RapidAPI-Host", "moviesdatabase.p.rapidapi.com" },
//                },
//            };

//            using (var response = await _httpClient.SendAsync(request))
//            {
//                response.EnsureSuccessStatusCode();
//                var body = await response.Content.ReadAsStringAsync();
//                return body;
//            }
//        }
//    }
//}
