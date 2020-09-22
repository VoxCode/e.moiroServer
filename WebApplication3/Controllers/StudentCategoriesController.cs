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
    public class StudentCategoriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public StudentCategoriesController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/StudentCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentCategory>>> GetStudentCategories()
        {
            return await _context.StudentCategories.ToListAsync();
        }

        // GET: api/StudentCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentCategory>> GetStudentCategory(int id)
        {
            var studentCategory = await _context.StudentCategories.FindAsync(id);

            if (studentCategory == null)
            {
                return NotFound();
            }

            return studentCategory;
        }

        // PUT: api/StudentCategories/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentCategory(int id, StudentCategory studentCategory)
        {
            if (id != studentCategory.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentCategoryExists(id))
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

        // POST: api/StudentCategories
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<StudentCategory>> PostStudentCategory(StudentCategory studentCategory)
        {
            _context.StudentCategories.Add(studentCategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStudentCategory", new { id = studentCategory.Id }, studentCategory);
        }

        // DELETE: api/StudentCategories/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentCategory>> DeleteStudentCategory(int id)
        {
            var studentCategory = await _context.StudentCategories.FindAsync(id);
            if (studentCategory == null)
            {
                return NotFound();
            }

            _context.StudentCategories.Remove(studentCategory);
            await _context.SaveChangesAsync();

            return studentCategory;
        }

        private bool StudentCategoryExists(int id)
        {
            return _context.StudentCategories.Any(e => e.Id == id);
        }
    }
}
