using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_w64238.Models
{
    public class Car
    {
        public Guid CarID { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int ProductionYear { get; set; }

        public int HorsePower { get; set; }

        public int Capacity { get; set; }

        public decimal Prize { get; set; }

        public Uri Image { get; set; }
    }
}