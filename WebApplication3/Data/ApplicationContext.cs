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
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        public DbSet<AdditionalLiterature> AdditionalLiteratures { get; set; }
        public DbSet<CertificationType> CertificationTypes { get; set; }
        public DbSet<CurriculumTopic> CurriculumTopics { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FinalExamination> FinalExaminations { get; set; }
        public DbSet<FormOfEducation> FormOfEducations { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<MainLiterature> MainLiteratures { get; set; }
        public DbSet<OccupationForm> OccupationForms { get; set; }
        public DbSet<Regulation> Regulations { get; set; }
        public DbSet<StudentCategory> StudentCategories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TestWork> TestWorks { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<ScheduleBlock> ScheduleBlocks { get; set; }
        public DbSet<ScheduleDate> ScheduleDates { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<ClassTime> ClassTimes { get; set; }
        public DbSet<InstituteStructure> InstituteStructures { get; set; }
        public DbSet<GuidedTestWorkAssignment> GuidedTestWorkAssignments { get; set; }

        public DbSet<TrainingProgramAdditionalLiterature> TrainingProgramAdditionalLiteratures { get; set; }
        public DbSet<TrainingProgramCurriculumSection> TrainingProgramCurriculumSections { get; set; }
        public DbSet<TrainingProgramFinalExamination> TrainingProgramFinalExaminations { get; set; }
        public DbSet<TrainingProgramMainLiterature> TrainingProgramMainLiteratures { get; set; }
        public DbSet<TrainingProgramRegulation> TrainingProgramRegulations { get; set; }
        public DbSet<TrainingProgramTeacher> TrainingProgramTeachers { get; set; }
        public DbSet<TrainingProgramTestWork> TrainingProgramTestWorks { get; set; }
        public DbSet<TrainingProgramIntroduction> TrainingProgramIntroductions { get; set; }
        public DbSet<TrainingProgramIndependentWorkQuestion> TrainingProgramIndependentWorkQuestions { get; set; }
        public DbSet<CurriculumTopicTrainingProgram> CurriculumTopicTrainingPrograms { get; set; }

        public DbSet<ScheduleBlockTeacher> ScheduleBlockTeachers { get; set; }
        public DbSet<ScheduleBlockClassRoom> ScheduleBlockClassRooms { get; set; }
        public DbSet<ScheduleBlockClassTime> ScheduleBlockClassTimes { get; set; }
        public DbSet<ScheduleBlockCurriculumTopicTrainingProgram> ScheduleBlockCurriculumTopicTrainingPrograms { get; set; }
        public DbSet<ScheduleDateScheduleBlock> ScheduleDateScheduleBlocks { get; set; }
        public DbSet<OccupationFormClassHour> OccupationFormClassHours { get; set; }
        public DbSet<MaxVariableTopicTime> MaxVariableTopicTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<TrainingProgramCurriculumSection>()
                .HasMany(a => a.OccupationForms)
                .WithMany(b => b.TrainingProgramCurriculumSections)
                .UsingEntity<MaxVariableTopicTime>(
                a => a
                    .HasOne(b => b.OccupationForm)
                    .WithMany(c => c.MaxVariableTopicTimes).HasForeignKey(a => a.OccupationFormId),
                a => a
                    .HasOne(b => b.TrainingProgramCurriculumSection)
                    .WithMany(d => d.MaxVariableTopicTimes)
                    .HasForeignKey(b => b.TrainingProgramCurriculumSectionId),
                a =>
                {
                    a.Property(b => b.MaxVariableTopicHours).HasDefaultValue(0);
                    a.HasKey(c => new { c.TrainingProgramCurriculumSectionId, c.OccupationFormId });
                    a.ToTable("MaxVariableTopicTimes");
                });

            modelBuilder
                .Entity<CurriculumTopicTrainingProgram>()
                .HasMany(a => a.OccupationForms)
                .WithMany(b => b.CurriculumTopicTrainingPrograms)
                .UsingEntity<OccupationFormClassHour>(
                a => a
                    .HasOne(b => b.OccupationForm)
                    .WithMany(c => c.OccupationFormClassHours).HasForeignKey(a => a.OccupationFormId),
                a => a
                    .HasOne(b => b.CurriculumTopicTrainingProgram)
                    .WithMany(d => d.OccupationFormClassHours)
                    .HasForeignKey(b => b.CurriculumTopicTrainingProgramId),
                a =>
                {
                    a.Property(b => b.SerialNumber).HasDefaultValue(0);
                    a.Property(b => b.ClassHours).HasDefaultValue(0);
                    a.HasKey(c => new { c.CurriculumTopicTrainingProgramId, c.OccupationFormId });
                    a.ToTable("OccupationFormClassHours");
                });



            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration(new RoleConfiguration());
            //modelBuilder.ApplyConfiguration(new OccupationFormConfiguration());
            //modelBuilder.ApplyConfiguration(new CertificationTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new FormOfEducationConfiguration());
            //modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            //modelBuilder.ApplyConfiguration(new ExpertConfiguration());
        }
    }
}