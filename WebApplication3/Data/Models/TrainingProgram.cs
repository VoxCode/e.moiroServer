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
        public int DepartmentId { get; set; }
        public int StudentCategoryId { get; set; }
        public int CertificationTypeId { get; set; }
        public int FormOfEducationId { get; set; }
        public int NumberOfWeeks { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<TrainingProgramCurriculumSection> TrainingProgramCurriculumSections { get; set; }
        public ICollection<TrainingProgramTestWork> TrainingProgramTestWorks { get; set; }
        public ICollection<TrainingProgramIndependentWorkQuestion> TrainingProgramIndependentWorkQuestions { get; set; }
        public ICollection<TrainingProgramIntroduction> TrainingProgramIntroductions { get; set; }
        public ICollection<TrainingProgramFinalExamination> TrainingProgramFinalExaminations { get; set; }
        public ICollection<TrainingProgramMainLiterature> TrainingProgramMainLiteratures { get; set; }
        public ICollection<TrainingProgramAdditionalLiterature> TrainingProgramAdditionalLiteratures { get; set; }
        public ICollection<TrainingProgramRegulation> TrainingProgramRegulations { get; set; }
        public ICollection<TrainingProgramTeacher> TrainingProgramTeachers { get; set; }
        public ICollection<CurriculumTopic> CurriculumTopics { get; set; }
    }
}
