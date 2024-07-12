using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkWay.Models;

namespace ParkWay
{
    public partial class ParkingSpot : Form
    {

        private bool isUpdating = false;
        public ParkingSpot()
        {
            InitializeComponent();
            LoadFloors();
        }

        private void ParkingSpace_Load(object sender, EventArgs e)
        {
            LoadFloors();
            LoadParkingSpotsData();
            dgvParkingspot.Columns["ID"].DisplayIndex = 0;
            dgvParkingspot.Columns["Name"].DisplayIndex = 1;
            dgvParkingspot.Columns["isAvaible"].DisplayIndex = 2;

        }
        private void LoadParkingSpotsData()
        {
            using (var context = new DatabaseContext())
            {
                if (cbFloor.SelectedValue != null)
                {
                    int selectedFloorId = (int)cbFloor.SelectedValue;
                    var parkingSpots = context.ParkingSpots.Where(p => p.FloorId == selectedFloorId).ToList();
                    dgvParkingspot.DataSource = parkingSpots;
                }
            }
        }
        private void LoadFloors()
        {
            using (var context = new DatabaseContext())
            {
                var floors = context.Floors.ToList();
                foreach (var floor in floors)
                {
                    cbFloor.Items.Add(floor.FloorName);
                }
                cbFloor.DisplayMember = "FloorName";
                cbFloor.ValueMember = "ID";
                cbFloor.DataSource = floors;
            }
        }

        private void dgvParkingspot_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParkingspot.SelectedRows.Count > 0)
            {
                isUpdating = true;
                int selectedRowIndex = dgvParkingspot.SelectedRows[0].Index;
                txtParkingSpotID.Text = dgvParkingspot.Rows[selectedRowIndex].Cells["ID"].Value.ToString();
                txtParkingSpot.Text = dgvParkingspot.Rows[selectedRowIndex].Cells["Name"].Value.ToString();
                cbFloor.SelectedValue = dgvParkingspot.Rows[selectedRowIndex].Cells["FloorId"].Value;
            }
        }

        private void ResetForm()
        {
            isUpdating = false;
            txtParkingSpotID.Text = string.Empty;
            txtParkingSpot.Text = string.Empty;
            dgvParkingspot.ClearSelection();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isUpdating = false;
            txtParkingSpotID.Text = string.Empty;
            txtParkingSpot.Text = string.Empty;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtParkingSpot.Text))
            {
                using (var context = new DatabaseContext())
                {
                    if (isUpdating)
                    {
                        int parkingspotID = int.Parse(txtParkingSpot.Text);
                        var existingParkingSpot = context.ParkingSpots.FirstOrDefault(p => p.ID == parkingspotID);
                        if (existingParkingSpot != null)
                        {
                            if (context.ParkingSpots.Any(p => p.Name == txtParkingSpot.Text && p.ID != parkingspotID))
                            {
                                MessageBox.Show("Naziv kata već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            existingParkingSpot.Name = txtParkingSpot.Text;
                            context.SaveChanges();

                            MessageBox.Show("Podaci su uspješno ažurirani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvParkingspot.Rows[dgvParkingspot.SelectedRows[0].Index].Cells["Name"].Value = txtParkingSpot.Text;
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen zapis za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        var parkingspot = new Models.ParkingSpot
                        {
                            Name = txtParkingSpot.Text
                        };
                        context.ParkingSpots.Add(parkingspot);
                        context.SaveChanges();

                        MessageBox.Show("Podaci su uspješno sačuvani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParkingSpotsData();
                        ResetForm();
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate ispuniti polje!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvParkingspot.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvParkingspot.SelectedRows[0].Index;
                int parkingspotID = (int)dgvParkingspot.Rows[selectedRowIndex].Cells["ID"].Value;

                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani red?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var parkingspot = context.ParkingSpots.FirstOrDefault(p => p.ID == parkingspotID);
                        if (parkingspot != null)
                        {
                            context.ParkingSpots.Remove(parkingspot);
                            context.SaveChanges();

                            MessageBox.Show("Podaci su uspešno obrisani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadParkingSpotsData();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen zapis za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati red za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFloor = cbFloor.SelectedItem as Models.Floor;
            if (cbFloor.SelectedValue != null)
            {
                int selectedFloorId = selectedFloor.ID;
                string selectedFloorName = selectedFloor.FloorName;
            }
        }
    }
}
