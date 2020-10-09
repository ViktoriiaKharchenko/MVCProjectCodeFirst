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
    public class BrokersCategoriesController : ControllerBase
    {
        private readonly InsuranceContext _context;

        public BrokersCategoriesController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: api/BrokersCategories
        [HttpGet]
        public async Task<IActionResult> GetBrokersCategories()
        {
            return Ok(await _context.BrokersCategories.ToListAsync());
        }

        // GET: api/BrokersCategories/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrokersCategories(int id)
        {
            var brokersCategories = await _context.BrokersCategories.FindAsync(id);

            if (brokersCategories == null)
            {
                return NotFound();
            }

            return Ok(brokersCategories);
        }

        // PUT: api/BrokersCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBrokersCategories(int id, BrokersCategories brokersCategories)
        {
            if (id != brokersCategories.Id)
            {
                return BadRequest();
            }

            _context.Entry(brokersCategories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BrokersCategoriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(brokersCategories);
        }

        // POST: api/BrokersCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<IActionResult> PostBrokersCategories(BrokersCategories brokersCategories)
        {
            _context.BrokersCategories.Add(brokersCategories);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBrokersCategories", new { id = brokersCategories.Id }, brokersCategories);
        }

        // DELETE: api/BrokersCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBrokersCategories(int id)
        {
            var brokersCategories = await _context.BrokersCategories.FindAsync(id);
            if (brokersCategories == null)
            {
                return NotFound();
            }

            _context.BrokersCategories.Remove(brokersCategories);
            await _context.SaveChangesAsync();

            return Ok(brokersCategories);
        }

        private bool BrokersCategoriesExists(int id)
        {
            return _context.BrokersCategories.Any(e => e.Id == id);
        }
    }
}