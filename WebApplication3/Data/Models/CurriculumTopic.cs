using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopic
    {
        public int Id { get; set; }
        public string TopicTitle { get; set; }
        public string Annotation { get; set; }
        public string AuthorIndex { get; set; }

        public List<CurriculumTopicAdditionalLiterature> CurriculumTopicAdditionalLiteratures { get; set; }
        public List<CurriculumTopicRegulation> CurriculumTopicRegulations { get; set; }
        public List<CurriculumTopicMainLiterature> CurriculumTopicMainLiteratures { get; set; }
        public List<CurriculumTopicDepartment> CurriculumTopicDepartments { get; set; }
        public List<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
        public List<CurriculumTopicTestWork> CurriculumTopicTestWorks { get; set; }
        public List<CurriculumTopicStudentCategory> CurriculumTopicStudentCategories { get; set; }
        public List<CurriculumTopicFinalExamination> CurriculumTopicFinalExaminations { get; set; }
    }
}
