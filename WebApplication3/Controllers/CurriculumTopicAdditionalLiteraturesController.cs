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
    public class CurriculumTopicAdditionalLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicAdditionalLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumTopicAdditionalLiteratures
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicAdditionalLiterature>>> GetCurriculumTopicAdditionalLiteratures()
        {
            return await _context.CurriculumTopicAdditionalLiteratures.ToListAsync();
        }

        // GET: api/CurriculumTopicAdditionalLiteratures/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicAdditionalLiterature>> GetCurriculumTopicAdditionalLiterature(int id)
        {
            var curriculumTopicAdditionalLiterature = await _context.CurriculumTopicAdditionalLiteratures.FindAsync(id);

            if (curriculumTopicAdditionalLiterature == null)
            {
                return NotFound();
            }

            return curriculumTopicAdditionalLiterature;
        }

        // PUT: api/CurriculumTopicAdditionalLiteratures/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumTopicAdditionalLiterature(int id, CurriculumTopicAdditionalLiterature curriculumTopicAdditionalLiterature)
        {
            if (id != curriculumTopicAdditionalLiterature.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumTopicAdditionalLiterature).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumTopicAdditionalLiteratureExists(id))
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

        // POST: api/CurriculumTopicAdditionalLiteratures
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopicAdditionalLiterature>> PostCurriculumTopicAdditionalLiterature(CurriculumTopicAdditionalLiterature curriculumTopicAdditionalLiterature)
        {
            _context.CurriculumTopicAdditionalLiteratures.Add(curriculumTopicAdditionalLiterature);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumTopicAdditionalLiterature", new { id = curriculumTopicAdditionalLiterature.Id }, curriculumTopicAdditionalLiterature);
        }

        // DELETE: api/CurriculumTopicAdditionalLiteratures/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicAdditionalLiterature>> DeleteCurriculumTopicAdditionalLiterature(int id)
        {
            var curriculumTopicAdditionalLiterature = await _context.CurriculumTopicAdditionalLiteratures.FindAsync(id);
            if (curriculumTopicAdditionalLiterature == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicAdditionalLiteratures.Remove(curriculumTopicAdditionalLiterature);
            await _context.SaveChangesAsync();

            return curriculumTopicAdditionalLiterature;
        }

        private bool CurriculumTopicAdditionalLiteratureExists(int id)
        {
            return _context.CurriculumTopicAdditionalLiteratures.Any(e => e.Id == id);
        }
    }
}
