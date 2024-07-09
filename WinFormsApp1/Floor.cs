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

        DatabaseContext db = new DatabaseContext();
        public Floor()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();

            this.Close();
        }

        private void Floor_Load(object sender, EventArgs e)
        {

            dgvFloors.DataSource = db.Floors.ToList();

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
            if (!string.IsNullOrWhiteSpace(txtFloor.Text))
            {
                using (var context = new DatabaseContext())
                {
                    var floor = new Models.Floor
                    {
                        FloorName = txtFloor.Text,
                    };

                    context.Floors.Add(floor);
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
            if (dgvFloors.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvFloors.SelectedRows[0].Index;
                int floorId = (int)dgvFloors.Rows[selectedRowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    var floor = context.Floors.FirstOrDefault(f => f.ID == floorId);
                    if (floor != null)
                    {
                        context.Floors.Remove(floor);
                        context.SaveChanges();

                        MessageBox.Show("Podaci su uspešno obrisani!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFloorsData();
                    }
                    else
                    {
                        MessageBox.Show("Nije pronađen zapis za brisanje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Morate odabrati red za brisanje.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
