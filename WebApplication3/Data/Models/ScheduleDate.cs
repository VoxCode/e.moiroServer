using System;
using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class ScheduleDate
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public List<ScheduleDateScheduleBlock> ScheduleDateSheduleBlocks { get; set; }
    }
}
