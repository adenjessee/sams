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
    public class CustomerCardsController : ControllerBase
    {
        private readonly SamsContext _context;

        public CustomerCardsController(SamsContext context)
        {
            _context = context;
        }

        // GET: api/CustomerCards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerCard>>> GetCustomerCards()
        {
            return await _context.CustomerCards.ToListAsync();
        }

        // GET: api/CustomerCards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerCard>> GetCustomerCard(int id)
        {
            var customerCard = await _context.CustomerCards.FindAsync(id);

            if (customerCard == null)
            {
                return NotFound();
            }

            return customerCard;
        }

        // PUT: api/CustomerCards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomerCard(int id, CustomerCard customerCard)
        {
            if (id != customerCard.Id)
            {
                return BadRequest();
            }

            _context.Entry(customerCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerCardExists(id))
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

        // POST: api/CustomerCards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CustomerCard>> PostCustomerCard(CustomerCard customerCard)
        {
            _context.CustomerCards.Add(customerCard);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomerCard", new { id = customerCard.Id }, customerCard);
        }

        // DELETE: api/CustomerCards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerCard(int id)
        {
            var customerCard = await _context.CustomerCards.FindAsync(id);
            if (customerCard == null)
            {
                return NotFound();
            }

            _context.CustomerCards.Remove(customerCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerCardExists(int id)
        {
            return _context.CustomerCards.Any(e => e.Id == id);
        }
    }
}
