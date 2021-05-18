namespace e.moiroServer.Data.Models
{
    public class TrainingProgramIndependentWorkQuestion
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public byte[] ContentDocx { get; set; }
    }
}
