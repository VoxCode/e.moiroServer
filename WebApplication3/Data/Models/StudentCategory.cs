using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class StudentCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CurriculumTopicStudentCategory> CurriculumTopicStudentCategories { get; set; }
        public List<TrainingProgram> TrainingPrograms { get; set; }
    }
}
