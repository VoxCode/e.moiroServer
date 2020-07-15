using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class СurriculumTopicDepartmens
    {
        public int CurriculumTopicId { get; set; }
        public int DepartmensId { get; set; }

        public CurriculumTopic CurriculumTopic { get; set; }
        public Departmens Departmens { get; set; }
    }
}
