using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
    public class Invoice: Base
    {
        public User User { get; set; }

        public DateTime InvoiceDate { get; set; }

        public ParkingSpot ParkingSpot { get; set; }

    }
}
