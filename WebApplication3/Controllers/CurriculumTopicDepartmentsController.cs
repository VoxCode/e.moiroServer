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
    public class CurriculumTopicDepartmentsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicDepartmentsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/CurriculumTopicDepartments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicDepartment>>> GetCurriculumTopicDepartments()
        {
            return await _context.CurriculumTopicDepartments.ToListAsync();
        }

        // GET: api/CurriculumTopicDepartments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CurriculumTopicDepartment>> GetCurriculumTopicDepartment(int id)
        {
            var curriculumTopicDepartment = await _context.CurriculumTopicDepartments.FindAsync(id);

            if (curriculumTopicDepartment == null)
            {
                return NotFound();
            }

            return curriculumTopicDepartment;
        }

        // PUT: api/CurriculumTopicDepartments/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurriculumTopicDepartment(int id, CurriculumTopicDepartment curriculumTopicDepartment)
        {
            if (id != curriculumTopicDepartment.Id)
            {
                return BadRequest();
            }

            _context.Entry(curriculumTopicDepartment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurriculumTopicDepartmentExists(id))
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

        // POST: api/CurriculumTopicDepartments
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CurriculumTopicDepartment>> PostCurriculumTopicDepartment(CurriculumTopicDepartment curriculumTopicDepartment)
        {
            _context.CurriculumTopicDepartments.Add(curriculumTopicDepartment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCurriculumTopicDepartment", new { id = curriculumTopicDepartment.Id }, curriculumTopicDepartment);
        }

        // DELETE: api/CurriculumTopicDepartments/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicDepartment>> DeleteCurriculumTopicDepartment(int id)
        {
            var curriculumTopicDepartment = await _context.CurriculumTopicDepartments.FindAsync(id);
            if (curriculumTopicDepartment == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicDepartments.Remove(curriculumTopicDepartment);
            await _context.SaveChangesAsync();

            return curriculumTopicDepartment;
        }

        private bool CurriculumTopicDepartmentExists(int id)
        {
            return _context.CurriculumTopicDepartments.Any(e => e.Id == id);
        }
    }
}
