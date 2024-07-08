using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
    public partial class User: Base
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Role { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }    

    }
}
