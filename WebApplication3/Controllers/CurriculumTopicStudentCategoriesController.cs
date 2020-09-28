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
    public class CurriculumTopicStudentCategoriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicStudentCategoriesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopicStudentCategory>>> Get()
        {
            return await _context.CurriculumTopicStudentCategories.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopicStudentCategory>>> Get(int id)
        {
            return await _context.CurriculumTopicStudentCategories.Where(a => a.CurriculumTopicId == id).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopicStudentCategory value)
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
        public async Task<ActionResult<CurriculumTopicStudentCategory>> Post(CurriculumTopicStudentCategory value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopicStudentCategories.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopicStudentCategory>> Delete(int id)
        {
            var value = await _context.CurriculumTopicStudentCategories.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopicStudentCategories.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
