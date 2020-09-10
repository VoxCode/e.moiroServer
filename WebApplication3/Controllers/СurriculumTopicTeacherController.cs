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
        public async Task<ActionResult<IEnumerable<CurriculumTopicTeacher>>> Get()
        {
            return await _context.CurriculumTopicTeacher.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<CurriculumTopicTeacher> Get(int id)
        {
            return _context.CurriculumTopicTeacher.Where(a => a.CurriculumTopicId == id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicTeacher value)
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
        public async Task<ActionResult<CurriculumTopicTeacher>> Post(CurriculumTopicTeacher value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicTeacher.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicTeacher>> Delete(int id)
        {
            var value = await _context.CurriculumTopicTeacher.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicTeacher.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}