using System;
using System.Collections.Generic;

namespace e.moiroServer.Data.Models
{
    public class ClassTime
    {
        public int Id { get; set; }
        public DateTime ClassTimeStart { get; set; }
        public DateTime ClassTimeEnd { get; set; }
        public DateTime SecondTimeStart { get; set; }
        public DateTime SecondTimeEnd { get; set; }
        public int Shift { get; set; }
        public int DayOfTheWeek { get; set; }
        public List<ScheduleBlockClassTime> ScheduleBlockClassTimes { get; set; }
    }
}
