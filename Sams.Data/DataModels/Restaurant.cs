using Microsoft.Spatial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Sams.Data.DataModels
{
    public class Restaurant
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public Point location { get; set; }
        public Schedule hours { get; set; }
        public string contactNumber { get; set; }
        public bool isHeadquarter { get; set; }
        public List<MenuItem> menuItems { get; set; }
        public byte[] tableMapImage { get; set; }
    }
}
