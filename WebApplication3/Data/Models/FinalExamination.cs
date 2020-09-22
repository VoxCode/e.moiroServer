using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class FinalExamination
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int CertificationTypeId { get; set; }
        public List<TrainingProgramFinalExamination> TrainingProgramFinalExaminations { get; set; }
        public List<CurriculumTopicFinalExamination> CurriculumTopicFinalExaminations { get; set; }
    }
}
