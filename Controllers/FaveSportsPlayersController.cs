using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaveSportsPlayersController : ControllerBase
    {
        private readonly TeamContext _context;

        public FaveSportsPlayersController(TeamContext context)
        {
            _context = context;
        }

        // GET: api/FaveSportsPlayers/5
        [HttpGet]
        public async Task<ActionResult<FaveSportsPlayer>> GetFaveSportsPlayer(int? id)
        {
            if (id == null || id == 0)
            {
                return Ok(await _context.FaveSportsPlayers.Take(5).ToListAsync());
            }

            var faveSportsPlayer = await _context.FaveSportsPlayers.FindAsync(id);

            if (faveSportsPlayer == null)
            {
                return NotFound();
            }

            return faveSportsPlayer;
        }

        // PUT: api/FaveSportsPlayers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaveSportsPlayer(int id, FaveSportsPlayer faveSportsPlayer)
        {
            if (id != faveSportsPlayer.Id)
            {
                return BadRequest();
            }

            _context.Entry(faveSportsPlayer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaveSportsPlayerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/FaveSportsPlayers
        [HttpPost]
        public async Task<ActionResult<FaveSportsPlayer>> PostFaveSportsPlayer(FaveSportsPlayer faveSportsPlayer)
        {
            faveSportsPlayer.Id = 0; // Prevents error from including id other than 0 or null in POST

            _context.FaveSportsPlayers.Add(faveSportsPlayer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaveSportsPlayer", new { id = faveSportsPlayer.Id }, faveSportsPlayer);
        }

        // DELETE: api/FaveSportsPlayers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaveSportsPlayer(int id)
        {
            var faveSportsPlayer = await _context.FaveSportsPlayers.FindAsync(id);
            if (faveSportsPlayer == null)
            {
                return NotFound();
            }

            _context.FaveSportsPlayers.Remove(faveSportsPlayer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FaveSportsPlayerExists(int id)
        {
            return _context.FaveSportsPlayers.Any(e => e.Id == id);
        }
    }
}
