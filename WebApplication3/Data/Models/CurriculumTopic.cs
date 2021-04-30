using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class CurriculumTopic
    {
        public int Id { get; set; }
        public string TopicTitle { get; set; }
        public string Annotation { get; set; }
        public string AuthorIndex { get; set; }
        public ICollection<FinalExamination> FinalExaminations { get; set; }
        public ICollection<AdditionalLiterature> AdditionalLiteratures { get; set; }
        public ICollection<Regulation> Regulations { get; set; }
        public ICollection<MainLiterature> MainLiteratures { get; set; }
        public ICollection<TestWork> TestWorks { get; set; }
        public ICollection<StudentCategory> StudentCategories { get; set; }
        public ICollection<Department> Departments { get; set; }
        public ICollection<TrainingProgram> TrainingPrograms { get; set; }

    }
}
