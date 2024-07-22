using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkWay
{
    public partial class ReserveAdministration : Form
    {
        public int position = 0;

        public ReserveAdministration()
        {
            InitializeComponent();
        }

        private void ReserveAdministration_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ResetForm()
        {
            position = 0;
            txtPosition.Text = string.Empty;
            txtParkingSpot.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtReservationDate.Text = string.Empty;
        }

    }
}
