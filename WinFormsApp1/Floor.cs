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

        public Floor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Close();
        }

        private void Floor_Load(object sender, EventArgs e)
        {

            LoadFloorsData();
            dgvFloors.Columns["ID"].DisplayIndex = 0;
            dgvFloors.Columns["FloorName"].DisplayIndex = 1;

        }

        private void LoadFloorsData()
        {
            using (var context = new DatabaseContext())
            {
                var floors = context.Floors.ToList();
                dgvFloors.DataSource = floors;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFloorName.Text))
            {
                using (var context = new DatabaseContext())
                {
                    int floorId;
                    if (int.TryParse(txtFloorID.Text, out floorId))
                    {
                        var existingFloor = context.Floors.FirstOrDefault(f => f.ID == floorId);
                        if (existingFloor != null)
                        {
                            if (context.Floors.Any(f => f.FloorName == txtFloorName.Text && f.ID != floorId))
                            {
                                MessageBox.Show("Naziv kata već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            existingFloor.FloorName = txtFloorName.Text;
                        }
                    }
                    else
                    {
                        if (context.Floors.Any(f => f.FloorName == txtFloorName.Text))
                        {
                            MessageBox.Show("Naziv kata već postoji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var floor = new Models.Floor
                        {
                            FloorName = txtFloorName.Text,
                        };
                        context.Floors.Add(floor);
                    }
                    context.SaveChanges();
                    MessageBox.Show("Podaci su uspešno sačuvani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFloorsData();
                }
            }
            else
            {
                MessageBox.Show("Morate ispuniti polje!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFloors.CurrentCell != null)
            {
                int rowIndex = dgvFloors.CurrentCell.RowIndex;
                int floorId = (int)dgvFloors.Rows[rowIndex].Cells["ID"].Value;

                DialogResult result = MessageBox.Show("Jeste li sigurni da želite obrisati odabrani red?", "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var context = new DatabaseContext())
                    {
                        var floor = context.Floors.FirstOrDefault(f => f.ID == floorId);
                        if (floor != null)
                        {
                            context.Floors.Remove(floor);
                            context.SaveChanges();

                            MessageBox.Show("Podaci su uspješno obrisani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadFloorsData();
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
                MessageBox.Show("Morate odabrati ćeliju za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvFloors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFloors.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvFloors.SelectedRows[0].Index;
                txtFloorID.Text = dgvFloors.Rows[selectedRowIndex].Cells["ID"].Value.ToString();
                txtFloorName.Text = dgvFloors.Rows[selectedRowIndex].Cells["FloorName"].Value.ToString();
            }
        }
    }
}
