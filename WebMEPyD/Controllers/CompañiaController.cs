using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebMEPyD.Data;
using WebMEPyD.Model;

namespace WebMEPyD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompañiaController : ControllerBase
    {
        private readonly WebMEPyDContext _context;

        public CompañiaController(WebMEPyDContext context)
        {
            _context = context;
        }

        // GET: api/Compañia
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Compañia>>> GetCompañia()
        {
          if (_context.Compañia == null)
          {
              return NotFound();
          }
            return await _context.Compañia.ToListAsync();
        }

        // GET: api/Compañia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Compañia>> GetCompañia(int id)
        {
          if (_context.Compañia == null)
          {
              return NotFound();
          }
            var compañia = await _context.Compañia.FindAsync(id);

            if (compañia == null)
            {
                return NotFound();
            }

            return compañia;
        }

        // PUT: api/Compañia/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompañia(int id, Compañia compañia)
        {
            if (id != compañia.IdCompañia)
            {
                return BadRequest();
            }

            _context.Entry(compañia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompañiaExists(id))
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

        // POST: api/Compañia
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Compañia>> PostCompañia(Compañia compañia)
        {
          if (_context.Compañia == null)
          {
              return Problem("Entity set 'WebMEPyDContext.Compañia'  is null.");
          }
            _context.Compañia.Add(compañia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompañia", new { id = compañia.IdCompañia }, compañia);
        }

        // DELETE: api/Compañia/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompañia(int id)
        {
            if (_context.Compañia == null)
            {
                return NotFound();
            }
            var compañia = await _context.Compañia.FindAsync(id);
            if (compañia == null)
            {
                return NotFound();
            }

            _context.Compañia.Remove(compañia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompañiaExists(int id)
        {
            return (_context.Compañia?.Any(e => e.IdCompañia == id)).GetValueOrDefault();
        }
    }
}
