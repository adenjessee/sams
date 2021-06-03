using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class Order
    {
        public int Id { get; set; }
        public List<MenuItem> orderItems { get; set; }
        public Chef chefPreferances { get; set; }
    }
}
