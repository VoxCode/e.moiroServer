using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicTeacher
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int CuriculumTopicId { get; set; }

        public Teacher Teacher { get; set; }
        public CuriculumTopic CuriculumTopic { get; set; }
    }
}
