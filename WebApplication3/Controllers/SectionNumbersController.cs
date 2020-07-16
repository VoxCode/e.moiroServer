using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionNumbersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public SectionNumbersController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/SectionNumbers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SectionNumber>>> GetSectionNumbers()
        {
            return await _context.SectionNumbers.ToListAsync();
        }

        // GET: api/SectionNumbers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SectionNumber>> GetSectionNumber(int id)
        {
            var sectionNumber = await _context.SectionNumbers.FindAsync(id);

            if (sectionNumber == null)
            {
                return NotFound();
            }

            return sectionNumber;
        }

        // PUT: api/SectionNumbers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSectionNumber(int id, SectionNumber sectionNumber)
        {
            if (id != sectionNumber.Id)
            {
                return BadRequest();
            }

            _context.Entry(sectionNumber).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectionNumberExists(id))
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

        // POST: api/SectionNumbers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SectionNumber>> PostSectionNumber(SectionNumber sectionNumber)
        {
            _context.SectionNumbers.Add(sectionNumber);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSectionNumber", new { id = sectionNumber.Id }, sectionNumber);
        }

        // DELETE: api/SectionNumbers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SectionNumber>> DeleteSectionNumber(int id)
        {
            var sectionNumber = await _context.SectionNumbers.FindAsync(id);
            if (sectionNumber == null)
            {
                return NotFound();
            }

            _context.SectionNumbers.Remove(sectionNumber);
            await _context.SaveChangesAsync();

            return sectionNumber;
        }

        private bool SectionNumberExists(int id)
        {
            return _context.SectionNumbers.Any(e => e.Id == id);
        }
    }
}
