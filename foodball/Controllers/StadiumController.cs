﻿using foodball.Data;
using foodball.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace foodball.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StadiumController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StadiumController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetStadium()
        {
            var teams = await _context.Teams.ToListAsync();
            return Ok(teams);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStadium([FromBody] Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetStadium), new { id = team.Id }, team);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStadium(int id, Team team)
        {
            if (id != team.Id) return BadRequest();

            _context.Entry(team).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStadium(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
                return NotFound();

            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
            return NoContent();
             

        }
    }
}
