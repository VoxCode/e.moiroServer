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
    public class TrainingProgramTeachersController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramTeachersController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramTeacher>>> Get()
        {
            return await _context.TrainingProgramTeachers.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramTeacher>> Get(int id)
        {
            var value = await _context.TrainingProgramTeachers.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramTeacher value)
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
        public async Task<ActionResult<TrainingProgramTeacher>> Post(TrainingProgramTeacher value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramTeachers.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramTeacher>> Delete(int id)
        {
            var value = await _context.TrainingProgramTeachers.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingProgramTeachers.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
