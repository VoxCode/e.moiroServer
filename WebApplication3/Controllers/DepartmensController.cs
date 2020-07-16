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
    public class DepartmensController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public DepartmensController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Departmens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> GetDepartmens()
        {
            return await _context.Departments.ToListAsync();
        }

        // GET: api/Departmens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartmens(int id)
        {
            var departmens = await _context.Departments.FindAsync(id);

            if (departmens == null)
            {
                return NotFound();
            }

            return departmens;
        }

        // PUT: api/Departmens/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartmens(int id, Department departmens)
        {
            if (id != departmens.Id)
            {
                return BadRequest();
            }

            _context.Entry(departmens).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmensExists(id))
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

        // POST: api/Departmens
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Department>> PostDepartmens(Department departmens)
        {
            _context.Departments.Add(departmens);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartmens", new { id = departmens.Id }, departmens);
        }

        // DELETE: api/Departmens/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> DeleteDepartmens(int id)
        {
            var departmens = await _context.Departments.FindAsync(id);
            if (departmens == null)
            {
                return NotFound();
            }

            _context.Departments.Remove(departmens);
            await _context.SaveChangesAsync();

            return departmens;
        }

        private bool DepartmensExists(int id)
        {
            return _context.Departments.Any(e => e.Id == id);
        }
    }
}
