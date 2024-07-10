using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
    public partial class ParkingSpot: Base
    {
        public string Name { get; set; }
        public virtual Floor FloorName { get; set; }
        public bool isAvaible { get; set; }
    }
}
