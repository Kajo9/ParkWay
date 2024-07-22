using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
    public partial class Reservation: Base
    {
        public int ParkingSpotId { get; set; }
        public ParkingSpot ParkingSpot { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
