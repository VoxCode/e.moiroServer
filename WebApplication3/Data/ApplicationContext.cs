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
            //Database.EnsureCreated();
        }

        public DbSet<AdditionalLiterature> AdditionalLiteratures { get; set; }
        public DbSet<CurriculumTopic> CurriculumTopics { get; set; }
        public DbSet<CurriculumSection> CurriculumSections { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MainLiterature> MainLiteratures { get; set; }
        public DbSet<OccupationForm> OccupationForms { get; set; }
        public DbSet<SectionNumber> SectionNumbers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentCategory> StudentCategories { get; set; }
        public DbSet<TeachingPosition> TeachingPositions { get; set; }
        public DbSet<TheQuestion> TheQuestions { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<CurriculumTopicAdditionalLiterature> CurriculumTopicAdditionalLiterature { get; set; }
        public DbSet<CurriculumTopicDepartment> CurriculumTopicDepartment { get; set; }
        public DbSet<CurriculumTopicMainLiterature> CurriculumTopicMainLiterature { get; set; }
        public DbSet<CurriculumTopicTeacher> CurriculumTopicTeacher { get; set; }
        public DbSet<CurriculumTopicTeacherCategory> CurriculumTopicTeacherCategory { get; set; }
        public DbSet<CurriculumTopicTheQuestion> CurriculumTopicTheQuestion { get; set; }
        public DbSet<CurriculumTopicTrainingProgram> CurriculumTopicTrainingProgram { get; set; }
     
    }
}