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
    public class СurriculumTopicTeacherController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public СurriculumTopicTeacherController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<СurriculumTopicTeacher>>> Get()
        {
            return await _context.СurriculumTopicTeacher.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<СurriculumTopicTeacher> Get(int id)
        {
            return _context.СurriculumTopicTeacher.Where(a => a.CurriculumTopicId == id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(СurriculumTopicTeacher value)
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
        public async Task<ActionResult<СurriculumTopicTeacher>> Post(СurriculumTopicTeacher value)
        {
            if (ModelState.IsValid)
            {
                _context.СurriculumTopicTeacher.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<СurriculumTopicTeacher>> Delete(int id)
        {
            var value = await _context.СurriculumTopicTeacher.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.СurriculumTopicTeacher.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}