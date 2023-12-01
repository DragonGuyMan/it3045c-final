using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Models;
using MessagePack;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly TeamContext _context;

        public JobsController(TeamContext context)
        {
            _context = context;
        }


        // GET: api/Jobs/5
        [HttpGet]
        //Return a specific entry from the jobs table
        public async Task<ActionResult> GetJob(int? id)
        {
            if (_context.Jobs == null)
            {
                return NotFound();
            }

            if (id == null || id == 0)
            {
                return Ok(await _context.Jobs.Take(5).ToListAsync());
            }

            var job = await _context.Jobs.FindAsync(id);

            if (job == null)
            {
                return NotFound();
            }

            return Ok(job);
        }

        // PUT: api/Jobs/5
        [HttpPut("{id}")]
        //This updates an entry in the jobs table
        public async Task<IActionResult> PutJob(int id, Job job)
        {
            if (id != job.Id)
            {
                return BadRequest();
            }

            _context.Entry(job).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JobExists(id))
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

        // POST: api/Jobs
        [HttpPost]
        //Add a new entry to the Jobs table
        public async Task<ActionResult<Job>> PostJob(Job job)
        {
          if (_context.Jobs == null)
          {
              return Problem("Entity set 'TeamContext.Jobs'  is null.");
          }
            job.Id = 0;
            _context.Jobs.Add(job);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJob", new { id = job.Id }, job);
        }

        // DELETE: api/Jobs/5
        [HttpDelete("{id}")]
        //Remove an entry from the Jobs table
        public async Task<IActionResult> DeleteJob(int id)
        {
            if (_context.Jobs == null)
            {
                return NotFound();
            }
            var job = await _context.Jobs.FindAsync(id);
            if (job == null)
            {
                return NotFound();
            }

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JobExists(int id)
        {
            return (_context.Jobs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
