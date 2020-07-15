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
        public DbSet<CurriculumTopic> CuriculumTopics { get; set; }
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

            //СurriculumTopicConsultationTopics
            modelBuilder.Entity<СurriculumTopicConsultationTopics>()
                .HasKey(t => new { t.CurriculumTopicId, t.ConsultationTopicsId });

            modelBuilder.Entity<СurriculumTopicConsultationTopics>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicConsultationTopics)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicConsultationTopics>()
                .HasOne(sc => sc.ConsultationTopics)
                .WithMany(c => c.СurriculumTopicConsultationTopics)
                .HasForeignKey(sc => sc.ConsultationTopicsId);

            //СurriculumTopicDepartmens
            modelBuilder.Entity<СurriculumTopicDepartmens>()
                .HasKey(t => new { t.CurriculumTopicId, t.DepartmensId });

            modelBuilder.Entity<СurriculumTopicDepartmens>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicDepartmens)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicDepartmens>()
                .HasOne(sc => sc.Departmens)
                .WithMany(c => c.СurriculumTopicDepartmens)
                .HasForeignKey(sc => sc.DepartmensId);

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
            modelBuilder.Entity<СurriculumTopicTheQuestions>()
                .HasKey(t => new { t.CurriculumTopicId, t.TheQuestionsId });

            modelBuilder.Entity<СurriculumTopicTheQuestions>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicTheQuestions)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicTheQuestions>()
                .HasOne(sc => sc.TheQuestions)
                .WithMany(c => c.СurriculumTopicTheQuestions)
                .HasForeignKey(sc => sc.TheQuestionsId);

            //СurriculumTopicTranningProgram
            modelBuilder.Entity<СurriculumTopicTranningProgram>()
                .HasKey(t => new { t.CurriculumTopicId, t.TranningProgramId });

            modelBuilder.Entity<СurriculumTopicTranningProgram>()
                .HasOne(sc => sc.CurriculumTopic)
                .WithMany(s => s.СurriculumTopicTranningPrograms)
                .HasForeignKey(sc => sc.CurriculumTopicId);

            modelBuilder.Entity<СurriculumTopicTranningProgram>()
                .HasOne(sc => sc.TranningProgram)
                .WithMany(c => c.СurriculumTopicTranningPrograms)
                .HasForeignKey(sc => sc.TranningProgramId);

            base.OnModelCreating(modelBuilder);
        }
    }
}