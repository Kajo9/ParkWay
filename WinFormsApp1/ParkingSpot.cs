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

        DatabaseContext db = new DatabaseContext();
        public ParkingSpot()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtParkingspot.Text))
            {
                using (var context = new DatabaseContext())
                {
                    var parkingSpot = new Models.ParkingSpot
                    {
                        Name = txtParkingspot.Text,
                    };

                    context.ParkingSpots.Add(parkingSpot);
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
            if (dgvParkingspot.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvParkingspot.SelectedRows[0].Index;
                int parkingSpotID = (int)dgvParkingspot.Rows[selectedRowIndex].Cells["ID"].Value;

                using (var context = new DatabaseContext())
                {
                    var parkingSpot = context.ParkingSpots.FirstOrDefault(f => f.ID == parkingSpotID);
                    if (parkingSpot != null)
                    {
                        context.ParkingSpots.Remove(parkingSpot);
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

        private void ParkingSpace_Load(object sender, EventArgs e)
        {
            dgvParkingspot.DataSource = db.ParkingSpots.ToList();
        }
        private void LoadFloorsData()
        {
            using (var context = new DatabaseContext())
            {
                var parkingSpot = context.ParkingSpots.ToList();
                dgvParkingspot.DataSource = parkingSpot;
            }
        }
    }
}
