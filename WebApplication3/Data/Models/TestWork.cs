using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class TestWork
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<CurriculumTopicTestWork> CurriculumTopicTestWorks { get; set; }
        public List<TrainingProgramTestWork> TrainingProgramTestWorks { get; set; }
    }
}
