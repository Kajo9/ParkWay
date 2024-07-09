using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
    public partial class Purchases : Base
    {
        public User User { get; set; }
        public ParkingSpot ParkingSpot { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int NumberOfDays { get; set; }
        public decimal Amount {  get; set; }
    }
}
