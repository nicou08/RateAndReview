namespace RateAndReview.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using RateAndReview.Services;
    using RateAndReview.Models;

    [Route("api/[controller]")]
    [ApiController]
    public class ShowController : ControllerBase
    {
        private readonly MongoDBService _mongoDBService;

        public ShowController(MongoDBService mongoDBService)
        {
            _mongoDBService = mongoDBService;
        }

        //[HttpGet]
        //public async Task<ActionResult<List<Show>>> Get()
        //{
        //    var show = await _mongoDBService.GetMediaDataAsync();
        //    return Ok(show);
        //}   
    }
}
