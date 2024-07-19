using ParkWay.Globalno;
using ParkWay.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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

            if (!dgvReservePS.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn reserveButtonColumn = new DataGridViewButtonColumn();
                reserveButtonColumn.Name = "Action";
                reserveButtonColumn.HeaderText = "Reserve";
                reserveButtonColumn.Text = "Reserve";
                reserveButtonColumn.UseColumnTextForButtonValue = true;
                dgvReservePS.Columns.Add(reserveButtonColumn);
            }
        }


        private void ComboBoxLoadFloors()
        {
            using (var context = new DatabaseContext())
            {
                var floors = context.Floors.ToList();
                cbFloor.DataSource = floors;
                cbFloor.DisplayMember = "FloorName";
                cbFloor.ValueMember = "ID";
            }
        }

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFloor.SelectedValue != null)
            {
                int selectedFloorId = (int)cbFloor.SelectedValue;
                LoadParkingSpots(selectedFloorId);
            }
        }

        private void LoadParkingSpots(int floorId)
        {
            using (var context = new DatabaseContext())
            {
                var parkingSpots = context.ParkingSpots
                                          .Where(p => p.FloorId == floorId && p.isAvaible)
                                          .Select(p => new { p.ID, p.Name, p.isAvaible })
                                          .ToList();

                dgvReservePS.DataSource = parkingSpots;
                dgvReservePS.Columns["ID"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservePS.Columns.Contains("Action") && e.ColumnIndex == dgvReservePS.Columns["Action"].Index && e.RowIndex >= 0)
            {
                int parkingSpotId = (int)dgvReservePS.Rows[e.RowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    var parkingSpot = context.ParkingSpots.Find(parkingSpotId);

                    if (parkingSpot != null && parkingSpot.isAvaible)
                    {
                        int userId = Global.LoggedUser.UserId;

                        Reservation reservation = new Reservation
                        {
                            UserId = userId,
                            ParkingSpotId = parkingSpotId,
                            ReservationDate = DateTime.Now,
                            NumberOfDays = 1
                        };

                        context.Reservations.Add(reservation);

                        parkingSpot.isAvaible = false;
                        context.SaveChanges();

                        MessageBox.Show("Parking spot reserved successfully.");
                        LoadParkingSpots((int)cbFloor.SelectedValue);
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
