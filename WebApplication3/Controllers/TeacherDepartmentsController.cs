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
    public class TeacherDepartmentsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TeacherDepartmentsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherDepartment>>> Get()
        {
            return await _context.TeacherDepartments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<TeacherDepartment>>> Get(int teacherId)
        {
            var tmp = await _context.TeacherDepartments.Where(a => a.TeacherId == teacherId).ToListAsync();
            return tmp;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TeacherDepartment value)
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
        public async Task<ActionResult<TeacherDepartment>> Post(TeacherDepartment value)
        {
            if (ModelState.IsValid)
            {
                _context.TeacherDepartments.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TeacherDepartment>> Delete(int id)
        {
            var value = await _context.TeacherDepartments.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TeacherDepartments.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
