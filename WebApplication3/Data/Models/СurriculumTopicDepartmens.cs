using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicDepartmens
    {
        public int Id { get; set; }
        public int CuriculumTopicId { get; set; }
        public int DepartmensId { get; set; }

        public CuriculumTopic CuriculumTopic { get; set; }
        public Departmens Departmens { get; set; }
    }
}
