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
        private Form openedForm = null;
        private int position = 0;

        public ReservePS()
        {
            InitializeComponent();
        }

        private void ReservePS_Load(object sender, EventArgs e)
        {
            ComboBoxLoadFloors();
            LoadParkingSpots();
        }

        private void ComboBoxLoadFloors()
        {
            using (var context = new DatabaseContext())
            {
                var floors = context.Floors.ToList();
                cbFloor.DataSource = floors;
                cbFloor.DisplayMember = "FloorName";
                cbFloor.ValueMember = "ID";
                cbFloor.SelectedIndex = -1; 
            }
        }

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParkingSpots();
        }

        private void LoadParkingSpots()
        {
            using (var context = new DatabaseContext())
            {
                if (cbFloor.SelectedValue != null)
                {
                    int selectedFloorId = (int)cbFloor.SelectedValue;
                    var parkingSpots = context.ParkingSpots
                        .Where(ps => ps.FloorId == selectedFloorId && ps.isAvaible)
                        .ToList();

                    dgvReservePS.DataSource = parkingSpots;
                    HideUnnecessaryColumns();
                }
            }
        }

        private void HideUnnecessaryColumns()
        {
            if (dgvReservePS.DataSource != null)
            {
                dgvReservePS.Columns["ID"].Visible = false;
                dgvReservePS.Columns["FloorId"].Visible = false;
                dgvReservePS.Columns["Floor"].Visible = false;
                dgvReservePS.Columns["isAvaible"].Visible = false;

                if (!dgvReservePS.Columns.Contains("Reserve parking spot"))
                {
                    DataGridViewButtonColumn btnListParkingSpots = new DataGridViewButtonColumn
                    {
                        HeaderText = "Available",
                        Text = "Reserve parking spot",
                        UseColumnTextForButtonValue = true,
                        Name = "Available"
                    };
                    dgvReservePS.Columns.Add(btnListParkingSpots);
                }
            }
        }

        private void dgvReservePS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvReservePS.Columns["Available"].Index)
            {
                int parkingSpotId = (int)dgvReservePS.Rows[e.RowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    var parkingSpot = context.ParkingSpots.FirstOrDefault(ps => ps.ID == parkingSpotId && ps.isAvaible);

                    if (parkingSpot != null)
                    {
                        var confirmResult = MessageBox.Show("Are you sure you want to reserve this parking spot?", "Confirm Reservation", MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            parkingSpot.isAvaible = false;
                            context.SaveChanges();


                            MessageBox.Show("Parking spot reserved successfully.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadParkingSpots(); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected parking spot is no longer available.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
