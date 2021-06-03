using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sams.Data;
using Sams.Data.DataModels;

namespace Sams.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSetsController : ControllerBase
    {
        private readonly SamsContext _context;

        public TimeSetsController(SamsContext context)
        {
            _context = context;
        }

        // GET: api/TimeSets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimeSet>>> GetTimeSets()
        {
            return await _context.TimeSets.ToListAsync();
        }

        // GET: api/TimeSets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TimeSet>> GetTimeSet(int id)
        {
            var timeSet = await _context.TimeSets.FindAsync(id);

            if (timeSet == null)
            {
                return NotFound();
            }

            return timeSet;
        }

        // PUT: api/TimeSets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTimeSet(int id, TimeSet timeSet)
        {
            if (id != timeSet.Id)
            {
                return BadRequest();
            }

            _context.Entry(timeSet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TimeSetExists(id))
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

        // POST: api/TimeSets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TimeSet>> PostTimeSet(TimeSet timeSet)
        {
            _context.TimeSets.Add(timeSet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTimeSet", new { id = timeSet.Id }, timeSet);
        }

        // DELETE: api/TimeSets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTimeSet(int id)
        {
            var timeSet = await _context.TimeSets.FindAsync(id);
            if (timeSet == null)
            {
                return NotFound();
            }

            _context.TimeSets.Remove(timeSet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TimeSetExists(int id)
        {
            return _context.TimeSets.Any(e => e.Id == id);
        }
    }
}
