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
    public class TeachersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TeachersController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> Get()
        {
            return await _context.Teachers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> Get(int id)
        {
            var value = await _context.Teachers.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(Teacher value)
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
        public async Task<ActionResult<Teacher>> Post(Teacher value)
        {
            if (ModelState.IsValid)
            {
                _context.Teachers.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Teacher>> Delete(int id)
        {
            var value = await _context.Teachers.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Teachers.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }

        [HttpPost("{teacherId}")]
        public async Task<ActionResult<Teacher>> DeleteTeacherDepartment(int teacherId, [FromBody] List<Department> departments)
        {
            var teahcer = await _context.Teachers.Include(a => a.Departments).FirstOrDefaultAsync(b => b.Id == teacherId);
            if (teahcer == null) return NotFound();
            var departmnetsOld = new List<Department>();
            departmnetsOld.AddRange(teahcer.Departments);
            var result = departments.Join(teahcer.Departments, ok => ok.Id, ik => ik.Id, (one, two) => new { one, two }).ToList();
            if (departments.Count == 0)
            {
                teahcer.Departments = new List<Department>();
            }
            else
            {
                departmnetsOld.RemoveAll(x => result.Any(r => x == r.two));
                foreach (var department in departmnetsOld)
                {
                    teahcer.Departments.Remove(department);
                }
                departments.RemoveAll(x => result.Any(r => x == r.one));
                teahcer.Departments.AddRange(departments);
            }
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("GetTeacherDepartment/{teacherId}")]
        public async Task<ActionResult<IEnumerable<Department>>> GetTeacherDepartment(int teacherId)
        {
            return await _context.Departments.Where(a => a.Teachers.Any(b => b.Id == teacherId)).ToListAsync();
        }
    }
}
