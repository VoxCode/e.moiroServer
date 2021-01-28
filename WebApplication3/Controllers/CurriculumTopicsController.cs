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
    public class CurriculumTopicsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CurriculumTopic>>> Get()
        {
            return await _context.CurriculumTopics.ToListAsync();
        }

        [HttpGet("{studentCategoryId}/{departmentId}")]
        public async Task<ActionResult<IEnumerable<CurriculumTopic>>> Get(int studentCategoryId, int departmentId)
        {
            List<CurriculumTopic> resultList = new List<CurriculumTopic>();
            var tmpList = await _context.CurriculumTopicStudentCategories.Where(a => a.StudentCategoryId == studentCategoryId).ToListAsync();
            var tmpList2 = await _context.CurriculumTopicDepartments.Where(a => a.DepartmentId == departmentId).ToListAsync();
            foreach (var i in tmpList)
            {
                foreach (CurriculumTopicDepartment j in tmpList2)
                {
                    var tmp = _context.CurriculumTopics.FirstOrDefault(a => a.Id == i.CurriculumTopicId && a.Id == j.CurriculumTopicId);
                    if (tmp != null)
                    {
                        resultList.Add(tmp);
                    }
                }
            }
            return resultList;
        }

        [HttpPut]
        public async Task<IActionResult> Put(CurriculumTopic value)
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
        public async Task<ActionResult<CurriculumTopic>> Post(CurriculumTopic value)
        {
            if (ModelState.IsValid)
            {
                _context.CurriculumTopics.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CurriculumTopic>> Delete(int id)
        {
            var value = await _context.CurriculumTopics.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.CurriculumTopics.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
