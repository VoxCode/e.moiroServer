using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class StudentCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GenitiveName { get; set; }
        public ICollection<CurriculumTopic> CurriculumTopics { get; set; }
        public ICollection<TrainingProgram> TrainingPrograms { get; set; }
    }
}
