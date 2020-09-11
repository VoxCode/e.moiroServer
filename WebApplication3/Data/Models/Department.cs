using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CurriculumTopicDepartment> CurriculumTopicDepartments { get; set; }
        public Department()
        {
            CurriculumTopicDepartments = new List<CurriculumTopicDepartment>();
        }
    }
}
