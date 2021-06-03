using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class DaySchedule
    {
        public int Id { get; set; }
        public DayOfWeek day;
        public List<TimeSet> times;
    }
}
