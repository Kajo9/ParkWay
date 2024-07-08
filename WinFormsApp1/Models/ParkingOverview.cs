using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
    public partial class ParkingOverview : Base
    {
        public string ParkingSpotName { get; set; }
        public string FloorName { get; set; }
        public bool isReserved { get; set; }
    }

}
