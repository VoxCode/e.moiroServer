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
    public class TeacherCategoriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TeacherCategoriesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/TeacherCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherCategory>>> GetTeacherCategories()
        {
            return await _context.TeacherCategories.ToListAsync();
        }

        // GET: api/TeacherCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherCategory>> GetTeacherCategory(int id)
        {
            var teacherCategory = await _context.TeacherCategories.FindAsync(id);

            if (teacherCategory == null)
            {
                return NotFound();
            }

            return teacherCategory;
        }

        // PUT: api/TeacherCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacherCategory(int id, TeacherCategory teacherCategory)
        {
            if (id != teacherCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(teacherCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherCategoryExists(id))
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

        // POST: api/TeacherCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TeacherCategory>> PostTeacherCategory(TeacherCategory teacherCategory)
        {
            _context.TeacherCategories.Add(teacherCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeacherCategory", new { id = teacherCategory.Id }, teacherCategory);
        }

        // DELETE: api/TeacherCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TeacherCategory>> DeleteTeacherCategory(int id)
        {
            var teacherCategory = await _context.TeacherCategories.FindAsync(id);
            if (teacherCategory == null)
            {
                return NotFound();
            }

            _context.TeacherCategories.Remove(teacherCategory);
            await _context.SaveChangesAsync();

            return teacherCategory;
        }

        private bool TeacherCategoryExists(int id)
        {
            return _context.TeacherCategories.Any(e => e.Id == id);
        }
    }
}
