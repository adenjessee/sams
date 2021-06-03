using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Common.Model
{
    class Reservation
    {
        public int Id { get; set; }
        public string ListTypeName { get; set; }
        public string DisplayValue { get; set; }
        public string Value { get; set; }
        public string HintText { get; set; }
        public string Description { get; set; }

    }
}
