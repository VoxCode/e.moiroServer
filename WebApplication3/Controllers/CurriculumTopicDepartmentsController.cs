using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicDepartment>>> Get()
        {
            return await _context.CurriculumTopicDepartments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopicDepartment>>> Get(int id)
        {
            return await _context.CurriculumTopicDepartments.Where(a => a.CurriculumTopicId == id).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicDepartment value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public async Task<ActionResult<CurriculumTopicDepartment>> Post(CurriculumTopicDepartment value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicDepartments.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicDepartment>> Delete(int id)
        {
            var value = await _context.CurriculumTopicDepartments.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicDepartments.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
