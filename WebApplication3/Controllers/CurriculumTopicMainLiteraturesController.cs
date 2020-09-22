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
    public class CurriculumTopicMainLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicMainLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumTopicMainLiteratures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicMainLiterature>>> GetCurriculumTopicMainLiteratures()
        {
            return await _context.CurriculumTopicMainLiteratures.ToListAsync();
        }

        // GET: api/CurriculumTopicMainLiteratures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicMainLiterature>> GetCurriculumTopicMainLiterature(int id)
        {
            var curriculumTopicMainLiterature = await _context.CurriculumTopicMainLiteratures.FindAsync(id);

            if (curriculumTopicMainLiterature == null)
            {
                return NotFound();
            }

            return curriculumTopicMainLiterature;
        }

        // PUT: api/CurriculumTopicMainLiteratures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumTopicMainLiterature(int id, CurriculumTopicMainLiterature curriculumTopicMainLiterature)
        {
            if (id != curriculumTopicMainLiterature.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumTopicMainLiterature).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumTopicMainLiteratureExists(id))
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

        // POST: api/CurriculumTopicMainLiteratures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopicMainLiterature>> PostCurriculumTopicMainLiterature(CurriculumTopicMainLiterature curriculumTopicMainLiterature)
        {
            _context.CurriculumTopicMainLiteratures.Add(curriculumTopicMainLiterature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumTopicMainLiterature", new { id = curriculumTopicMainLiterature.Id }, curriculumTopicMainLiterature);
        }

        // DELETE: api/CurriculumTopicMainLiteratures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicMainLiterature>> DeleteCurriculumTopicMainLiterature(int id)
        {
            var curriculumTopicMainLiterature = await _context.CurriculumTopicMainLiteratures.FindAsync(id);
            if (curriculumTopicMainLiterature == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicMainLiteratures.Remove(curriculumTopicMainLiterature);
            await _context.SaveChangesAsync();

            return curriculumTopicMainLiterature;
        }

        private bool CurriculumTopicMainLiteratureExists(int id)
        {
            return _context.CurriculumTopicMainLiteratures.Any(e => e.Id == id);
        }
    }
}
