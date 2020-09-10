using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicTeacherCategory
    {
        public int Id { get; set; }
        public int TeacherCategoryId { get; set; }
        public StudentCategory TeacherCategory { get; set; }
        public int CurriculumTopicId { get; set; }
        public CurriculumTopic CurriculumTopic { get; set; }
    }
}
