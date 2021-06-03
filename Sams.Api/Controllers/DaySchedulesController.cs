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
    public class DaySchedulesController : ControllerBase
    {
        private readonly SamsContext _context;

        public DaySchedulesController(SamsContext context)
        {
            _context = context;
        }

        // GET: api/DaySchedules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DaySchedule>>> GetDaySchedules()
        {
            return await _context.DaySchedules.ToListAsync();
        }

        // GET: api/DaySchedules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DaySchedule>> GetDaySchedule(int id)
        {
            var daySchedule = await _context.DaySchedules.FindAsync(id);

            if (daySchedule == null)
            {
                return NotFound();
            }

            return daySchedule;
        }

        // PUT: api/DaySchedules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDaySchedule(int id, DaySchedule daySchedule)
        {
            if (id != daySchedule.Id)
            {
                return BadRequest();
            }

            _context.Entry(daySchedule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DayScheduleExists(id))
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

        // POST: api/DaySchedules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DaySchedule>> PostDaySchedule(DaySchedule daySchedule)
        {
            _context.DaySchedules.Add(daySchedule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDaySchedule", new { id = daySchedule.Id }, daySchedule);
        }

        // DELETE: api/DaySchedules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDaySchedule(int id)
        {
            var daySchedule = await _context.DaySchedules.FindAsync(id);
            if (daySchedule == null)
            {
                return NotFound();
            }

            _context.DaySchedules.Remove(daySchedule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DayScheduleExists(int id)
        {
            return _context.DaySchedules.Any(e => e.Id == id);
        }
    }
}
