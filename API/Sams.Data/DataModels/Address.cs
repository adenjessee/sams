using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class Address
    {
        public int Id { get; set; }
        public string country { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }
}
