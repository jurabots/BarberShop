using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models.ServicesAndPrice
{
    public class Service
    {
        public int Id { get; set; }
        public string OurService { get; set; }
        public short Price { get; set; }

    }
}
