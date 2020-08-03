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

        public List<СurriculumTopicAdditionalLiterature> СurriculumTopicAdditionalLiteratures { get; set; }
        public List<СurriculumTopicConsultationTopic> СurriculumTopicConsultationTopics { get; set; }
        public List<СurriculumTopicDepartment> СurriculumTopicDepartments { get; set; }
        public List<СurriculumTopicTeacher> СurriculumTopicTeachers { get; set; }
        public List<СurriculumTopicMainLiterature> СurriculumTopicMainLiteratures { get; set; }
        public List<СurriculumTopicTeacherCategory> СurriculumTopicTeacherCategories { get; set; }
        public List<СurriculumTopicTheQuestion> СurriculumTopicTheQuestions { get; set; }
        public List<СurriculumTopicTrainingProgram> СurriculumTopicTrainingPrograms { get; set; }
        public CurriculumTopic()
        {
            СurriculumTopicAdditionalLiteratures = new List<СurriculumTopicAdditionalLiterature>();
            СurriculumTopicConsultationTopics = new List<СurriculumTopicConsultationTopic>();
            СurriculumTopicDepartments = new List<СurriculumTopicDepartment>();
            СurriculumTopicMainLiteratures = new List<СurriculumTopicMainLiterature>();
            СurriculumTopicTeachers = new List<СurriculumTopicTeacher>();
            СurriculumTopicTeacherCategories = new List<СurriculumTopicTeacherCategory>();
            СurriculumTopicTheQuestions = new List<СurriculumTopicTheQuestion>();
            СurriculumTopicTrainingPrograms = new List<СurriculumTopicTrainingProgram>();
        }     
    }
}
