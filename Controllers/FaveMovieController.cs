using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaveMoviesController : ControllerBase
    {
        private readonly TeamContext _context;

        public FaveMoviesController(TeamContext context)
        {
            _context = context;
        }

        // GET: api/FaveMovies/5
        [HttpGet]
        public async Task<ActionResult<FaveMovie>> GetFaveMovie(int? id)
        {
            if (_context.FaveMovies == null)
            {
                return NotFound();
            }
            if (id == null || id == 0)
            {
                return Ok(await _context.FaveMovies.Take(5).ToListAsync());
            }
            var faveMovie = await _context.FaveMovies.FindAsync(id);

            if (faveMovie == null)
            {
                return NotFound();
            }

            return faveMovie;
        }

        // PUT: api/FaveMovies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFaveMovie(int id, FaveMovie faveMovie)
        {
            if (id != faveMovie.Id)
            {
                return BadRequest();
            }

            _context.Entry(faveMovie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FaveMovieExists(id))
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

        // POST: api/FaveMovies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FaveMovie>> PostFaveMovie(FaveMovie faveMovie)
        {
            if (_context.FaveMovies == null)
            {
                return NotFound();
            }

            faveMovie.Id = 0; // Prevents error from including id other than 0 or null in POST

            _context.FaveMovies.Add(faveMovie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFaveMovie", new { id = faveMovie.Id }, faveMovie);
        }

        // DELETE: api/FaveMovies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFaveMovie(int id)
        {
            if (_context.FaveMovies == null)
            {
                return NotFound();
            }
            var faveMovie = await _context.FaveMovies.FindAsync(id);
            if (faveMovie == null)
            {
                return NotFound();
            }

            _context.FaveMovies.Remove(faveMovie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FaveMovieExists(int id)
        {
            return (_context.FaveMovies?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
