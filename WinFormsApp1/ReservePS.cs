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
            }
        }

        private void LoadParkingSpots()
        {
            using (var context = new DatabaseContext())
            {
                var parkingSpots = context.ParkingSpots.ToList();

                dgvReservePS.DataSource = parkingSpots;
                dgvReservePS.Columns["ID"].Visible = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
