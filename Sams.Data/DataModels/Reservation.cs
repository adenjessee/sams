using Sams.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class Reservation
    {
        public int Id { get; set; }
        public List<Customer> customers { get; set; }
        public List<Order> orders { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public int tableNumber { get; set; }
    }
}
