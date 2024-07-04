using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
    internal class ParkingSpot: Base
    {
        public string Name { get; set; }

        public Floor Floor { get; set; }
    }
}
