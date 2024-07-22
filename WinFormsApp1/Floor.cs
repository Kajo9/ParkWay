using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ParkWay.Models;
using ParkWay.Globalno;

namespace ParkWay
{
    public partial class Floor : Form
    {
        public int position = 0;
        private Form openedForm = null;

        public Floor()
        {
            InitializeComponent();
        }

        private void Floor_Load(object sender, EventArgs e)
        {
            LoadFloorsData();
            ConfigureDataGridView();
        }

        private void LoadFloorsData()
        {
            using (var context = new DatabaseContext())
            {
                var floors = context.Floors.ToList();
                dgvFloors.DataSource = floors;
            }
        }

        private void ConfigureDataGridView()
        {
            dgvFloors.Columns["FloorName"].DisplayIndex = 0;
            dgvFloors.Columns["ParkingSpots"].Visible = false;
            dgvFloors.Columns["ID"].Visible = false;

            if (!dgvFloors.Columns.Contains("Show all parking spaces"))
            {
                DataGridViewButtonColumn btnListParkingSpots = new DataGridViewButtonColumn
                {
                    HeaderText = "Show all parking spaces",
                    Text = "Show",
                    UseColumnTextForButtonValue = true,
                    Name = "Show all parking spaces"
                };
                dgvFloors.Columns.Add(btnListParkingSpots);
            }
        }

        private void ResetForm()
        {
            position = 0;
            txtPosition.Text = string.Empty;
            txtFloorName.Text = string.Empty;
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvFloors.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvFloors.SelectedRows[0].Index;
                int floorID = (int)dgvFloors.Rows[selectedRowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    bool hasParkingSpots = context.ParkingSpots.Any(p => p.FloorId == floorID);
                    if (hasParkingSpots)
                    {
                        MessageBox.Show("You cannot delete a floor that has parking spaces.", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", Global.AppName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var floor = context.Floors.FirstOrDefault(f => f.ID == position);
                        if (floor != null)
                        {
                            context.Floors.Remove(floor);
                            context.SaveChanges();

                            MessageBox.Show("Data has been successfully deleted!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadFloorsData();
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string floorName = txtFloorName.Text;

            if (string.IsNullOrWhiteSpace(floorName))
            {
                MessageBox.Show("You must fill in the field!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new DatabaseContext())
            {
                if (position == 0)
                {
                    if (context.Floors.Any(f => f.FloorName == floorName))
                    {
                        MessageBox.Show("The name of the floor already exists!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var floor = new Models.Floor
                    {
                        FloorName = floorName
                    };

                    context.Floors.Add(floor);
                    context.SaveChanges();

                    ResetForm();
                    MessageBox.Show("Data has been saved successfully!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var floor = context.Floors.FirstOrDefault(a => a.ID == position);

                    if (floor != null)
                    {
                        if (context.Floors.Any(f => f.FloorName == floorName && f.ID != position))
                        {
                            MessageBox.Show("The name of the floor already exists!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        floor.FloorName = floorName;

                        context.Floors.Update(floor);
                        context.SaveChanges();

                        ResetForm();
                        MessageBox.Show("Data has been updated successfully!", Global.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            LoadFloorsData();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvFloors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var column = dgvFloors.Columns["Show all parking spaces"];
                if (column != null && e.ColumnIndex == column.Index)
                {
                    if (openedForm == null || openedForm.IsDisposed)
                    {
                        position = (int)dgvFloors.Rows[e.RowIndex].Cells["ID"].Value;
                        openedForm = new ListofParkingSpots(position);
                        openedForm.Show();

                        dgvFloors.Enabled = false;
                    }
                }
            }
        }

        private void OpenedForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            openedForm = null;
            dgvFloors.Enabled = true;
        }

        private void dgvFloors_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFloors.SelectedRows.Count > 0)
            {
                var selectedIndex = dgvFloors.SelectedRows[0].Index;
                position = int.Parse(dgvFloors.Rows[selectedIndex].Cells["ID"].Value.ToString());
                txtPosition.Text = dgvFloors.Rows[selectedIndex].Cells["ID"].Value.ToString();
                txtFloorName.Text = dgvFloors.Rows[selectedIndex].Cells["FloorName"].Value.ToString();
            }
        }
    }
}