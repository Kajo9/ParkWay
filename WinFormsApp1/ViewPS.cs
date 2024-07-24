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
    public partial class ViewPS : Form
    {
        public int position = 0;

        public ViewPS()
        {
            InitializeComponent();
        }

        private void ViewPS_Load(object sender, EventArgs e)
        {
            LoadAvailableParkingSpots();
            LoadFloors();
            ConfigureDatagridview();
            LoadParkingSpots();
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

            if (!dgvViewPS.Columns.Contains("Notice"))
            {
                DataGridViewTextBoxColumn noticeColumn = new DataGridViewTextBoxColumn
                {
                    HeaderText = "Notice",
                    Name = "Notice",
                    DataPropertyName = "Notice"
                };
                dgvViewPS.Columns.Add(noticeColumn);
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
                    string selectedFilter = cbAvailablePS.SelectedItem?.ToString() ?? "All";
                    bool filterAvailable = selectedFilter == "Available";

                    var parkingSpotsQuery = context.ParkingSpots
                        .Where(ps => ps.FloorId == selectedFloorId)
                        .Select(ps => new
                        {
                            ps.ID,
                            ps.Name,
                            ps.FloorId,
                            ps.isAvailable,
                            Notice = context.Reservations
                                .Where(r => r.ParkingSpotId == ps.ID && r.From <= DateTime.Now && r.To >= DateTime.Now)
                                .Select(r => r.Notice)
                                .FirstOrDefault(),
                            IsReserved = context.Reservations
                                .Any(r => r.ParkingSpotId == ps.ID && r.From <= DateTime.Now && r.To >= DateTime.Now)
                        });

                    if (filterAvailable)
                    {
                        parkingSpotsQuery = parkingSpotsQuery.Where(ps => ps.isAvailable && !ps.IsReserved);
                    }

                    var parkingSpots = parkingSpotsQuery.ToList();
                    dgvViewPS.DataSource = parkingSpots;
                    HideUnnecessaryColumns();
                }
            }
        }

        private void LoadAvailableParkingSpots()
        {
            cbAvailablePS.Items.Clear();
            cbAvailablePS.Items.Add("All");
            cbAvailablePS.Items.Add("Available");
            cbAvailablePS.SelectedIndex = 0;
        }

        private void HideUnnecessaryColumns()
        {
            if (dgvViewPS.DataSource != null)
            {
                dgvViewPS.Columns["ID"].Visible = false;
                dgvViewPS.Columns["FloorId"].Visible = false;
                dgvViewPS.Columns["isAvailable"].Visible = false;
            }
        }

        private void ResetForm()
        {
            txtNotice.Text = string.Empty;
        }

        private void dgvViewPS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var column = dgvViewPS.Columns["Reserve"];
                if (column != null && e.ColumnIndex == column.Index)
                {
                    int parkingspotId = (int)dgvViewPS.Rows[e.RowIndex].Cells["ID"].Value;
                    var isReserved = (bool?)dgvViewPS.Rows[e.RowIndex].Cells["IsReserved"].Value;

                    if (cbFloor.SelectedValue == null)
                    {
                        MessageBox.Show("You must select a floor!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (isReserved == true)
                    {
                        MessageBox.Show("Parking spot is reserved or unavailable.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var reservePSform = new ReservePS(parkingspotId);
                    reservePSform.FormClosed += (s, args) => RefreshParkingSpots();
                    reservePSform.Show();
                }
            }
        }

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParkingSpots();
        }

        private void cbAvailablePS_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParkingSpots();
        }

        private void RefreshParkingSpots()
        {
            if (cbFloor.SelectedValue != null)
            {
                LoadParkingSpots();
            }
        }

        private void dgvViewPS_DoubleClick(object sender, EventArgs e)
        {
            if (dgvViewPS.SelectedRows.Count > 0)
            {
                var selectedIndex = dgvViewPS.SelectedRows[0].Index;
                position = int.Parse(dgvViewPS.Rows[selectedIndex].Cells["ID"].Value.ToString());

                var noticeValue = dgvViewPS.Rows[selectedIndex].Cells["Notice"].Value?.ToString();

                if (string.IsNullOrEmpty(noticeValue))
                {
                    txtNotice.Text = string.Empty;
                }
                else
                {
                    txtNotice.Text = noticeValue;
                }
                RefreshParkingSpots();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvViewPS_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvViewPS.Columns[e.ColumnIndex].Name == "Reserve" && e.RowIndex >= 0)
            {
                var isReserved = dgvViewPS.Rows[e.RowIndex].Cells["IsReserved"].Value as bool?;

                if (isReserved.HasValue && isReserved.Value)
                {
                    e.CellStyle.BackColor = Color.Gray;
                    e.CellStyle.ForeColor = Color.DarkGray;
                    e.CellStyle.SelectionBackColor = Color.Gray;
                    e.CellStyle.SelectionForeColor = Color.DarkGray;

                    dgvViewPS.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightBlue;
                    e.CellStyle.ForeColor = Color.Black;
                    e.CellStyle.SelectionBackColor = Color.Blue;
                    e.CellStyle.SelectionForeColor = Color.White;

                    dgvViewPS.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = false;
                }
            }
        }
    }
}
