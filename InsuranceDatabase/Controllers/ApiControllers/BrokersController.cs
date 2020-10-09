using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceDatabase.Controllers.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrokersController : ControllerBase
    {
        private readonly InsuranceContext _context;

        public BrokersController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: api/Brokers
        [HttpGet]
        public async Task<IActionResult> GetBrokers()
        {
            return Ok(await _context.Brokers.ToListAsync());
        }

        // GET: api/Brokers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrokers(int id)
        {
            var brokers = await _context.Brokers.FindAsync(id);

            if (brokers == null)
            {
                return NotFound();
            }

            return Ok(brokers);
        }

        // PUT: api/Brokers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrokers(int id, Brokers brokers)
        {
            if (id != brokers.Id)
            {
                return BadRequest();
            }

            _context.Entry(brokers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrokersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(brokers);
        }

        // POST: api/Brokers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<IActionResult> PostBrokers(Brokers brokers)
        {
            _context.Brokers.Add(brokers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrokers", new { id = brokers.Id }, brokers);
        }

        // DELETE: api/Brokers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrokers(int id)
        {
            var brokers = await _context.Brokers.FindAsync(id);
            if (brokers == null)
            {
                return NotFound();
            }
            var docs = _context.Documents.Where(b => b.BrokerId == id).ToList();
            var brokersCategories = _context.BrokersCategories.Where(b => b.BrokerId == id).ToList();
            foreach (var doc in docs)
            {
                _context.Documents.Remove(doc);
            }
            foreach (var bc in brokersCategories)
            {
                _context.BrokersCategories.Remove(bc);
            }
            _context.Brokers.Remove(brokers);
            await _context.SaveChangesAsync();

            return Ok(brokers);
        }

        private bool BrokersExists(int id)
        {
            return _context.Brokers.Any(e => e.Id == id);
        }
    }
}
