using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class TrainingProgram
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfHours { get; set; }
        public bool IsDistanceLearning { get; set; }
        public bool IsControlWork { get; set; }
        public bool IsTestWork { get; set; }
        public string ControlWork { get; set; }
        public int DepartmentId { get; set; }
        public int StudentCategoryId { get; set; }
        public int CertificationTypeId { get; set; }
        public int FormOfEducationId { get; set; }

        public List<Group> Groups { get; set; }
        public List<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
        public List<TrainingProgramCurriculumSection> TrainingProgramCurriculumSections { get; set; }
        public List<TrainingProgramTestWork> TrainingProgramTestWorks { get; set; }
        public List<TrainingProgramFinalExamination> TrainingProgramFinalExaminations { get; set; }
        public List<TrainingProgramMainLiterature> TrainingProgramMainLiteratures { get; set; }
        public List<TrainingProgramAdditionalLiterature> TrainingProgramAdditionalLiteratures { get; set; }
        public List<TrainingProgramRegulation> TrainingProgramRegulations { get; set; }
        public List<TrainingProgramTeacher> TrainingProgramTeachers { get; set; }
    }
}
