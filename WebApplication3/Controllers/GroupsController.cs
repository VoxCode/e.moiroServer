﻿using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public GroupsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var tmp = from gr in _context.Groups
                      join prog in _context.TrainingPrograms on gr.TrainingProgramId equals prog.Id
                      select new
                      {
                          gr.Id,
                          gr.CalendarYear,
                          gr.ClassStartDate,
                          gr.ClassEndDate,
                          gr.GroupNumber,
                          TrainingProgramName = prog.Name
                      };
            return await tmp.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> Get(int id)
        {
            var value = await _context.Groups.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(Group value)
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
        public async Task<ActionResult<Group>> Post(Group value)
        {
            if (ModelState.IsValid)
            {
                _context.Groups.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Group>> Delete(int id)
        {
            var value = await _context.Groups.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Groups.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
