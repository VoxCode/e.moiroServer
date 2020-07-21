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
    public class AdditionalLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public AdditionalLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/AdditionalLiteratures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdditionalLiterature>>> GetAdditionalLiteratures()
        {
            return await _context.AdditionalLiteratures.ToListAsync();
        }

        // GET: api/AdditionalLiteratures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AdditionalLiterature>> GetAdditionalLiterature(int id)
        {
            var additionalLiterature = await _context.AdditionalLiteratures.FindAsync(id);

            if (additionalLiterature == null)
            {
                return NotFound();
            }

            return additionalLiterature;
        }

        // PUT: api/AdditionalLiteratures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAdditionalLiterature(int id, AdditionalLiterature additionalLiterature)
        {
            if (id != additionalLiterature.Id)
            {
                return BadRequest();
            }

            _context.Entry(additionalLiterature).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdditionalLiteratureExists(id))
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

        // POST: api/AdditionalLiteratures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AdditionalLiterature>> PostAdditionalLiterature(AdditionalLiterature additionalLiterature)
        {
            _context.AdditionalLiteratures.Add(additionalLiterature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAdditionalLiterature", new { id = additionalLiterature.Id }, additionalLiterature);
        }

        // DELETE: api/AdditionalLiteratures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AdditionalLiterature>> DeleteAdditionalLiterature(int id)
        {
            var additionalLiterature = await _context.AdditionalLiteratures.FindAsync(id);
            if (additionalLiterature == null)
            {
                return NotFound();
            }

            _context.AdditionalLiteratures.Remove(additionalLiterature);
            await _context.SaveChangesAsync();

            return additionalLiterature;
        }

        private bool AdditionalLiteratureExists(int id)
        {
            return _context.AdditionalLiteratures.Any(e => e.Id == id);
        }
    }
}
