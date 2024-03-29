﻿using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionalLiteraturesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public AdditionalLiteraturesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AdditionalLiterature>>> Get()
        {
            return await _context.AdditionalLiteratures.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AdditionalLiterature>> Get(int id)
        {
            var value = await _context.AdditionalLiteratures.FindAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            return value;
        }

        [HttpGet("Author{author}")]
        public async Task<ActionResult<IEnumerable<AdditionalLiterature>>> Get(string author)
        {
            return await _context.AdditionalLiteratures.Where(a => a.AuthorIndex == author).ToListAsync();
        }

        [HttpPut]
        public async Task<IActionResult> Put(AdditionalLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.Update(value);
                await _context.SaveChangesAsync();
                return Ok(value);

            }
            return BadRequest(ModelState);
        }

        [HttpPost("GetAdditionalLiterature")]
        public async Task<ActionResult<IEnumerable<AdditionalLiterature>>> GetAdditionalLiterature([FromBody] int[] curriculumTopicIdArray)
        {
            IEnumerable<AdditionalLiterature> result = new List<AdditionalLiterature>();
            foreach (var curriculumTopicId in curriculumTopicIdArray.AsParallel())
            {
                var res = await _context.AdditionalLiteratures.Where(a => a.CurriculumTopics
                .Any(r => r.Id == curriculumTopicId)).ToListAsync();
                result = result.Union(res);
            }
            return result.ToList();
        }

        [HttpPost]
        public async Task<ActionResult<AdditionalLiterature>> Post(AdditionalLiterature value)
        {
            if (ModelState.IsValid)
            {
                _context.AdditionalLiteratures.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AdditionalLiterature>> Delete(int id)
        {
            var value = await _context.AdditionalLiteratures.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.AdditionalLiteratures.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
