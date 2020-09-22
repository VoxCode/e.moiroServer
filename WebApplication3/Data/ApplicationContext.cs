using e.moiroServer.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e.moiroServer.Models
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
    : base(options)
        {
            // Database.EnsureCreated();
        }

        public DbSet<AdditionalLiterature> AdditionalLiteratures { get; set; }
        public DbSet<CurriculumSection> CurriculumSections { get; set; }
        public DbSet<CurriculumTopic> CurriculumTopics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FinalExamination> FinalExaminations { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MainLiterature> MainLiteratures { get; set; }
        public DbSet<OccupationForm> OccupationForms { get; set; }
        public DbSet<Regulation> Regulations { get; set; }
        public DbSet<SectionNumber> SectionNumbers { get; set; }
        public DbSet<StudentCategory> StudentCategories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeachingPosition> TeachingPositions { get; set; }
        public DbSet<TestWork> TestWorks { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }

        public DbSet<CurriculumTopicAdditionalLiterature> CurriculumTopicAdditionalLiteratures { get; set; }
        public DbSet<CurriculumTopicDepartment> CurriculumTopicDepartments { get; set; }
        public DbSet<CurriculumTopicMainLiterature> CurriculumTopicMainLiteratures { get; set; }
        public DbSet<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }
        public DbSet<CurriculumTopicFinalExamination> CurriculumTopicFinalExaminations { get; set; }
        public DbSet<CurriculumTopicRegulation> CurriculumTopicRegulations { get; set; }
        public DbSet<CurriculumTopicStudentCategory> CurriculumTopicStudentCategories { get; set; }
        public DbSet<CurriculumTopicTestWork> CurriculumTopicTestWorks { get; set; }

        public DbSet<TrainingProgramAdditionalLiterature> TrainingProgramAdditionalLiteratures { get; set; }
        public DbSet<TrainingProgramCurriculumSection> TrainingProgramCurriculumSections { get; set; }
        public DbSet<TrainingProgramFinalExamination> TrainingProgramFinalExaminations { get; set; }
        public DbSet<TrainingProgramMainLiterature> TrainingProgramMainLiteratures { get; set; }
        public DbSet<TrainingProgramRegulation> TrainingProgramRegulations { get; set; }
        public DbSet<TrainingProgramTeacher> TrainingProgramTeachers { get; set; }
        public DbSet<TrainingProgramTestWork> TrainingProgramTestWorks { get; set; }

    }
}