using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string itemName { get; set; }
        public byte[] itemImage { get; set; }
        public string description { get; set; }
        public float itemPrice { get; set; }
        public string itemType { get; set; }
    }
}
