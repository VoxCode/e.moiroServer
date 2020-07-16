using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCathedral { get; set; }
        public int TeachingPositionId { get; set; }
        public TeachingPosition TeachingPosition { get; set; }
        public List<СurriculumTopicTeacher> СurriculumTopicTeachers { get; set; }
        public Teacher()
        {
            СurriculumTopicTeachers = new List<СurriculumTopicTeacher>();
        }
    }
}
