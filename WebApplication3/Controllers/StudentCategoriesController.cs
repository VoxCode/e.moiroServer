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
    public class StudentCategoriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public StudentCategoriesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StudentCategory>>> Get()
        {
            return await _context.StudentCategories.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<StudentCategory>> Get(int id)
        {
            var value = await _context.StudentCategories.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(StudentCategory value)
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
        public async Task<ActionResult<StudentCategory>> Post(StudentCategory value)
        {
            if (ModelState.IsValid)
            {
                _context.StudentCategories.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<StudentCategory>> Delete(int id)
        {
            var value = await _context.StudentCategories.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.StudentCategories.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
