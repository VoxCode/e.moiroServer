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
    public class СurriculumTopicTeacherCategoryController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public СurriculumTopicTeacherCategoryController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<СurriculumTopicTeacherCategory>>> Get()
        {
            return await _context.СurriculumTopicTeacherCategory.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<СurriculumTopicTeacherCategory>> Get(int id)
        {
            var value = await _context.СurriculumTopicTeacherCategory.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(СurriculumTopicTeacherCategory value)
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
        public async Task<ActionResult<СurriculumTopicTeacherCategory>> Post(СurriculumTopicTeacherCategory value)
        {
            if (ModelState.IsValid)
            {
                _context.СurriculumTopicTeacherCategory.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<СurriculumTopicTeacherCategory>> Delete(int id)
        {
            var value = await _context.СurriculumTopicTeacherCategory.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.СurriculumTopicTeacherCategory.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}