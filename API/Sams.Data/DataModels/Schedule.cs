using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class Schedule
    {
        public int Id { get; set; }
        public List<DaySchedule> weekSchedule { get; set; }
    }
}
