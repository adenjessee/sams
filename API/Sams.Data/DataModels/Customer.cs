
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class Customer : AppUser
    {
        public Point location { get; set; }
        public CustomerCard cardInfo { get; set; }
    }
}
