using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class StudentCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
        public List<CurriculumTopicTeacherCategory> CurriculumTopicTeacherCategories { get; set; }
        public StudentCategory()
        {
            CurriculumTopicTeacherCategories = new List<CurriculumTopicTeacherCategory>();
        }
    }
}
