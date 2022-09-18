using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_w64238.Models
{
    public class Rent
    {
        public Guid RentID { get; set; }

        public virtual Guid CarID { get; set; }

        public DateTime OutDate { get; set; }

        public DateTime InDate { get; set; }

        public int Duration { get; set; }

        public decimal Prize { get; set; }
    }
}