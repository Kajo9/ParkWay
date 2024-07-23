using ParkWay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkWay
{
    public partial class ReservePS : Form
    {
        private int parkingspotID;
        public ReservePS(int parkingspotID)
        {
            InitializeComponent();
            this.parkingspotID = parkingspotID;
        }
    }
}
