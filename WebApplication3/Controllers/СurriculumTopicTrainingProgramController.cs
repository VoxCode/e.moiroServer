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
    public class СurriculumTopicTrainingProgramController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public СurriculumTopicTrainingProgramController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<СurriculumTopicTrainingProgram>>> Get()
        {
            return await _context.СurriculumTopicTrainingProgram.ToListAsync();
        }

        [HttpGet("{id}")]
        public IEnumerable<СurriculumTopicTrainingProgram> Get(int id)
        {
            return _context.СurriculumTopicTrainingProgram.Where(a => a.CurriculumTopicId == id);
        }

        [HttpPut]
        public async Task<IActionResult> Put(СurriculumTopicTrainingProgram value)
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
        public async Task<ActionResult<СurriculumTopicTrainingProgram>> Post(СurriculumTopicTrainingProgram value)
        {
            if (ModelState.IsValid)
            {
                _context.СurriculumTopicTrainingProgram.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<СurriculumTopicTrainingProgram>> Delete(int id)
        {
            var value = await _context.СurriculumTopicTrainingProgram.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.СurriculumTopicTrainingProgram.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}