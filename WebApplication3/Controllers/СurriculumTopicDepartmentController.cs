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
    public class СurriculumTopicDepartmentController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public СurriculumTopicDepartmentController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<СurriculumTopicDepartment>>> Get()
        {
            return await _context.СurriculumTopicDepartment.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<СurriculumTopicDepartment> Get(int id)
        {
            return _context.СurriculumTopicDepartment.Where(a => a.CurriculumTopicId == id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(СurriculumTopicDepartment value)
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
        public async Task<ActionResult<СurriculumTopicDepartment>> Post(СurriculumTopicDepartment value)
        {
            if (ModelState.IsValid)
            {
                _context.СurriculumTopicDepartment.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<СurriculumTopicDepartment>> Delete(int id)
        {
            var value = await _context.СurriculumTopicDepartment.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.СurriculumTopicDepartment.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}