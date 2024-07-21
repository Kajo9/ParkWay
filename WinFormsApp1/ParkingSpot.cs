using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkWay.Globalno;
using ParkWay.Models;

namespace ParkWay
{
    public partial class ParkingSpot : Form
    {
        public int position = 0;
        public bool isCheckChanged = false;

        public ParkingSpot()
        {
            InitializeComponent();
        }

        private void ParkingSpot_Load(object sender, EventArgs e)
        {
            LoadFloors();
            LoadParkingSpotsData();
            ConfigureDataGridView();
        }

        private void LoadParkingSpotsData()
        {
            using (var context = new DatabaseContext())
            {
                if (cbFloor.SelectedValue != null)
                {
                    int selectedFloorId = (int)cbFloor.SelectedValue;
                    var parkingSpots = context.ParkingSpots
                        .Where(ps => ps.FloorId == selectedFloorId)
                        .ToList();

                    dgvParkingspot.DataSource = parkingSpots;
                    HideUnnecessaryColumns();
                }
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

        private void ConfigureDataGridView()
        {
            dgvParkingspot.Columns["Name"].DisplayIndex = 0;
            dgvParkingspot.Columns["isAvaible"].DisplayIndex = 1;
        }

        private void HideUnnecessaryColumns()
        {
            dgvParkingspot.Columns["ID"].Visible = false;
            dgvParkingspot.Columns["FloorId"].Visible = false;
            dgvParkingspot.Columns["Floor"].Visible = false;
        }

        private void ResetForm()
        {
            position = 0;
            txtPosition.Text = string.Empty;
            txtParkingSpot.Text = string.Empty;
            cbFloor.SelectedIndex = -1;
            chbAvailable.Checked = false;
            dgvParkingspot.ClearSelection();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtParkingSpot.Text))
            {
                using (var context = new DatabaseContext())
                {
                    int selectedFloorId = (int)cbFloor.SelectedValue;
                    bool isAvailable = chbAvailable.Checked;

                    if (position != 0)
                    {
                        var existingParkingSpot = context.ParkingSpots.FirstOrDefault(ps => ps.ID == position);
                        if (existingParkingSpot != null)
                        {
                            if (context.ParkingSpots.Any(p => p.Name == txtParkingSpot.Text && p.FloorId == selectedFloorId && p.ID != position))
                            {
                                MessageBox.Show("The name of the parking space already exists on the selected floor!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            existingParkingSpot.Name = txtParkingSpot.Text;
                            existingParkingSpot.FloorId = selectedFloorId;
                            existingParkingSpot.isAvaible = isAvailable;
                            context.SaveChanges();

                            MessageBox.Show("Data has been updated successfully!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadParkingSpotsData();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("No update record found.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (context.ParkingSpots.Any(p => p.Name == txtParkingSpot.Text && p.FloorId == selectedFloorId))
                        {
                            MessageBox.Show("The name of the parking space already exists on the selected floor!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        var parkingspot = new Models.ParkingSpot
                        {
                            Name = txtParkingSpot.Text,
                            FloorId = selectedFloorId,
                            isAvaible = isAvailable
                        };
                        context.ParkingSpots.Add(parkingspot);
                        context.SaveChanges();

                        MessageBox.Show("Data has been saved successfully!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParkingSpotsData();
                        ResetForm();
                    }
                }
            }
            else
            {
                MessageBox.Show("You must fill in the field!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (position != 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", Global.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var parkingspot = context.ParkingSpots.FirstOrDefault(p => p.ID == position);
                        if (parkingspot != null)
                        {
                            context.ParkingSpots.Remove(parkingspot);
                            context.SaveChanges();

                            MessageBox.Show("Data has been successfully deleted!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadParkingSpotsData();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("No record found to delete.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You must select a row to delete.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadParkingSpotsData(); // Osvježi podatke parkirnih mjesta na temelju odabranog kata
        }

        private void chbAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (isCheckChanged) return;

            if (dgvParkingspot.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvParkingspot.SelectedRows[0].Index;
                position = (int)dgvParkingspot.Rows[selectedRowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    var parkingSpot = context.ParkingSpots.FirstOrDefault(p => p.ID == position);
                    if (parkingSpot != null)
                    {
                        bool newAvailability = chbAvailable.Checked;
                        if (parkingSpot.isAvaible != newAvailability)
                        {
                            parkingSpot.isAvaible = newAvailability;
                            context.SaveChanges();

                            MessageBox.Show("The availability status has been successfully updated!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadParkingSpotsData();
                        }
                    }
                }
            }
        }

        private void dgvParkingspot_DoubleClick(object sender, EventArgs e)
        {
            if (dgvParkingspot.SelectedRows.Count > 0)
            {
                var selectedIndex = dgvParkingspot.SelectedRows[0].Index;

                position = int.Parse(dgvParkingspot.Rows[selectedIndex].Cells["ID"].Value.ToString());
                txtPosition.Text = dgvParkingspot.Rows[selectedIndex].Cells["ID"].Value.ToString();
                txtParkingSpot.Text = dgvParkingspot.Rows[selectedIndex].Cells["Name"].Value.ToString();
                cbFloor.SelectedValue = dgvParkingspot.Rows[selectedIndex].Cells["FloorId"].Value;
                chbAvailable.Checked = (bool)dgvParkingspot.Rows[selectedIndex].Cells["isAvaible"].Value;

                isCheckChanged = true;
                isCheckChanged = false;
            }
        }
    }
}
