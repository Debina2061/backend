
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wandermate_backend.Data;
using Wandermate_backend.Models;

namespace Wandermate_backend.Controller
{
    [Route("Wandermate_backend/hotel")]
    [ApiController]
    public class HotelReviewController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HotelReviewController(ApplicationDbContext context)
        {
            _context = context;

        }
        [HttpGet]
         public async Task<IActionResult> GetAll() 
        {
            var hotelReview = await _context.HotelReview.ToListAsync();
            return Ok(hotelReview);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id) 
        {
            var hotel = await _context.Hotel.FindAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateHotel([FromBody] Hotel hotel)
        {
            
            if (hotel == null)
            {
                return BadRequest();
            }
try
            {
                await _context.Hotel.AddAsync(hotel);
                await _context.SaveChangesAsync();
                return CreatedAtAction(nameof(GetById), new { id = hotel.Id }, hotel);
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, ex);
            }
        }
        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateHotel(int id, [FromBody] Hotel updatedHotel)
        {
            
var hotelInDatabase = await _context.Hotel.FindAsync(id);
            if (updatedHotel == null)
            {
                return BadRequest();
            }
            var existingHotel = _context.Hotel.Find(id);
            if (existingHotel == null)
            {
                return NotFound();
            }
            existingHotel.Name = updatedHotel.Name;
            existingHotel.Rating = updatedHotel.Rating;

            _context.Hotel.Update(existingHotel);
            _context.SaveChanges();

            return Ok(existingHotel);
        }

[HttpDelete("{id}")]
 public async Task<IActionResult> DeleteHotel([FromRoute] int id) 
{
    var hotel = await _context.Hotel.FindAsync(id);

    if (hotel == null)
    {
        return NotFound();
    }

    _context.Hotel.Remove(hotel);
    _context.SaveChanges();

    return NoContent();
}

    }
}