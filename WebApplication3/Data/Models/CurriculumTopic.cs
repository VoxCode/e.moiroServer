using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopic
    {
        public int Id { get; set; }
        public string TopicTitle { get; set; }
        public int ClassHours { get; set; }
        public string Annotation { get; set; }
        public bool IsDistanceLearning { get; set; }
        public int CurriculumSectionId { get; set; }
        public CurriculumSection CurriculumSection { get; set; }
        public int OccupationFormId { get; set; }
        public OccupationForm OccupationForm { get; set; }

        public List<CurriculumTopicAdditionalLiterature> CurriculumTopicAdditionalLiteratures { get; set; }
        public List<CurriculumTopicDepartment> CurriculumTopicDepartments { get; set; }
        public List<CurriculumTopicTeacher> CurriculumTopicTeachers { get; set; }
        public List<CurriculumTopicMainLiterature> CurriculumTopicMainLiteratures { get; set; }
        public List<CurriculumTopicTeacherCategory> CurriculumTopicTeacherCategories { get; set; }
        public List<CurriculumTopicTheQuestion> CurriculumTopicTheQuestions { get; set; }
        public List<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
        public CurriculumTopic()
        {
            CurriculumTopicAdditionalLiteratures = new List<CurriculumTopicAdditionalLiterature>();
            CurriculumTopicDepartments = new List<CurriculumTopicDepartment>();
            CurriculumTopicMainLiteratures = new List<CurriculumTopicMainLiterature>();
            CurriculumTopicTeachers = new List<CurriculumTopicTeacher>();
            CurriculumTopicTeacherCategories = new List<CurriculumTopicTeacherCategory>();
            CurriculumTopicTheQuestions = new List<CurriculumTopicTheQuestion>();
            CurriculumTopicTrainingPrograms = new List<CurriculumTopicTrainingProgram>();
        }     
    }
}
