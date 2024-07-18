using ParkWay.Globalno;
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
        public ReservePS()
        {
            InitializeComponent();
        }

        private void ReservePS_Load(object sender, EventArgs e)
        {
            ComboBoxLoadFloors();
        }

        private void ComboBoxLoadFloors()
        {
            using (var context = new DatabaseContext())
            {
                var floors = context.Floors.OrderBy(f => f.FloorName).ToList();
                cbFloor.DataSource = floors;
                cbFloor.DisplayMember = "FloorName";
                cbFloor.ValueMember = "ID";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvReservePS.Columns["Action"].Index && e.RowIndex >= 0)
            {
                int parkingSpotId = (int)dgvReservePS.Rows[e.RowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    var parkingSpot = context.ParkingSpots.Find(parkingSpotId);

                    if (parkingSpot != null && parkingSpot.isAvaible)
                    {
                        Reservation reservation = new Reservation
                        {
                            ParkingSpot = parkingSpot,
                            ReservationDate = DateTime.Now,
                            NumberOfDays = 1
                        };

                        context.Reservations.Add(reservation);
                        context.SaveChanges();

                        MessageBox.Show("Parking spot reserved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Parking spot is not available for reservation.");
                    }
                }
            }
        }
    }
}
