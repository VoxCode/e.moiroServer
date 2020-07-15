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
    public class OccupationFormsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public OccupationFormsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/OccupationForms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OccupationForm>>> GetOccupationForms()
        {
            return await _context.OccupationForms.ToListAsync();
        }

        // GET: api/OccupationForms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OccupationForm>> GetOccupationForm(int id)
        {
            var occupationForm = await _context.OccupationForms.FindAsync(id);

            if (occupationForm == null)
            {
                return NotFound();
            }

            return occupationForm;
        }

        // PUT: api/OccupationForms/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOccupationForm(int id, OccupationForm occupationForm)
        {
            if (id != occupationForm.Id)
            {
                return BadRequest();
            }

            _context.Entry(occupationForm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OccupationFormExists(id))
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

        // POST: api/OccupationForms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<OccupationForm>> PostOccupationForm(OccupationForm occupationForm)
        {
            _context.OccupationForms.Add(occupationForm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOccupationForm", new { id = occupationForm.Id }, occupationForm);
        }

        // DELETE: api/OccupationForms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OccupationForm>> DeleteOccupationForm(int id)
        {
            var occupationForm = await _context.OccupationForms.FindAsync(id);
            if (occupationForm == null)
            {
                return NotFound();
            }

            _context.OccupationForms.Remove(occupationForm);
            await _context.SaveChangesAsync();

            return occupationForm;
        }

        private bool OccupationFormExists(int id)
        {
            return _context.OccupationForms.Any(e => e.Id == id);
        }
    }
}
