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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //СurriculumTopicAdditionalLiterature
            modelBuilder.Entity<СurriculumTopicAdditionalLiterature>()
                .HasKey(t => new { t.CurriculumTopicId, t.AdditionalLiteratureId });

            modelBuilder.Entity<СurriculumTopicAdditionalLiterature>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicAdditionalLiteratures)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicAdditionalLiterature>()
                .HasOne(sc => sc.AdditionalLiterature)
                .WithMany(c => c.СurriculumTopicAdditionalLiteratures)
                .HasForeignKey(sc => sc.AdditionalLiteratureId);

            //СurriculumTopicConsultationTopic
            modelBuilder.Entity<СurriculumTopicConsultationTopic>()
                .HasKey(t => new { t.CurriculumTopicId, t.ConsultationTopicId });

            modelBuilder.Entity<СurriculumTopicConsultationTopic>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicConsultationTopics)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicConsultationTopic>()
                .HasOne(sc => sc.ConsultationTopics)
                .WithMany(c => c.СurriculumTopicConsultationTopics)
                .HasForeignKey(sc => sc.ConsultationTopicId);

            //СurriculumTopicDepartment
            modelBuilder.Entity<СurriculumTopicDepartment>()
                .HasKey(t => new { t.CurriculumTopicId, t.DepartmentId });

            modelBuilder.Entity<СurriculumTopicDepartment>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicDepartments)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicDepartment>()
                .HasOne(sc => sc.Department)
                .WithMany(c => c.СurriculumTopicDepartments)
                .HasForeignKey(sc => sc.DepartmentId);

            //СurriculumTopicMainLiterature
            modelBuilder.Entity<СurriculumTopicMainLiterature>()
                .HasKey(t => new { t.CurriculumTopicId, t.MainLiteratureId });

            modelBuilder.Entity<СurriculumTopicMainLiterature>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicMainLiteratures)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicMainLiterature>()
                .HasOne(sc => sc.MainLiterature)
                .WithMany(c => c.СurriculumTopicMainLiteratures)
                .HasForeignKey(sc => sc.MainLiteratureId);

            //СurriculumTopicTeacher
            modelBuilder.Entity<СurriculumTopicTeacher>()
                .HasKey(t => new { t.CurriculumTopicId, t.TeacherId });

            modelBuilder.Entity<СurriculumTopicTeacher>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicTeachers)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicTeacher>()
                .HasOne(sc => sc.Teacher)
                .WithMany(c => c.СurriculumTopicTeachers)
                .HasForeignKey(sc => sc.TeacherId);

            //СurriculumTopicTeacherCategory
            modelBuilder.Entity<СurriculumTopicTeacherCategory>()
                .HasKey(t => new { t.CurriculumTopicId, t.TeacherCategoryId });

            modelBuilder.Entity<СurriculumTopicTeacherCategory>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicTeacherCategories)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicTeacherCategory>()
                .HasOne(sc => sc.TeacherCategory)
                .WithMany(c => c.СurriculumTopicTeacherCategories)
                .HasForeignKey(sc => sc.TeacherCategoryId);

            //СurriculumTopicTheQuestions
            modelBuilder.Entity<СurriculumTopicTheQuestion>()
                .HasKey(t => new { t.CurriculumTopicId, t.TheQuestionId });

            modelBuilder.Entity<СurriculumTopicTheQuestion>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicTheQuestions)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicTheQuestion>()
                .HasOne(sc => sc.TheQuestion)
                .WithMany(c => c.СurriculumTopicTheQuestions)
                .HasForeignKey(sc => sc.TheQuestionId);

            //СurriculumTopicTranningProgram
            modelBuilder.Entity<СurriculumTopicTrainingProgram>()
                .HasKey(t => new { t.CurriculumTopicId, t.TrainingProgramId });

            modelBuilder.Entity<СurriculumTopicTrainingProgram>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicTrainingPrograms)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicTrainingProgram>()
                .HasOne(sc => sc.TrainingProgram)
                .WithMany(c => c.СurriculumTopicTrainingPrograms)
                .HasForeignKey(sc => sc.TrainingProgramId);

            base.OnModelCreating(modelBuilder);
        }
    }
}