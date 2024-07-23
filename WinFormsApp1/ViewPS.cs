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
    public partial class ViewPS : Form
    {
        public int position = 0;

        public ViewPS()
        {
            InitializeComponent();
        }

        private void ReservePS_Load(object sender, EventArgs e)
        {
            LoadFloors();
            LoadParkingSpots();
            ComboBoxLoadFloors();
            ConfigureDatagridview();
        }

        private void ConfigureDatagridview()
        {
            dgvViewPS.Columns["Name"].DisplayIndex = 0;
            dgvViewPS.Columns["ID"].Visible = false;

            if (!dgvViewPS.Columns.Contains("Reserve"))
            {
                DataGridViewButtonColumn btnReserve = new DataGridViewButtonColumn
                {
                    HeaderText = "Reserve",
                    Text = "Reserve",
                    UseColumnTextForButtonValue = true,
                    Name = "Reserve"
                };
                dgvViewPS.Columns.Add(btnReserve);
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
                cbFloor.SelectedIndex = -1;
            }
        }

        private void LoadFloors()
        {
            using (var context = new DatabaseContext())
            {
                var floors = context.Floors.ToList();
                cbFloor.DisplayMember = "FloorName";
                cbFloor.ValueMember = "ID";
                cbFloor.DataSource = floors;
            }
        }

        private void LoadParkingSpots()
        {
            using (var context = new DatabaseContext())
            {
                context.RefreshParkingSpotStatus();

                if (cbFloor.SelectedValue != null)
                {
                    int selectedFloorId = (int)cbFloor.SelectedValue;
                    var parkingSpots = context.ParkingSpots
                        .Where(ps => ps.FloorId == selectedFloorId)
                        .ToList();

                    dgvViewPS.DataSource = parkingSpots;
                    HideUnnecessaryColumns();
                }
            }
        }

        private void HideUnnecessaryColumns()
        {
            if (dgvViewPS.DataSource != null)
            {
                dgvViewPS.Columns["ID"].Visible = false;
                dgvViewPS.Columns["FloorId"].Visible = false;
                dgvViewPS.Columns["Floor"].Visible = false;
                dgvViewPS.Columns["isAvailable"].Visible = false;
            }
        }

        private void dgvViewPS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var column = dgvViewPS.Columns["Reserve"];
                if (column != null && e.ColumnIndex == column.Index)
                {
                    int parkingspotId = (int)dgvViewPS.Rows[e.RowIndex].Cells["ID"].Value;

                    if (cbFloor.SelectedValue == null)
                    {
                        MessageBox.Show("You must select a floor!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (var context = new DatabaseContext())
                    {
                        var reservation = context.Reservations.FirstOrDefault(r => r.ParkingSpotId == parkingspotId && r.From <= DateTime.Now && r.To >= DateTime.Now);
                        if (reservation != null)
                        {
                            MessageBox.Show("Parking spot is reserved.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    var reservePSform = new ReservePS(parkingspotId);
                    reservePSform.Show();
                }
            }
        }

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParkingSpots();
        }
    }
}
