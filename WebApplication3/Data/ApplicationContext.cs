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
        public DbSet<ConsultationTopics> ConsultationTopics { get; set; }
        public DbSet<CuriculumTopic> CuriculumTopics { get; set; }
        public DbSet<CurriculumSection> CurriculumSections { get; set; }
        public DbSet<Departmens> Departmens { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MainLiterature> MainLiteratures { get; set; }
        public DbSet<OccupationForm> OccupationForms { get; set; }
        public DbSet<SectionNumber> SectionNumbers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCategory> TeacherCategories { get; set; }
        public DbSet<TeachingPosition> TeachingPositions { get; set; }
        public DbSet<TheQuestions> TheQuestions { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<СurriculumTopicAdditionalLiterature> СurriculumTopicAdditionalLiteratures { get; set; }
        public DbSet<СurriculumTopicConsultationTopics> СurriculumTopicConsultationTopics { get; set; }
        public DbSet<СurriculumTopicDepartmens> СurriculumTopicDepartmens { get; set; }
        public DbSet<СurriculumTopicMainLiterature> СurriculumTopicMainLiteratures { get; set; }
        public DbSet<СurriculumTopicTeacher> СurriculumTopicTeachers { get; set; }
        public DbSet<СurriculumTopicTeacherCategory> СurriculumTopicTeacherCategories { get; set; }
        public DbSet<СurriculumTopicTheQuestions> СurriculumTopicTheQuestions { get; set; }
        public DbSet<СurriculumTopicTranningProgram> СurriculumTopicTranningPrograms { get; set; }
    }
}