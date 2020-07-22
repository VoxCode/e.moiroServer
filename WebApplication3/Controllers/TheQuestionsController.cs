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
    public class TheQuestionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TheQuestionsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TheQuestion>>> Get()
        {
            return await _context.TheQuestions.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TheQuestion>> Get(int id)
        {
            var value = await _context.TheQuestions.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TheQuestion value)
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
        public async Task<ActionResult<TheQuestion>> Post(TheQuestion value)
        {
            if (ModelState.IsValid)
            {
                _context.TheQuestions.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TheQuestion>> Delete(int id)
        {
            var value = await _context.TheQuestions.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TheQuestions.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
