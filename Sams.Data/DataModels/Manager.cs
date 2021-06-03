using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class Manager : AppUser
    {
        public Restaurant managerResraurant { get; set; }
        public Schedule shift { get; set; }
    }
}
