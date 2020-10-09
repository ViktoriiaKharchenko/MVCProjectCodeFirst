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
    public class TypesController : ControllerBase
    {
        private readonly InsuranceContext _context;

        public TypesController(InsuranceContext context)
        {
            _context = context;
        }

        // GET: api/Types
        [HttpGet]
        public async Task<IActionResult> GetTypes()
        {
            return Ok(await _context.Types.ToListAsync());
        }

        // GET: api/Types/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTypes(int id)
        {
            var types = await _context.Types.FindAsync(id);

            if (types == null)
            {
                return NotFound();
            }

            return Ok(types);
        }

        // PUT: api/Types/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTypes(int id, Types types)
        {
            if (id != types.Id)
            {
                return BadRequest();
            }

            _context.Entry(types).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(types);
        }

        // POST: api/Types
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<IActionResult> PostTypes(Types types)
        {
            _context.Types.Add(types);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTypes", new { id = types.Id }, types);
        }

        // DELETE: api/Types/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTypes(int id)
        {
            var types = await _context.Types.FindAsync(id);
            if (types == null)
            {
                return NotFound();
            }
            var docs = _context.Documents.Where(b => b.TypeId == id).ToList();
            foreach (var doc in docs)
            {
                _context.Documents.Remove(doc);
            }
            _context.Types.Remove(types);
            await _context.SaveChangesAsync();

            return Ok(types);
        }

        private bool TypesExists(int id)
        {
            return _context.Types.Any(e => e.Id == id);
        }
    }
}