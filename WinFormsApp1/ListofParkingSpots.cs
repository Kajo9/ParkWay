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
    public partial class ListofParkingSpots : Form
    {
        public int floorID;
        public ListofParkingSpots(int floorID)
        {
            InitializeComponent();
            this.floorID = floorID;
        }

        private void ListofParkingSpots_Load(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext()) 
            {
                LoadParkingSpotsData();
                dgvListParkingSpots.Columns["Name"].DisplayIndex = 0;
            }
        }

        private void LoadParkingSpotsData()
        {
            using (var context = new DatabaseContext())
            {
                var parkingspots = context.ParkingSpots
                                          .Where(ps => ps.FloorId == floorID)
                                          .Select(ps => new
                                          {
                                              ps.ID,
                                              ps.Name
                                          })
                                          .ToList();
                dgvListParkingSpots.DataSource = parkingspots;
                dgvListParkingSpots.Columns["ID"].Visible = false;
            }
        }
    }
}
