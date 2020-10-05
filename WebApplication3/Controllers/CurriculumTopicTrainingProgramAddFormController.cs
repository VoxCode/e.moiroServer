using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using e.moiroServer.Data.Models;
using e.moiroServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace e.moiroServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumTopicTrainingProgramAddFormController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CurriculumTopicTrainingProgramAddFormController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("{studentCategoryId}/{departmentId}")]
        public ActionResult<IEnumerable<object>> Get(int studentCategoryId, int departmentId)
        {
            List<CurriculumTopic> curriculumTopics = new List<CurriculumTopic>();

            var eee = _context.CurriculumTopics.Where(a => a.CurriculumTopicStudentCategories
                .Where(b => b.StudentCategoryId == studentCategoryId) == a.CurriculumTopicDepartments
                .Where(c => c.DepartmentId == departmentId));

            return eee.ToList();


            //var curriculumTopicStudentCategories = _context.CurriculumTopicStudentCategories
            //    .Where(a => a.StudentCategoryId == studentCategoryId).Select(a => a.CurriculumTopicId);

            //var curriculumTopicDepartments = _context.CurriculumTopicDepartments
            //    .Where(a => a.DepartmentId == departmentId).Select(a => a.CurriculumTopicId);

            //var result = curriculumTopicStudentCategories.Except(curriculumTopicDepartments, new DBComparer()).ToList();

            //foreach(var i in result)
            //{
            //    var tmp = _context.CurriculumTopics.FirstOrDefault(a => a.Id == i);
            //    curriculumTopics.Add(tmp);
            //}

            //return curriculumTopics;
        }
    }

    public class DBComparer : IEqualityComparer<int>
    {
        public bool Equals(int x, int y)
        {
            if (ReferenceEquals(x, y)) return true;
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] int obj)
        {
            throw new NotImplementedException();
        }
    }
}
