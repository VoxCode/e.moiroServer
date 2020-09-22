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
    public class CurriculumTopicTestWorksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicTestWorksController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumTopicTestWorks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicTestWork>>> GetCurriculumTopicTestWorks()
        {
            return await _context.CurriculumTopicTestWorks.ToListAsync();
        }

        // GET: api/CurriculumTopicTestWorks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicTestWork>> GetCurriculumTopicTestWork(int id)
        {
            var curriculumTopicTestWork = await _context.CurriculumTopicTestWorks.FindAsync(id);

            if (curriculumTopicTestWork == null)
            {
                return NotFound();
            }

            return curriculumTopicTestWork;
        }

        // PUT: api/CurriculumTopicTestWorks/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumTopicTestWork(int id, CurriculumTopicTestWork curriculumTopicTestWork)
        {
            if (id != curriculumTopicTestWork.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumTopicTestWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumTopicTestWorkExists(id))
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

        // POST: api/CurriculumTopicTestWorks
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopicTestWork>> PostCurriculumTopicTestWork(CurriculumTopicTestWork curriculumTopicTestWork)
        {
            _context.CurriculumTopicTestWorks.Add(curriculumTopicTestWork);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumTopicTestWork", new { id = curriculumTopicTestWork.Id }, curriculumTopicTestWork);
        }

        // DELETE: api/CurriculumTopicTestWorks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicTestWork>> DeleteCurriculumTopicTestWork(int id)
        {
            var curriculumTopicTestWork = await _context.CurriculumTopicTestWorks.FindAsync(id);
            if (curriculumTopicTestWork == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicTestWorks.Remove(curriculumTopicTestWork);
            await _context.SaveChangesAsync();

            return curriculumTopicTestWork;
        }

        private bool CurriculumTopicTestWorkExists(int id)
        {
            return _context.CurriculumTopicTestWorks.Any(e => e.Id == id);
        }
    }
}
