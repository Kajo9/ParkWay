using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace ParkWay
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void floorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Floor floor = new Floor();
            floor.Show();
        }

        private void parkingSpotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParkingSpot parkingSpot = new ParkingSpot();
            parkingSpot.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
