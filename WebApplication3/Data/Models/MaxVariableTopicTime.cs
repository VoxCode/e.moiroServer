﻿namespace e.moiroServer.Data.Models
{
    public class MaxVariableTopicTime
    {
        public int TrainingProgramCurriculumSectionId { get; set; }
        public TrainingProgramCurriculumSection TrainingProgramCurriculumSection { get; set; }
        public int OccupationFormId { get; set; }
        public OccupationForm OccupationForm { get; set; }
        public int MaxVariableTopicHours { get; set; }
    }
}
