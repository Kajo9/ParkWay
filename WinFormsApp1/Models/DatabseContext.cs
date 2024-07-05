using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkWay.Models
{
     class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("@Data Source=.ASUS09_K SQLEXPRESS;Inital Catalog=master;User ID=ASUS09_K karlo_fmjlaai;Password")
        { 
        
        }

        public virtual DbSet<Floor> Floors { get; set; }
    }
}
