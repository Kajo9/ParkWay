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
        private bool isProgrammaticChange = false;
        public ParkingSpot()
        {
            InitializeComponent();
            LoadFloors();
        }

        private void ParkingSpace_Load(object sender, EventArgs e)
        {
            LoadFloors();
            LoadParkingSpotsData();
            dgvParkingspot.Columns["Name"].DisplayIndex = 0;
            dgvParkingspot.Columns["isAvaible"].DisplayIndex = 1;

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
                        .Select(ps => new
                        {
                            ps.ID,
                            ps.Name,
                            ps.isAvaible,
                            ps.FloorId
                        })
                        .ToList();
                    dgvParkingspot.DataSource = parkingSpots;

                    dgvParkingspot.Columns["ID"].Visible = false;
                    dgvParkingspot.Columns["FloorId"].Visible = false;
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

        private void dgvParkingspot_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvParkingspot.SelectedRows.Count > 0)
            {
                isUpdating = true;
                int selectedRowIndex = dgvParkingspot.SelectedRows[0].Index;
                txtParkingSpotID.Text = dgvParkingspot.Rows[selectedRowIndex].Cells["ID"].Value.ToString();
                txtParkingSpot.Text = dgvParkingspot.Rows[selectedRowIndex].Cells["Name"].Value.ToString();
                cbFloor.SelectedValue = dgvParkingspot.Rows[selectedRowIndex].Cells["FloorId"].Value;
                chbAvailable.Checked = (bool)dgvParkingspot.Rows[selectedRowIndex].Cells["isAvaible"].Value;

                isProgrammaticChange = true;
                chbAvailable.Checked = (bool)dgvParkingspot.Rows[selectedRowIndex].Cells["isAvaible"].Value;
                isProgrammaticChange = false;
            }
        }

        private void ResetForm()
        {
            isUpdating = false;
            txtParkingSpotID.Text = string.Empty;
            txtParkingSpot.Text = string.Empty;
            dgvParkingspot.ClearSelection();
            chbAvailable.Checked = false;
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            isUpdating = false;
            txtParkingSpotID.Text = string.Empty;
            txtParkingSpot.Text = string.Empty;
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

                    if (isUpdating)
                    {
                        int parkingspotID = int.Parse(txtParkingSpotID.Text);
                        var existingParkingSpot = context.ParkingSpots.FirstOrDefault(ps => ps.ID == parkingspotID);
                        if (existingParkingSpot != null)
                        {
                            if (context.ParkingSpots.Any(p => p.Name == txtParkingSpot.Text && p.FloorId == selectedFloorId && p.ID != parkingspotID))
                            {
                                MessageBox.Show("Naziv parkirnog mjesta već postoji na odabranom katu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            existingParkingSpot.Name = txtParkingSpot.Text;
                            existingParkingSpot.FloorId = selectedFloorId;
                            context.SaveChanges();

                            MessageBox.Show("Podaci su uspješno ažurirani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadParkingSpotsData();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen zapis za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (context.ParkingSpots.Any(p => p.Name == txtParkingSpot.Text && p.FloorId == selectedFloorId))
                        {
                            MessageBox.Show("Naziv parkirnog mjesta već postoji na odabranom katu!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoadParkingSpotsData();
        }

        private void chbAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange) return;

            if (dgvParkingspot.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvParkingspot.SelectedRows[0].Index;
                int parkingspotID = (int)dgvParkingspot.Rows[selectedRowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    var parkingSpot = context.ParkingSpots.FirstOrDefault(p => p.ID == parkingspotID);
                    if (parkingSpot != null)
                    {
                        bool newAvailability = chbAvailable.Checked;
                        if (parkingSpot.isAvaible != newAvailability)
                        {
                            parkingSpot.isAvaible = newAvailability;
                            context.SaveChanges();

                            MessageBox.Show("Status dostupnosti je uspješno ažuriran!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadParkingSpotsData();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati red za ažuriranje statusa dostupnosti.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
