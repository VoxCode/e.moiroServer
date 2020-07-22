﻿using System;
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
    public class TeacherCategoriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public TeacherCategoriesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherCategory>>> Get()
        {
            return await _context.TeacherCategories.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherCategory>> Get(int id)
        {
            var value = await _context.TeacherCategories.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(TeacherCategory value)
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
        public async Task<ActionResult<TeacherCategory>> Post(TeacherCategory value)
        {
            if (ModelState.IsValid)
            {
                _context.TeacherCategories.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<TeacherCategory>> Delete(int id)
        {
            var value = await _context.TeacherCategories.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.TeacherCategories.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
