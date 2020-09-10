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
        public async Task<ActionResult<IEnumerable<CurriculumTopicTeacherCategory>>> Get()
        {
            return await _context.CurriculumTopicTeacherCategory.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<CurriculumTopicTeacherCategory> Get(int id)
        {
            return _context.CurriculumTopicTeacherCategory.Where(a => a.CurriculumTopicId == id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicTeacherCategory value)
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
        public async Task<ActionResult<CurriculumTopicTeacherCategory>> Post(CurriculumTopicTeacherCategory value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicTeacherCategory.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicTeacherCategory>> Delete(int id)
        {
            var value = await _context.CurriculumTopicTeacherCategory.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicTeacherCategory.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}