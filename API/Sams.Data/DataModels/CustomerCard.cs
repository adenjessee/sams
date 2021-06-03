using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class CustomerCard
    {
        public int Id { get; set; }
        public string mainCardNumber { get; set; }
        public string CVV { get; set; }
        public string expirationDate { get; set; }
        public string cardHolerName { get; set; }
    }
}
