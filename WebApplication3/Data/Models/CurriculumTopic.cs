using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopic
    {
        public int Id { get; set; }
        public string TopicTitle { get; set; }
        public int ClassHours { get; set; }
        public string Annotation { get; set; }
        public string TestWork { get; set; }

        public List<CurriculumTopicAdditionalLiterature> CurriculumTopicAdditionalLiteratures { get; set; }
        public List<CurriculumTopicDepartment> CurriculumTopicDepartments { get; set; }
        public List<CurriculumTopicMainLiterature> CurriculumTopicMainLiteratures { get; set; }
        public List<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }

        public CurriculumTopic()
        {
            CurriculumTopicAdditionalLiteratures = new List<CurriculumTopicAdditionalLiterature>();
            CurriculumTopicDepartments = new List<CurriculumTopicDepartment>();
            CurriculumTopicMainLiteratures = new List<CurriculumTopicMainLiterature>();
            CurriculumTopicTrainingPrograms = new List<CurriculumTopicTrainingProgram>();
        }     
    }
}
