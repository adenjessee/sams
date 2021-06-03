using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class Executive : AppUser
    {
        public List<Restaurant> restaurants { get; set; }
        public List<Schedule> allRestaurantHours { get; set; }
    }
}
