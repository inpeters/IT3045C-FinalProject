using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using IT3045C_FinalProject.Data;
using IT3045C_FinalProject.Models;

namespace IT3045C_FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DinnerFoodController : ControllerBase
    {
        private readonly ILogger<DinnerFoodController> _logger;
        private readonly MemberInfo _ctx;
        public DinnerFoodController(ILogger<DinnerFoodController> logger, MemberInfo ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        [HttpGet]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Get))]
        public IActionResult Get(int? id)
        {
            if (id == null || id < 1)
                return Ok(_ctx.Foods.Take(5).ToList());

            var member = _ctx.Foods.Find(id);
            if (member == null)
                return NotFound();

            return Ok(member);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Food food)
        {
            if (food.Id == null || food.Id < 1)
                return BadRequest("Invalid member Id");

            var dbInfo = _ctx.Foods.Find(food.Id);

            if (dbInfo == null)
                return NotFound();

            dbInfo.FullName = food.FullName;
            dbInfo.FavoriteFood = food.FavoriteFood;
            dbInfo.SecondFavoriteFood = food.SecondFavoriteFood;
            dbInfo.FavoriteMealTime = food.FavoriteMealTime;
            _ctx.Foods.Update(dbInfo);
            var changes = _ctx.SaveChanges();

            if (changes > 0)
                return NoContent();


            return StatusCode(500, "Error occured on the server. Please try again in a few minutes.");
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Post))]
        public IActionResult Post(Food food)
        {
            if (string.IsNullOrEmpty(food.FullName))
            {
                return BadRequest("Must include a Full Name for the member.");
            }
            if (string.IsNullOrEmpty(food.FavoriteFood))
            {
                return BadRequest("Must include a Favorite Dinner Food.");
            }
            if (string.IsNullOrEmpty(food.SecondFavoriteFood))
            {
                return BadRequest("Must include a Second Favorite Dinner Food.");
            }
            if (string.IsNullOrEmpty(food.FavoriteMealTime))
            {
                return BadRequest("Must include Why Your Favorite Meal Time For Dinner.");
            }

            food.Id = null;
            _ctx.Foods.Add(food);
            var changes = _ctx.SaveChanges();
            if (changes > 0)
                return NoContent();

            return StatusCode(500, "Please try again later");
        }

        [HttpDelete]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Delete))]
        public IActionResult Delete(int? id, Food food)
        {
            if (id == null || id < 1)
                return BadRequest("Invalid member Id");

            var member = _ctx.Foods.Find(id);
            if (member == null)
                return NotFound();

            _ctx.Foods.Remove(member);
            var changes = _ctx.SaveChanges();

            if (changes > 0)
                return NoContent();

            return StatusCode(500, "Please try again later");
        }

    }
}