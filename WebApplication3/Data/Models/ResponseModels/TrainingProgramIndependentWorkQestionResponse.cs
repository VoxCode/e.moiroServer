namespace e.moiroServer.Data.Models.ResponseModels
{
    public class TrainingProgramIndependentWorkQestionResponse
    {
        public int Id { get; set; }
        public int TrainingProgramId { get; set; }
        public int SerialNumber { get; set; }
        public string Name { get; set; }
        public string Content{ get; set; }
    }
}
