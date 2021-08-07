using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using IT3045C_FinalProject.Data;
using IT3045_FinalProject.Models;

namespace IT3045C_FinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbyController : ControllerBase
    {
        private readonly ILogger<HobbyController> _logger;
        private readonly MemberInfo _ctx;
        public HobbyController(ILogger<HobbyController> logger, MemberInfo ctx)
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
                return Ok(_ctx.Hobbies.Take(5).ToList());

            var member = _ctx.Hobbies.Find(id);
            if (member == null)
                return NotFound();

            return Ok(member);
        }

        [HttpPut]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Put))]
        public IActionResult Put(Hobby hobby)
        {
            if (hobby.Id == null || hobby.Id < 1)
                return BadRequest("Invalid member Id");

            var dbInfo = _ctx.Hobbies.Find(hobby.Id);

            if (dbInfo == null)
                return NotFound();

            dbInfo.FullName = hobby.FullName;
            dbInfo.FavoriteHobby = hobby.FavoriteHobby;
            dbInfo.SecondFavoriteHobby = hobby.SecondFavoriteHobby;
            dbInfo.ThirdFavoriteHobby = hobby.ThirdFavoriteHobby;
            _ctx.Hobbies.Update(dbInfo);
            var changes = _ctx.SaveChanges();

            if (changes > 0)
                return NoContent();


            return StatusCode(500, "Error occured on the server. Please try again in a few minutes.");
        }

        [HttpPost]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Post))]
        public IActionResult Post(Hobby hobby)
        {
            if (string.IsNullOrEmpty(hobby.FullName))
            {
                return BadRequest("Must include a Full Name for the member.");
            }
            if (string.IsNullOrEmpty(hobby.FavoriteHobby))
            {
                return BadRequest("Must include a Favorite Hobby.");
            }
            if (string.IsNullOrEmpty(hobby.SecondFavoriteHobby))
            {
                return BadRequest("Must include a Second Favorite Hobby.");
            }
            if (string.IsNullOrEmpty(hobby.ThirdFavoriteHobby))
            {
                return BadRequest("Must include a Third Favorite Hobby.");
            }

            hobby.Id = null;
            _ctx.Hobbies.Add(hobby);
            var changes = _ctx.SaveChanges();
            if (changes > 0)
                return NoContent();

            return StatusCode(500, "Please try again later");
        }

        [HttpDelete]
        [ApiConventionMethod(typeof(DefaultApiConventions),
              nameof(DefaultApiConventions.Delete))]
        public IActionResult Delete(int? id, Hobby hobby)
        {
            if (id == null || id < 1)
                return BadRequest("Invalid member Id");

            var member = _ctx.Hobbies.Find(id);
            if (member == null)
                return NotFound();

            _ctx.Hobbies.Remove(member);
            var changes = _ctx.SaveChanges();

            if (changes > 0)
                return NoContent();

            return StatusCode(500, "Please try again later");
        }

    }
}