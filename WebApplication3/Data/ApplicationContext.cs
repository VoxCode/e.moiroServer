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

        public DbSet<Product> Products { get; set; }
        public DbSet<AdditionalLiterature> AdditionalLiteratures { get; set; }
        public DbSet<ConsultationTopic> ConsultationTopics { get; set; }
        public DbSet<CurriculumTopic> CurriculumTopics { get; set; }
        public DbSet<CurriculumSection> CurriculumSections { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MainLiterature> MainLiteratures { get; set; }
        public DbSet<OccupationForm> OccupationForms { get; set; }
        public DbSet<SectionNumber> SectionNumbers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCategory> TeacherCategories { get; set; }
        public DbSet<TeachingPosition> TeachingPositions { get; set; }
        public DbSet<TheQuestion> TheQuestions { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<СurriculumTopicAdditionalLiterature> СurriculumTopicAdditionalLiterature { get; set; }
        public DbSet<СurriculumTopicConsultationTopic> СurriculumTopicConsultationTopic { get; set; }
        public DbSet<СurriculumTopicDepartment> СurriculumTopicDepartment { get; set; }
        public DbSet<СurriculumTopicMainLiterature> СurriculumTopicMainLiterature { get; set; }
        public DbSet<СurriculumTopicTeacher> СurriculumTopicTeacher { get; set; }
        public DbSet<СurriculumTopicTeacherCategory> СurriculumTopicTeacherCategory { get; set; }
        public DbSet<СurriculumTopicTheQuestion> СurriculumTopicTheQuestion { get; set; }
        public DbSet<СurriculumTopicTrainingProgram> СurriculumTopicTrainingProgram { get; set; }
     
    }
}