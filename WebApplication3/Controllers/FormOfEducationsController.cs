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
    public class FormOfEducationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FormOfEducationsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/FormOfEducations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormOfEducation>>> GetFormOfEducations()
        {
            return await _context.FormOfEducations.ToListAsync();
        }

        // GET: api/FormOfEducations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FormOfEducation>> GetFormOfEducation(int id)
        {
            var formOfEducation = await _context.FormOfEducations.FindAsync(id);

            if (formOfEducation == null)
            {
                return NotFound();
            }

            return formOfEducation;
        }

        // PUT: api/FormOfEducations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFormOfEducation(int id, FormOfEducation formOfEducation)
        {
            if (id != formOfEducation.Id)
            {
                return BadRequest();
            }

            _context.Entry(formOfEducation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FormOfEducationExists(id))
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

        // POST: api/FormOfEducations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FormOfEducation>> PostFormOfEducation(FormOfEducation formOfEducation)
        {
            _context.FormOfEducations.Add(formOfEducation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFormOfEducation", new { id = formOfEducation.Id }, formOfEducation);
        }

        // DELETE: api/FormOfEducations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FormOfEducation>> DeleteFormOfEducation(int id)
        {
            var formOfEducation = await _context.FormOfEducations.FindAsync(id);
            if (formOfEducation == null)
            {
                return NotFound();
            }

            _context.FormOfEducations.Remove(formOfEducation);
            await _context.SaveChangesAsync();

            return formOfEducation;
        }

        private bool FormOfEducationExists(int id)
        {
            return _context.FormOfEducations.Any(e => e.Id == id);
        }
    }
}
