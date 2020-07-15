using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class TeacherCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
        public List<СurriculumTopicTeacherCategory> СurriculumTopicTeacherCategories { get; set; }
        public TeacherCategory()
        {
            СurriculumTopicTeacherCategories = new List<СurriculumTopicTeacherCategory>();
        }
    }
}
