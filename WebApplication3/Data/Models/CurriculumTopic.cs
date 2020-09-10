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

        public List<CurriculumTopicAdditionalLiterature> СurriculumTopicAdditionalLiteratures { get; set; }
        public List<CurriculumTopicDepartment> СurriculumTopicDepartments { get; set; }
        public List<CurriculumTopicTeacher> СurriculumTopicTeachers { get; set; }
        public List<CurriculumTopicMainLiterature> СurriculumTopicMainLiteratures { get; set; }
        public List<CurriculumTopicTeacherCategory> СurriculumTopicTeacherCategories { get; set; }
        public List<CurriculumTopicTheQuestion> СurriculumTopicTheQuestions { get; set; }
        public List<CurriculumTopicTrainingProgram> СurriculumTopicTrainingPrograms { get; set; }
        public CurriculumTopic()
        {
            СurriculumTopicAdditionalLiteratures = new List<CurriculumTopicAdditionalLiterature>();
            СurriculumTopicDepartments = new List<CurriculumTopicDepartment>();
            СurriculumTopicMainLiteratures = new List<CurriculumTopicMainLiterature>();
            СurriculumTopicTeachers = new List<CurriculumTopicTeacher>();
            СurriculumTopicTeacherCategories = new List<CurriculumTopicTeacherCategory>();
            СurriculumTopicTheQuestions = new List<CurriculumTopicTheQuestion>();
            СurriculumTopicTrainingPrograms = new List<CurriculumTopicTrainingProgram>();
        }     
    }
}
