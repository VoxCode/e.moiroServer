﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Cors;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public MainLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MainLiterature>>> Get()
        {
            return await _context.MainLiteratures.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MainLiterature>> Get(int id)
        {
            var value = await _context.MainLiteratures.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpPut]
        public async Task<IActionResult> Put(MainLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<IEnumerable<MainLiterature>>> GetMainLiterature(int id, [FromBody] int[] curriculumTopicIdArray)
        {
            IEnumerable<MainLiterature> result = new List<MainLiterature>();
            foreach (var i in curriculumTopicIdArray.AsParallel())
            {
                var res = await _context.MainLiteratures.Where(a => a.CurriculumTopicMainLiteratures
                .Any(r => r.CurriculumTopicId == i)).ToListAsync();
                result = result.Union(res);

            }

            return result.ToList();
        }

        [HttpPost]
        public async Task<ActionResult<MainLiterature>> Post(MainLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.MainLiteratures.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MainLiterature>> Delete(int id)
        {
            var value = await _context.MainLiteratures.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.MainLiteratures.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
