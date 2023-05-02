using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopicType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CurriculumTopic> CurriculumTopics { get; set; }
        public ICollection<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
    }
}

