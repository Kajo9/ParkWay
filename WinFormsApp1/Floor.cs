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

    public partial class Floor : Form
    {
        private bool isUpdating = false;
        public Floor()
        {
            InitializeComponent();
        }

        private void Floor_Load(object sender, EventArgs e)
        {

            LoadFloorsData();
            dgvFloors.Columns["ID"].DisplayIndex = 0;
            dgvFloors.Columns["FloorName"].DisplayIndex = 1;
            dgvFloors.Columns["ParkingSpots"].DisplayIndex = 2;

        }

        private void LoadFloorsData()
        {
            using (var context = new DatabaseContext())
            {
                var floors = context.Floors
                                            .Select(f => new
                                            {
                                                f.ID,
                                                f.FloorName,
                                                ParkingSpots = string.Join(", ", f.ParkingSpots.Select(ps => ps.Name))
                                            })
                                            .ToList();
                dgvFloors.DataSource = floors;
            }
        }

        private void dgvFloors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFloors.SelectedRows.Count > 0)
            {
                isUpdating = true;
                int selectedRowIndex = dgvFloors.SelectedRows[0].Index;
                txtFloorID.Text = dgvFloors.Rows[selectedRowIndex].Cells["ID"].Value.ToString();
                txtFloorName.Text = dgvFloors.Rows[selectedRowIndex].Cells["FloorName"].Value.ToString();
            }
        }

        private void ResetForm()
        {
            isUpdating = false;
            txtFloorID.Text = string.Empty;
            txtFloorName.Text = string.Empty;
            dgvFloors.ClearSelection();
        }


        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvFloors.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvFloors.SelectedRows[0].Index;
                int floorsID = (int)dgvFloors.Rows[selectedRowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    bool hasParkingSpots = context.ParkingSpots.Any(p => p.FloorId == floorsID);
                    if (hasParkingSpots)
                    {
                        MessageBox.Show("Ne možete obrisati kat koji ima parkirna mjesta.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani red?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var floors = context.Floors.FirstOrDefault(f => f.ID == floorsID);
                        if (floors != null)
                        {
                            context.Floors.Remove(floors);
                            context.SaveChanges();

                            MessageBox.Show("Podaci su uspešno obrisani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadFloorsData();
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFloorName.Text))
            {
                using (var context = new DatabaseContext())
                {
                    if (isUpdating)
                    {
                        int floorID = int.Parse(txtFloorID.Text);
                        var existingFloor = context.Floors.FirstOrDefault(f => f.ID == floorID);
                        if (existingFloor != null)
                        {
                            if (context.Floors.Any(f => f.FloorName == txtFloorName.Text && f.ID != floorID))
                            {
                                MessageBox.Show("Naziv kata već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            existingFloor.FloorName = txtFloorName.Text;
                            context.SaveChanges();

                            MessageBox.Show("Podaci su uspješno ažurirani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvFloors.Rows[dgvFloors.SelectedRows[0].Index].Cells["FloorName"].Value = txtFloorName.Text;
                        }
                        else
                        {
                            MessageBox.Show("Nije pronađen zapis za ažuriranje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        var floor = new Models.Floor
                        {
                            FloorName = txtFloorName.Text,
                        };
                        context.Floors.Add(floor);
                        context.SaveChanges();

                        MessageBox.Show("Podaci su uspješno sačuvani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFloorsData();
                        ResetForm();
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate ispuniti polje!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isUpdating = false;
            txtFloorID.Text = string.Empty;
            txtFloorName.Text = string.Empty;
        }
    }
}
