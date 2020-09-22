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
    public class CurriculumTopicStudentCategoriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicStudentCategoriesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumTopicStudentCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicStudentCategory>>> GetCurriculumTopicStudentCategories()
        {
            return await _context.CurriculumTopicStudentCategories.ToListAsync();
        }

        // GET: api/CurriculumTopicStudentCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicStudentCategory>> GetCurriculumTopicStudentCategory(int id)
        {
            var curriculumTopicStudentCategory = await _context.CurriculumTopicStudentCategories.FindAsync(id);

            if (curriculumTopicStudentCategory == null)
            {
                return NotFound();
            }

            return curriculumTopicStudentCategory;
        }

        // PUT: api/CurriculumTopicStudentCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumTopicStudentCategory(int id, CurriculumTopicStudentCategory curriculumTopicStudentCategory)
        {
            if (id != curriculumTopicStudentCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumTopicStudentCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumTopicStudentCategoryExists(id))
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

        // POST: api/CurriculumTopicStudentCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopicStudentCategory>> PostCurriculumTopicStudentCategory(CurriculumTopicStudentCategory curriculumTopicStudentCategory)
        {
            _context.CurriculumTopicStudentCategories.Add(curriculumTopicStudentCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumTopicStudentCategory", new { id = curriculumTopicStudentCategory.Id }, curriculumTopicStudentCategory);
        }

        // DELETE: api/CurriculumTopicStudentCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicStudentCategory>> DeleteCurriculumTopicStudentCategory(int id)
        {
            var curriculumTopicStudentCategory = await _context.CurriculumTopicStudentCategories.FindAsync(id);
            if (curriculumTopicStudentCategory == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicStudentCategories.Remove(curriculumTopicStudentCategory);
            await _context.SaveChangesAsync();

            return curriculumTopicStudentCategory;
        }

        private bool CurriculumTopicStudentCategoryExists(int id)
        {
            return _context.CurriculumTopicStudentCategories.Any(e => e.Id == id);
        }
    }
}
