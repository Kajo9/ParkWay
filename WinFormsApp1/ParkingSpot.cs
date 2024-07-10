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
        }

        private void ParkingSpace_Load(object sender, EventArgs e)
        {
            LoadParkingSpotsData();
            dgvParkingspot.Columns["ID"].DisplayIndex = 0;
            dgvParkingspot.Columns["Name"].DisplayIndex = 1;
            dgvParkingspot.Columns["isAvaible"].DisplayIndex = 2;

        }
        private void LoadParkingSpotsData()
        {
            using (var context = new DatabaseContext())
            {
                var parkingSpots = context.ParkingSpots.ToList();
                dgvParkingspot.DataSource = parkingSpots;
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
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvParkingspot.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvParkingspot.SelectedRows[0].Index;
                int parkingSpotID = (int)dgvParkingspot.Rows[selectedRowIndex].Cells["ID"].Value;

                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani red?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var parkingSpot = context.ParkingSpots.FirstOrDefault(p => p.ID == parkingSpotID);
                        if (parkingSpot != null)
                        {
                            context.ParkingSpots.Remove(parkingSpot);
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

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvParkingspot.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nije pronađen zapis za ažuriranje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isUpdating && !string.IsNullOrWhiteSpace(txtParkingSpot.Text))
            {
                using (var context = new DatabaseContext())
                {
                    int parkingSpotID = int.Parse(txtParkingSpotID.Text);
                    var existingSpot = context.ParkingSpots.FirstOrDefault(p => p.ID == parkingSpotID);
                    if (existingSpot != null)
                    {
                        if (context.ParkingSpots.Any(p => p.Name == txtParkingSpot.Text && p.ID != parkingSpotID))
                        {
                            MessageBox.Show("Naziv parkirnog mjesta već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        existingSpot.Name = txtParkingSpot.Text;
                        context.SaveChanges();

                        MessageBox.Show("Podaci su uspešno ažurirani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadParkingSpotsData();
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Nije pronađen zapis za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate ispuniti polje!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            isUpdating = false;
            txtParkingSpotID.Text = string.Empty;
            txtParkingSpot.Text = string.Empty;
            dgvParkingspot.ClearSelection();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtParkingSpot.Text))
            {
                using (var context = new DatabaseContext())
                {
                    if (context.ParkingSpots.Any(p => p.Name == txtParkingSpot.Text))
                    {
                        MessageBox.Show("Naziv parkirnog mjesta već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var parkingSpot = new Models.ParkingSpot
                    {
                        Name = txtParkingSpot.Text,
                    };
                    context.ParkingSpots.Add(parkingSpot);
                    context.SaveChanges();

                    MessageBox.Show("Podaci su uspešno sačuvani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadParkingSpotsData();
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Morate ispuniti polje!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
