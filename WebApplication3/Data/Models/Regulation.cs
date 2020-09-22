using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class Regulation
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<CurriculumTopicRegulation> CurriculumTopicRegulations { get; set; }
        public List<TrainingProgramRegulation> TrainingProgramRegulations { get; set; }
    }
}
