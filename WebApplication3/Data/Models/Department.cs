using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CurriculumTopicDepartment> CurriculumTopicDepartments { get; set; }
        public List<TrainingProgram> TrainingPrograms { get; set; }
    }
}
