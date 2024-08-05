using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Wandermate_backend.Data;
using Wandermate_backend.Models;

namespace Wandermate_backend.Controller
{
    [Route("Wandermate_backend/travel")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TravelController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var travels = _context.Travel.ToList();
            return Ok(travels);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var travel = _context.Travel.Find(id);

            if (travel == null)
            {
                return NotFound();
            }

            return Ok(travel);
        }
        [HttpPost]
        public IActionResult CreateTravel([FromBody] Travel travel)
        {
            if (travel== null)
            {
                return BadRequest();
            }

            _context.Travel.Add(travel);
            _context.SaveChanges();

            return Ok(travel);
        }
        [HttpPut("{id}")]

        public IActionResult UpdateTravel(int id, [FromBody] Travel updatedTravel)
        {
            

            if (updatedTravel == null)
            {
                return BadRequest();
            }
            var existingTravel = _context.Travel.Find(id);
            if (existingTravel == null)
            {
                return NotFound();
            }
            existingTravel.Name = updatedTravel.Name;
            existingTravel.Rating = updatedTravel.Rating;

            _context.Travel.Update(existingTravel);
            _context.SaveChanges();

            return Ok(existingTravel);
        }

[HttpDelete("{id}")]
public IActionResult DeleteTravel(int id, [FromBody] Travel deleteTravel)
{
    var travel = _context.Travel.Find(id);

    if (travel == null)
    {
        return NotFound();
    }

    _context.Travel.Remove(travel);
    _context.SaveChanges();

    return NoContent();
}
    }
}
