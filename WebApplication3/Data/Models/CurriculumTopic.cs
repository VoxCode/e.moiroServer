using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopic
    {
        public int Id { get; set; }
        public string TopicTitle { get; set; }
        public int ClassHours { get; set; }
        public string Annotation { get; set; }
        public bool DistanceLearning { get; set; }
        public int CurriculumSectionId { get; set; }
        public CurriculumSection CurriculumSection { get; set; }
        public int OccupationFormId { get; set; }
        public OccupationForm OccupationForm { get; set; }

        public List<СurriculumTopicAdditionalLiterature> СurriculumTopicAdditionalLiteratures { get; set; }
        public List<СurriculumTopicConsultationTopics> СurriculumTopicConsultationTopics { get; set; }
        public List<СurriculumTopicDepartmens> СurriculumTopicDepartmens { get; set; }
        public List<СurriculumTopicTeacher> СurriculumTopicTeachers { get; set; }
        public List<СurriculumTopicMainLiterature> СurriculumTopicMainLiteratures { get; set; }
        public List<СurriculumTopicTeacherCategory> СurriculumTopicTeacherCategories { get; set; }
        public List<СurriculumTopicTheQuestions> СurriculumTopicTheQuestions { get; set; }
        public List<СurriculumTopicTranningProgram> СurriculumTopicTranningPrograms { get; set; }
        public CurriculumTopic()
        {
            СurriculumTopicAdditionalLiteratures = new List<СurriculumTopicAdditionalLiterature>();
            СurriculumTopicConsultationTopics = new List<СurriculumTopicConsultationTopics>();
            СurriculumTopicDepartmens = new List<СurriculumTopicDepartmens>();
            СurriculumTopicMainLiteratures = new List<СurriculumTopicMainLiterature>();
            СurriculumTopicTeachers = new List<СurriculumTopicTeacher>();
            СurriculumTopicTeacherCategories = new List<СurriculumTopicTeacherCategory>();
            СurriculumTopicTheQuestions = new List<СurriculumTopicTheQuestions>();
            СurriculumTopicTranningPrograms = new List<СurriculumTopicTranningProgram>();
        }     
    }
}
