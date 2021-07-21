﻿using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleBlocksController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ScheduleBlocksController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ScheduleBlock>>> Get()
        {
            return await _context.ScheduleBlocks.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ScheduleBlock>> Get(int id)
        {
            var value = await _context.ScheduleBlocks.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(ScheduleBlock value)
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
        public async Task<ActionResult<ScheduleBlock>> Post(ScheduleBlock value)
        {
            if (ModelState.IsValid)
            {
                _context.ScheduleBlocks.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ScheduleBlock>> Delete(int id)
        {
            var value = await _context.ScheduleBlocks.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.ScheduleBlocks.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
