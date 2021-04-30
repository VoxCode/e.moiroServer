namespace e.moiroServer.Data.Models
{
    public class TrainingProgramFinalExamination
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public int SerialNumber { get; set; }
        public string Content { get; set; }
    }
}
