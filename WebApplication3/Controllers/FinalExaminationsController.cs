using e.moiroServer.Data.Models;
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
    public class FinalExaminationsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public FinalExaminationsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<object>>> Get()
        {
            var tmp = from first in _context.FinalExaminations
                      join second in _context.CertificationTypes on first.CertificationTypeId equals second.Id
                      select new
                      {
                          first.Id,
                          first.Content,
                          first.CertificationTypeId,
                          CertificationTypeName = second.Name
                      };

            return await tmp.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<FinalExamination>>> Get(int id)
        {
            return await _context.FinalExaminations.Where(a => a.CertificationTypeId == id).ToListAsync();
        }

        [HttpGet("Author{author}")]
        public async Task<ActionResult<IEnumerable<object>>> Get(string author)
        {
            var tmp = from first in _context.FinalExaminations.Where(a => a.AuthorIndex == author)
                      join second in _context.CertificationTypes on first.CertificationTypeId equals second.Id
                      select new
                      {
                          first.Id,
                          first.Content,
                          first.CertificationTypeId,
                          first.AuthorIndex,
                          CertificationTypeName = second.Name
                      };

            return await tmp.ToListAsync();
        }

        [HttpGet("GetByDepartment/{certificationTypeId}/{departmentId}")]
        public async Task<ActionResult<IEnumerable<FinalExamination>>> Get(int certificationTypeId, int departmentId)
        {
            var result = await _context.FinalExaminations.Where(a => a.CertificationTypeId == certificationTypeId && a.Departments.Any(s => s.Id == departmentId)).ToListAsync();
            if (result.Count == 0)
            {
                var onlyDeps = await _context.FinalExaminations.Where(a => a.Departments.Any(s => s.Id == departmentId)).ToListAsync();
                return onlyDeps;
            }
            return result;
        }

        //[HttpGet("FinalExaminationByDepartment/{department}")]
        //public async Task<ActionResult<IEnumerable<object>>> GetByDepartment(int department)
        //{
        //    var tmp = from dep in _context.DepartmentFinalExaminations.Where(x => x.DepartmentId == department)
        //              join finalEx in _context.FinalExaminations on dep.FinalExaminationId equals finalEx.Id
        //              join cert in _context.CertificationTypes on finalEx.CertificationTypeId equals cert.Id
        //              select new
        //              {
        //                  finalEx.Id,
        //                  finalEx.Content,
        //                  finalEx.CertificationTypeId,
        //                  finalEx.AuthorIndex,
        //                  CertificationTypeName = cert.Name
        //              };

        //    return await tmp.ToListAsync();
        //}

        [HttpPut]
        public async Task<IActionResult> Put(FinalExamination value)
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
        public async Task<ActionResult<FinalExamination>> Post(FinalExamination value)
        {
            if (ModelState.IsValid)
            {
                _context.FinalExaminations.Add(value);
                await _context.SaveChangesAsync();
                return Ok(value);
            }
            return BadRequest(ModelState);
        }

        [HttpPut("ConnectToDepartments/{finalExaminationId}")]
        public async Task<ActionResult<FinalExamination>> Post(int finalExaminationId, [FromBody] List<Department> departments)
        {
            if (departments?.Count == 0)
                return BadRequest();

            var finalExamination = await _context.FinalExaminations.Include(a => a.Departments).FirstOrDefaultAsync(fe => fe.Id == finalExaminationId);

            if (finalExamination == null)
                return NotFound();

            finalExamination.Departments.AddRange(departments);
            var a = finalExamination.Departments.GroupBy(x => x.Id).Select(y => y.First());//(List<Department>)finalExamination.Departments.Distinct();
            finalExamination.Departments = new List<Department>(a);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FinalExamination>> Delete(int id)
        {
            var value = await _context.FinalExaminations.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.FinalExaminations.Remove(value);
            await _context.SaveChangesAsync();

            return value;
        }
    }
}
