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
    public class TrainingProgramTestWorksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TrainingProgramTestWorksController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingProgramTestWork>>> Get()
        {
            return await _context.TrainingProgramTestWorks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingProgramTestWork>> Get(int id)
        {
            var value = await _context.TrainingProgramTestWorks.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TrainingProgramTestWork value)
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
        public async Task<ActionResult<TrainingProgramTestWork>> Post(TrainingProgramTestWork value)
        {
            if (ModelState.IsValid)
            {
                _context.TrainingProgramTestWorks.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TrainingProgramTestWork>> Delete(int id)
        {
            var value = await _context.TrainingProgramTestWorks.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TrainingProgramTestWorks.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
