using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicTeacherCategory
    {
        public int Id { get; set; }
        public int TeacherCategoryId { get; set; }
        public int CuriculumTopicId { get; set; }

        public TeacherCategory TeacherCategory { get; set; }
        public CuriculumTopic CuriculumTopic { get; set; }
    }
}
